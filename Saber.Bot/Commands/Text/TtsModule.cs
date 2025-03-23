using Azure.Core;
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
using NetCord;
using NetCord.Rest;
using NetCord.Services.Commands;
using Saber.Bot.Core.Extensions;

namespace Saber.Bot.Commands.Text
{
    public class TtsModule(AudioService service, HttpClient httpClient) : MessageCommandModule<CommandContext>
    {
        [Command("tts-join")]
        public async Task JoinChannel(IVoiceGuildChannel? channel = null)
        {
            var vc = await GetVoiceChannel(channel);

            if (vc != null)
                await service.JoinAudio(Context.Guild, vc);
        }

        [Command("tts-leave")]
        public async Task LeaveChannel()
        {
            await service.LeaveAudio(Context.Guild);
        }

        [Command("tts-stop")]
        public async Task Stop()
        {
            await service.StopAudioAsync(Context.Guild);
        }

        [Command("tts-say")]
        public async Task Say(string text)
        {
            if (Context.Guild == null)
            {
                await ReplyAsync(new ReplyMessageProperties
                {
                    Content = "This command must be used in a guild.",
                });
                return;
            }
            
            string speech = "";
            bool textIsUrl = Uri.TryCreate(text, UriKind.Absolute, out var uriResult) 
                             && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

            if (textIsUrl)
            {
                var resp = await httpClient.GetAsync(uriResult);
                if (resp.IsSuccessStatusCode && (resp.Content.Headers.ContentType == null || resp.Content.Headers.ContentType?.MediaType == "text/plain")) // Treat null content type as a plain text response
                {
                    speech = await resp.Content.ReadAsStringAsync();
                }
            }
            else
            {
                speech = text;
            }

            var ttsResp = await httpClient.PostAsJsonAsync("https://t.rnny.xyz/tts", new
            {
                text = speech,
            });

            if (ttsResp.IsSuccessStatusCode)
            {
                byte[] ttsRespBytes = await ttsResp.Content.ReadAsByteArrayAsync();

                if (ttsRespBytes.Length > 0)
                {
                    MemoryStream ms = new MemoryStream(ttsRespBytes);
                    await service.SendAudioAsync(Context.Guild, Context.Channel, new Audio(ms));
                }
            }
            
            await Context.Message.AddReactionAsync("👍");
        }

        public async Task<IVoiceGuildChannel?> GetVoiceChannel(IVoiceGuildChannel? channel = null)
        {
            // Get the audio channel
            if (channel != null)
                return channel;
            
            var user = Context.User as GuildUser;
            if (user == null)
                return null;
            
            var voiceState = await user.GetVoiceStateAsync();
            var channelId = voiceState.ChannelId;
            if (channelId == null)
                return null;
            
            return Context.Guild?.Channels[channelId.Value] as IVoiceGuildChannel;
        }
    }
}
