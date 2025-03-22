using System.Collections.Concurrent;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using CliWrap;
using CliWrap.Buffered;
using Discord;
using Discord.Audio;
using Discord.WebSocket;
using Saber.Common.Services.Interfaces;
using Saber.Common.Services.Models;

namespace Saber.Common.Services
{
    public class AudioService
    {
        private readonly ConcurrentDictionary<ulong, AsyncAudioClient> ConnectedChannels = new ConcurrentDictionary<ulong, AsyncAudioClient>();
        private readonly ILogger _logger;

        public AudioService(ILogger logger)
        {
            _logger = logger;
        }

        public async Task JoinAudio(IGuild guild, IVoiceChannel target)
        {
            AsyncAudioClient client;
            if (ConnectedChannels.TryGetValue(guild.Id, out client))
                return;

            if (target.Guild.Id != guild.Id)
                return;

            var audioClient = await target.ConnectAsync();

            if (ConnectedChannels.TryAdd(guild.Id, new AsyncAudioClient(audioClient)))
                await _logger.LogAsync(LogSeverity.Info, "AudioService", $"Connected to voice on {guild.Name}.");
        }

        public async Task LeaveAudio(IGuild guild)
        {
            AsyncAudioClient client;
            if (ConnectedChannels.TryRemove(guild.Id, out client))
            {
                client.Stop(false);
                await client.Client.StopAsync();
                await _logger.LogAsync(LogSeverity.Info, "AudioService", $"Disconnected from voice on {guild.Name}.");
            }
        }

        public void StopAudioAsync(IGuild guild)
        {
            AsyncAudioClient client;
            if (ConnectedChannels.TryGetValue(guild.Id, out client))
            {
                client.Stop();
            }
        }

        public async Task SendAudioAsync(IGuild guild, IMessageChannel channel, IAudio audio)
        {
            AsyncAudioClient client;
            if (ConnectedChannels.TryGetValue(guild.Id, out client))
            {
                client.Stop();

                await _logger.LogAsync(new LogMessage(LogSeverity.Info, "SendAudioAsync", $"Starting playback in {guild.Name}"));

                using (var pcmStream = await FfmpegConvertToPcmProcess(audio.Stream))
                using (var stream = client.Client.CreatePCMStream(AudioApplication.Mixed))
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
                        await _logger.LogAsync(new LogMessage(LogSeverity.Info, "SendAudioAsync", "Finished copying incoming stream to audio client stream"));
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
                Console.WriteLine(sb.ToString());
            }

            stdOutBuffer.Seek(0, SeekOrigin.Begin);
            return stdOutBuffer;
        }
    }
}