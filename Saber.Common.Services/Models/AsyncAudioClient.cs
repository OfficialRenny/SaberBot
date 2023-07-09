using Discord.Audio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saber.Common.Services.Models
{
    public class AsyncAudioClient
    {
        public IAudioClient Client { get; set; }
        public CancellationTokenSource PlaybackCancellationTokenSource { get; set; }

        public AsyncAudioClient(IAudioClient client)
        {
            Client = client;
            PlaybackCancellationTokenSource = new CancellationTokenSource();
        }

        public void Stop(bool newTokenSource = true)
        {
            PlaybackCancellationTokenSource.Cancel();
            if (newTokenSource)
                PlaybackCancellationTokenSource = new CancellationTokenSource();
        }
    }
}
