using Discord.Audio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saber.Bot.Core.Models
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
    }
}
