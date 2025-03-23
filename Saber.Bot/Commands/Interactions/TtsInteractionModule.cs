﻿using Saber.Common.Services;
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
using NetCord.Services.ApplicationCommands;
using Saber.Bot.Core.Extensions;

namespace Saber.Bot.Commands.Interactions
{
    [SlashCommand("tts", "Text-to-speech using DecTalk")]
    public class TtsInteractionModule(AudioService service, HttpClient httpClient)
        : InteractionModule<ApplicationCommandContext>
    {
        [SubSlashCommand("join", "Join voice channel.")]
        public async Task JoinChannel(IVoiceGuildChannel? channel = null)
        {
            await DeferAsync(true);

            channel = await GetVoiceChannel(channel);

            if (channel == null)
            {
                await FollowupAsync(new InteractionMessageProperties
                {
                    Content = "You must be in a voice channel to use this command.",
                    Flags = MessageFlags.Ephemeral,
                });
                return;
            }

            if (Context.Guild == null)
            {
                await FollowupAsync(new InteractionMessageProperties
                {
                    Content = "This command must be used in a guild.",
                    Flags = MessageFlags.Ephemeral,
                });
                return;
            }
            
            await service.JoinAudio(Context.Guild, channel);

            await FollowupAsync(new InteractionMessageProperties
            {
                Content = "Done!",
                Flags = MessageFlags.Ephemeral,
            });
            
            await Context.Interaction.DeleteResponseAsync();
        }

        [SubSlashCommand("leave", "Leave current voice channel.")]
        public async Task LeaveChannel()
        {
            await DeferAsync(true);
            
            if (Context.Guild == null)
            {
                await FollowupAsync(new InteractionMessageProperties
                {
                    Content = "This command must be used in a guild.",
                    Flags = MessageFlags.Ephemeral,
                });
                return;
            }
            
            await service.LeaveAudio(Context.Guild);

            await FollowupAsync(new InteractionMessageProperties
            {
                Content = "Done!",
                Flags = MessageFlags.Ephemeral,
            });
            
            await Context.Interaction.DeleteResponseAsync();
        }

        [SubSlashCommand("stop", "Interrupt the bot and stop playing audio.")]
        public async Task Stop()
        {
            await DeferAsync(true);
            
            if (Context.Guild == null)
            {
                await FollowupAsync(new InteractionMessageProperties
                {
                    Content = "This command must be used in a guild.",
                    Flags = MessageFlags.Ephemeral,
                });
                return;
            }
            
            service.StopAudioAsync(Context.Guild);

            await FollowupAsync(new InteractionMessageProperties
            {
                Content = "Done!",
                Flags = MessageFlags.Ephemeral,
            });
            
            await Context.Interaction.DeleteResponseAsync();
        }

        [SubSlashCommand("say", "Says something with TTS.")]
        public async Task Say(string text)
        {
            await DeferAsync(true);

            if (Context.Guild == null)
            {
                await FollowupAsync(new InteractionMessageProperties
                {
                    Content = "This command must be used in a guild.",
                    Flags = MessageFlags.Ephemeral,
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

            await FollowupAsync(new InteractionMessageProperties
            {
                Content = "Done!",
                Flags = MessageFlags.Ephemeral,
            });
            await Context.Interaction.DeleteResponseAsync();
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
