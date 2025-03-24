using NetCord.Gateway.Voice;

namespace Saber.Common.Services.Models;

public class AsyncAudioClient(VoiceClient client)
{
    public VoiceClient Client { get; set; } = client;
    public CancellationTokenSource PlaybackCancellationTokenSource { get; set; } = new();

    public void Stop(bool newTokenSource = true)
    {
        PlaybackCancellationTokenSource.Cancel();
        if (newTokenSource)
            PlaybackCancellationTokenSource = new CancellationTokenSource();
    }
}