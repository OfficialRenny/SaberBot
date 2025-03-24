using System.ComponentModel.DataAnnotations;
using Saber.Common;

namespace Saber.Database.Models;

public class CachedFileUpload
{
    [Key] public Guid Id { get; set; }

    public ulong? RequestedBy { get; set; }
    public string OriginalUrl { get; set; }
    public string UploadedUrl { get; set; }
    public string FileName { get; set; }

    public DateTime? DateCreated { get; set; } = DateTime.Now;
    public DateTime? DateLastAccessed { get; set; } = DateTime.Now;

    public DownloadType DownloadType { get; set; }
}