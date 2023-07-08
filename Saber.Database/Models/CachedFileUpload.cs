using Saber.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saber.Database.Models
{
    public class CachedFileUpload
    {
        [Key]
        public Guid Id { get; set; }

        public ulong? RequestedBy { get; set; }
        public string OriginalUrl { get; set; }
        public string UploadedUrl { get; set; }
        public string FileName { get; set; }

        public DateTime? DateCreated { get; set; } = DateTime.Now;
        public DateTime? DateLastAccessed { get; set; } = DateTime.Now;

        public DownloadType DownloadType { get; set; }
    }
}
