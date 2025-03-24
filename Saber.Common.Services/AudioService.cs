using System.Collections.Concurrent;
using System.Text;
using CliWrap;
using NetCord;
using NetCord.Gateway;
using NetCord.Gateway.Voice;
using Saber.Common.Services.Interfaces;
using Saber.Common.Services.Models;

namespace Saber.Common.Services;

public class AudioService(ILogger logger, GatewayClient client)
{
    private readonly ConcurrentDictionary<ulong, AsyncAudioClient> _connectedChannels = new();

    public async Task JoinAudio(Guild guild, IVoiceGuildChannel target)
    {
        if (_connectedChannels.TryGetValue(guild.Id, out _))
            return;

        if (target.GuildId != guild.Id)
            return;

        var voiceClient = await client.JoinVoiceChannelAsync(guild.Id, target.Id);
        await voiceClient.StartAsync();
        await voiceClient.EnterSpeakingStateAsync(SpeakingFlags.Microphone);

        if (_connectedChannels.TryAdd(guild.Id, new AsyncAudioClient(voiceClient)))
            await logger.LogAsync(LogSeverity.Info, "AudioService", $"Connected to voice on {guild.Name}.");
    }

    public async Task LeaveAudio(Guild guild)
    {
        if (_connectedChannels.TryRemove(guild.Id, out var audioClient))
        {
            audioClient.Stop(false);
            await client.UpdateVoiceStateAsync(new VoiceStateProperties(guild.Id, null));
            await audioClient.Client.CloseAsync();

            await logger.LogAsync(LogSeverity.Info, "AudioService", $"Disconnected from voice on {guild.Name}.");
        }
    }

    public async Task StopAudio(Guild guild)
    {
        if (_connectedChannels.TryGetValue(guild.Id, out var audioClient))
        {
            audioClient.Stop();
            await logger.LogAsync(LogSeverity.Info, "AudioService", $"Stopped playback in {guild.Name}");
        }
    }

    public async Task SendAudioAsync(Guild guild, TextChannel channel, IAudio audio)
    {
        if (_connectedChannels.TryGetValue(guild.Id, out var audioClient))
        {
            audioClient.Stop();

            await logger.LogAsync(LogSeverity.Info, "SendAudioAsync", $"Starting playback in {guild.Name}");

            await using var pcmStream = await FfmpegConvertToPcmProcess(audio.Stream);
            await using var outStream = audioClient.Client.CreateOutputStream();
            await using OpusEncodeStream stream = new(outStream, PcmFormat.Short, VoiceChannels.Stereo,
                OpusApplication.Audio);

            try
            {
                var buffer = new byte[81920];
                int read;
                audio.OnBegin();
                while (!audioClient.PlaybackCancellationTokenSource.IsCancellationRequested &&
                       (read = await pcmStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                    await stream.WriteAsync(buffer, 0, read, audioClient.PlaybackCancellationTokenSource.Token);
                if (audioClient.PlaybackCancellationTokenSource.IsCancellationRequested) audio.OnCancel();

                audio.OnFinished();
                await logger.LogAsync(LogSeverity.Info, "SendAudioAsync",
                    "Finished copying incoming stream to audio client stream");
            }
            finally
            {
                await stream.FlushAsync();
            }
        }
    }

    private async Task<Stream> FfmpegConvertToPcmProcess(Stream stream)
    {
        MemoryStream stdOutBuffer = new();
        var sb = new StringBuilder();

        var result = await Cli
            .Wrap("ffmpeg")
            .WithArguments("-hide_banner -loglevel panic -i pipe:0 -ac 2 -f s16le -ar 48000 pipe:1")
            .WithStandardInputPipe(PipeSource.FromStream(stream))
            .WithStandardOutputPipe(PipeTarget.ToStream(stdOutBuffer))
            .WithStandardErrorPipe(PipeTarget.ToStringBuilder(sb))
            .ExecuteAsync();

        if (sb.Length > 0) await logger.LogAsync(LogSeverity.Error, "FfmpegConvertToPcmProcess", sb.ToString());

        stdOutBuffer.Seek(0, SeekOrigin.Begin);
        return stdOutBuffer;
    }
}