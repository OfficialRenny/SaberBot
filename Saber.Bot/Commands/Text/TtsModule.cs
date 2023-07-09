using Azure.Core;
using Discord;
using Discord.Audio;
using Discord.Commands;
using Discord.WebSocket;
using Saber.Common.Services;
using Saber.Common.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Saber.Bot.Commands.Text
{
    [Group("tts")]
    public class TtsModule : ModuleBase<SocketCommandContext>
    {
        private readonly AudioService _service;
        private readonly HttpClient _httpClient;

        public TtsModule(AudioService service, HttpClient httpClient)
        {
            _service = service;
            _httpClient = httpClient;
        }

        [Command("join", RunMode = RunMode.Async)]
        public async Task JoinChannel(IVoiceChannel? channel = null)
        {
            var vc = await GetVoiceChannel(channel);

            if (vc != null)
                await _service.JoinAudio(Context.Guild, vc);
        }

        [Command("leave", RunMode = RunMode.Async)]
        public async Task LeaveChannel()
        {
            await _service.LeaveAudio(Context.Guild);
        }

        [Command("stop", RunMode = RunMode.Async)]
        public Task Stop()
        {
            _service.StopAudioAsync(Context.Guild);
            return Task.CompletedTask;
        }

        [Command("say", RunMode = RunMode.Async)]
        [Summary("Says something with TTS.")]
        public Task Say([Remainder] string text)
        {
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

                        await _service.SendAudioAsync(Context.Guild, Context.Channel, new Audio(ms));
                    }
                }

                return;
            });

            return speechTask;
        }

        public async Task<IVoiceChannel?> GetVoiceChannel(IVoiceChannel? channel = null)
        {
            // Get the audio channel
            channel = channel ?? (Context.User as IGuildUser)?.VoiceChannel;
            if (channel == null) 
            { 
                await Context.Message.ReplyAsync("User must be in a voice channel, or a voice channel must be passed as an argument.");
                return null;
            }

            return channel;
        }
    }
}
