using NetCord;
using Saber.Common.Services.Interfaces;

namespace Saber.Common.Services.Models.MusicPlayer;

public class Track : IAudio, ICacheable
{
    public Track(string name, string url, TimeSpan length, User requestedBy)
    {
        Name = name;
        Url = url;
        Length = length;
        RequestedBy = requestedBy;
    }

    public string Name { get; set; } = "";
    public string Url { get; set; } = "";

    public TimeSpan Length { get; set; } = TimeSpan.Zero;
    public TimeSpan Position { get; set; } = TimeSpan.Zero;

    public User RequestedBy { get; set; } = null!;

    public bool Loop { get; set; } = false;

    public Stream Stream
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public event EventHandler Begin;
    public event EventHandler Cancel;
    public event EventHandler Finished;

    public void OnBegin()
    {
        throw new NotImplementedException();
    }

    public void OnCancel()
    {
        throw new NotImplementedException();
    }

    public void OnFinished()
    {
        throw new NotImplementedException();
    }

    public string FileName
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public CachingStatus CachingStatus
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public Task? CachingTask
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public FileInfo CachedFile
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }
}