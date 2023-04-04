using System.Collections.Concurrent;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using Discord;
using Discord.Audio;
using Discord.WebSocket;
using NAudio.Wave;

namespace SaberBot.Core
{
    public class AudioService
    {
        private readonly ConcurrentDictionary<ulong, IAudioClient> ConnectedChannels = new ConcurrentDictionary<ulong, IAudioClient>();
        private readonly Logger _logger;

        public AudioService (Logger logger)
        {
            _logger = logger;
        }

        public async Task JoinAudio(IGuild guild, IVoiceChannel target)
        {
            IAudioClient client;
            if (ConnectedChannels.TryGetValue(guild.Id, out client))
            {
                return;
            }
            if (target.Guild.Id != guild.Id)
            {
                return;
            }

            var audioClient = await target.ConnectAsync();

            if (ConnectedChannels.TryAdd(guild.Id, audioClient))
            {
                await _logger.Log(LogSeverity.Info, "AudioService", $"Connected to voice on {guild.Name}.");
            }
        }

        public async Task LeaveAudio(IGuild guild)
        {
            IAudioClient client;
            if (ConnectedChannels.TryRemove(guild.Id, out client))
            {
                await client.StopAsync();
                await _logger.Log(LogSeverity.Info, "AudioService", $"Disconnected from voice on {guild.Name}.");
            }
        }

        public async Task StopAudioAsync(IGuild guild)
        {
            IAudioClient client;
            if (ConnectedChannels.TryGetValue(guild.Id, out client))
            {
                await client.StopAsync();
            }
        }

        public async Task SendAudioAsync(IGuild guild, IMessageChannel channel, Stream audioStream)
        {
            IAudioClient client;
            if (ConnectedChannels.TryGetValue(guild.Id, out client))
            {
                await client.SetSpeakingAsync(true);
                await _logger.LogAsync(new LogMessage(LogSeverity.Info, "SendAudioAsync", $"Starting playback in {guild.Name}"));

                var outputFormat = new WaveFormat(48000, 16, 2);

                using (var pcmStream = new WaveFormatConversionStream(outputFormat, new WaveFileReader(audioStream)))
                using (var stream = client.CreatePCMStream(AudioApplication.Mixed))
                {
                    try 
                    { 
                        await pcmStream.CopyToAsync(stream);
                        await _logger.LogAsync(new LogMessage(LogSeverity.Info, "SendAudioAsync", "Finished copying incoming stream to audio client stream"));
                    }
                    catch (Exception ex) { await _logger.LogAsync(new LogMessage(LogSeverity.Error, "SendAudioAsync", "Error copying pcmStream to stream", ex)); }
                    finally { await stream.FlushAsync(); }
                }
                await client.SetSpeakingAsync(false);
            }
        }
    }
}