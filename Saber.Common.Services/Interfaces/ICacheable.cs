using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saber.Common.Services.Interfaces
{
    public interface ICacheable
    {
        public string FileName { get; set; }
        public CachingStatus CachingStatus { get; set; }
        public Task? CachingTask { get; set; }
        public FileInfo CachedFile { get; set; }
    }

    public enum CachingStatus
    {
        NotCached,
        Caching,
        Cached
    }
}
