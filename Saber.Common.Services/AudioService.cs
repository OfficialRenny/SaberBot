using System.Collections.Concurrent;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using CliWrap;
using CliWrap.Buffered;
using NetCord;
using NetCord.Gateway;
using NetCord.Gateway.Voice;
using Saber.Common.Services.Interfaces;
using Saber.Common.Services.Models;

namespace Saber.Common.Services
{
    public class AudioService(ILogger logger, GatewayClient client)
    {
        private readonly ConcurrentDictionary<ulong, AsyncAudioClient> _connectedChannels = new ConcurrentDictionary<ulong, AsyncAudioClient>();

        public async Task JoinAudio(Guild guild, IVoiceGuildChannel target)
        {
            if (_connectedChannels.TryGetValue(guild.Id, out _))
                return;

            if (target.GuildId != guild.Id)
                return;

            var audioClient = await client.JoinVoiceChannelAsync(guild.Id, target.Id);

            if (_connectedChannels.TryAdd(guild.Id, new AsyncAudioClient(audioClient)))
                await logger.LogAsync(LogSeverity.Info, "AudioService", $"Connected to voice on {guild.Name}.");
        }

        public async Task LeaveAudio(Guild guild)
        {
            if (_connectedChannels.TryRemove(guild.Id, out var client))
            {
                client.Stop(false);
                await logger.LogAsync(LogSeverity.Info, "AudioService", $"Disconnected from voice on {guild.Name}.");
            }
        }

        public async Task StopAudioAsync(Guild guild)
        {
            if (_connectedChannels.TryGetValue(guild.Id, out var client))
            {
                client.Stop();
                await logger.LogAsync(LogSeverity.Info, "AudioService", $"Stopped playback in {guild.Name}");
            }
        }

        public async Task SendAudioAsync(Guild guild, TextChannel channel, IAudio audio)
        {
            if (_connectedChannels.TryGetValue(guild.Id, out var client))
            {
                client.Stop();

                await logger.LogAsync(LogSeverity.Info, "SendAudioAsync", $"Starting playback in {guild.Name}");

                using (var pcmStream = await FfmpegConvertToPcmProcess(audio.Stream))
                using (var outStream = client.Client.CreateOutputStream())
                using (OpusEncodeStream stream = new(outStream, PcmFormat.Short, VoiceChannels.Stereo, OpusApplication.Audio))
                {
                    try
                    {
                        byte[] buffer = new byte[81920];
                        int read;
                        audio.OnBegin();
                        while (!client.PlaybackCancellationTokenSource.IsCancellationRequested && (read = await pcmStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                        {
                            await stream.WriteAsync(buffer, 0, read, client.PlaybackCancellationTokenSource.Token);
                        }
                        if (client.PlaybackCancellationTokenSource.IsCancellationRequested)
                        {
                            audio.OnCancel();
                        }

                        audio.OnFinished();
                        await logger.LogAsync(LogSeverity.Info, "SendAudioAsync", "Finished copying incoming stream to audio client stream");
                    }
                    finally
                    {
                        await stream.FlushAsync();
                    }
                }
            }
        }

        private async Task<Stream> FfmpegConvertToPcmProcess(Stream stream)
        {
            MemoryStream stdOutBuffer = new();
            StringBuilder sb = new StringBuilder();

            var result = await Cli
                .Wrap("ffmpeg")
                .WithArguments("-hide_banner -loglevel panic -i pipe:0 -ac 2 -f s16le -ar 48000 pipe:1")
                .WithStandardInputPipe(PipeSource.FromStream(stream))
                .WithStandardOutputPipe(PipeTarget.ToStream(stdOutBuffer))
                .WithStandardErrorPipe(PipeTarget.ToStringBuilder(sb))
                .ExecuteAsync();

            if (sb.Length > 0)
            {
                await logger.LogAsync(LogSeverity.Error, "FfmpegConvertToPcmProcess", sb.ToString());
            }

            stdOutBuffer.Seek(0, SeekOrigin.Begin);
            return stdOutBuffer;
        }
    }
}