using Azure.Core;
using Discord;
using Discord.Audio;
using Discord.Interactions;
using Discord.WebSocket;
using Saber.Bot.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Saber.Bot.Commands.Interactions
{
    [Group("tts", "Text-to-speech using DecTalk")]
    public class TtsInteractionModule : InteractionModuleBase<SocketInteractionContext>
    {
        private readonly AudioService _service;
        private readonly HttpClient _httpClient;

        public TtsInteractionModule(AudioService service, HttpClient httpClient)
        {
            _service = service;
            _httpClient = httpClient;
        }

        [SlashCommand("join", "Join voice channel.", runMode: RunMode.Async)]
        public async Task JoinChannel(IVoiceChannel? channel = null)
        {
            await DeferAsync(true);

            IVoiceChannel? vc = GetVoiceChannel(channel);

            if (vc == null)
            {
                await FollowupAsync("You must be in a voice channel to use this command.", ephemeral: true);
                return;
            }

            await _service.JoinAudio(Context.Guild, vc);

            await FollowupAsync("Done!", ephemeral: true);
            await Context.Interaction.DeleteOriginalResponseAsync();
        }

        [SlashCommand("leave", "Leave current voice channel.", runMode: RunMode.Async)]
        public async Task LeaveChannel()
        {
            await DeferAsync(true);
            await _service.LeaveAudio(Context.Guild);

            await FollowupAsync("Done!", ephemeral: true);
            await Context.Interaction.DeleteOriginalResponseAsync();
        }

        [SlashCommand("stop", "Interrupt the bot and stop playing audio.", runMode: RunMode.Async)]
        public async Task Stop()
        {
            await DeferAsync(true);
            _service.StopAudioAsync(Context.Guild);

            await FollowupAsync("Done!", ephemeral: true);
            await Context.Interaction.DeleteOriginalResponseAsync();
        }

        [SlashCommand("say", "Says something with TTS.", runMode: RunMode.Async)]
        public async Task Say(string text)
        {
            await DeferAsync(true);

            var speechTask = Task.Run(async () =>
            {
                string speech = "";

                Uri uriResult;
                bool textIsUrl = Uri.TryCreate(text, UriKind.Absolute, out uriResult)
                    && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

                if (textIsUrl)
                {
                    var resp = await _httpClient.GetAsync(uriResult);
                    if (resp != null && resp.IsSuccessStatusCode && (resp.Content.Headers.ContentType == null || resp.Content.Headers.ContentType?.MediaType == "text/plain")) // Treat null content type as a plain text response
                    {
                        speech = await resp.Content.ReadAsStringAsync();
                    }
                }
                else
                {
                    speech = text;
                }

                var ttsResp = await _httpClient.PostAsJsonAsync("https://t.rnny.xyz/tts", new
                {
                    text = speech,
                });

                if (ttsResp != null && ttsResp.IsSuccessStatusCode)
                {
                    byte[] ttsRespBytes = await ttsResp.Content.ReadAsByteArrayAsync();

                    if (ttsRespBytes.Length > 0)
                    {
                        MemoryStream ms = new MemoryStream(ttsRespBytes);

                        await _service.SendAudioAsync(Context.Guild, Context.Channel, ms);
                    }
                }
            });

            await FollowupAsync("Done!", ephemeral: true);
            await Context.Interaction.DeleteOriginalResponseAsync();
        }

        public IVoiceChannel? GetVoiceChannel(IVoiceChannel? channel = null)
        {
            // Get the audio channel
            return channel ?? (Context.User as IGuildUser)?.VoiceChannel;
        }
    }
}
