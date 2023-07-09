using Saber.Common.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saber.Common.Services.Models
{
    public class Audio : IAudio
    {
        public Stream Stream { get; set; }

        public Audio() { }

        public Audio(Stream stream)
        {
            Stream = stream;
        }

        public event EventHandler? Begin;
        public event EventHandler? Cancel;
        public event EventHandler? Finished;

        public void OnBegin()
        {
            Begin?.Invoke(this, EventArgs.Empty);
        }

        public void OnCancel()
        {
            Cancel?.Invoke(this, EventArgs.Empty);
        }

        public void OnFinished()
        {
            Finished?.Invoke(this, EventArgs.Empty);
        }
    }
}
