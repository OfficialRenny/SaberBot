﻿using Saber.Common;
using Saber.Database.Models;

namespace Saber.Database.Providers;

public class CachedFileProvider : GenericProvider<CachedFileUpload>
{
    public CachedFileProvider(Db db) : base(db)
    {
    }

    public CachedFileUpload? GetCachedFile(string url, DownloadType type = DownloadType.Video)
    {
        var file = DbCtx.CachedFileUploads.FirstOrDefault(x => x.OriginalUrl == url && x.DownloadType == type);
        if (file == null)
            return null;

        file.DateLastAccessed = DateTime.Now;
        DbCtx.SaveChanges();

        return file;
    }

    public IEnumerable<CachedFileUpload> GetFilesPendingRemoval()
    {
        return DbCtx.CachedFileUploads.Where(x => x.DateLastAccessed < DateTime.Now.AddDays(-7));
    }

    public CachedFileUpload AddUrlToCache(string originalUrl, string uploadedUrl, string fileName,
        DownloadType type = DownloadType.Video, ulong? requestedBy = null)
    {
        var cachedFile = new CachedFileUpload
        {
            OriginalUrl = originalUrl,
            UploadedUrl = uploadedUrl,
            FileName = fileName,
            RequestedBy = requestedBy,
            DownloadType = type,
            DateCreated = DateTime.Now
        };

        DbCtx.CachedFileUploads.Add(cachedFile);
        DbCtx.SaveChanges();
        return cachedFile;
    }
}