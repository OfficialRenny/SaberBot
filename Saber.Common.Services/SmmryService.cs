using RestSharp;
using Saber.Common.Services.Interfaces;
using Saber.Common.Services.Models;

namespace Saber.Common.Services;

public class SmmryService : ISummaryService
{
    private readonly RestClient _client;
    private readonly Config _config;

    public SmmryService(Config config, HttpClient httpClient)
    {
        _config = config;
        _client = new RestClient(httpClient, new RestClientOptions
        {
            BaseUrl = new Uri("https://api.smmry.com")
        });
    }

    public async Task<string> Summarize(string url, int? length = null)
    {
        return (await GetSmmry(url, length))?.Content ?? "Failed to summarize the link.";
    }

    public async Task<SmmryResponse?> GetSmmry(string url, int? length = null)
    {
        Uri? uri = new(url);

        var parameters = new
        {
            SM_API_KEY = _config["SmmryKey"],
            SM_URL = url,
            SM_LENGTH = length
        };

        try
        {
            return await _client.GetJsonAsync<SmmryResponse>("/", parameters);
        }
        catch (Exception e)
        {
            return null;
        }
    }
}