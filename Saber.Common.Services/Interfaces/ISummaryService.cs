namespace Saber.Common.Services.Interfaces;

public interface ISummaryService
{
    public Task<string> Summarize(string url, int? length = null);
}