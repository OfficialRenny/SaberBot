namespace Saber.Common.Services.Interfaces;

public interface IAudio
{
    public Stream Stream { get; set; }

    public event EventHandler Begin;
    public event EventHandler Cancel;
    public event EventHandler Finished;

    public void OnBegin();
    public void OnCancel();
    public void OnFinished();
}