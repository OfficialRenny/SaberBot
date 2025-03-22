using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Saber.Common.Services.Models;
using Newtonsoft.Json;
using Saber.Common.Services.Interfaces;

namespace Saber.Common.Services
{
    public class SmmryService : ISummaryService
    {
        private readonly Config _config;
        private readonly RestClient _client;

        public SmmryService(Config config, HttpClient httpClient)
        {
            _config = config;
            _client = new RestClient(httpClient, options: new RestClientOptions
            {
                BaseUrl = new Uri("https://api.smmry.com"),
            });
        }

        public async Task<SmmryResponse?> GetSmmry(string url, int? length = null)
        {
            Uri? uri = new(url);
            
            var parameters = new
            {
                SM_API_KEY = _config["SmmryKey"],
                SM_URL = url,
                SM_LENGTH = length,
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

        public async Task<string> Summarize(string url, int? length = null)
            => (await GetSmmry(url, length))?.Content ?? "Failed to summarize the link.";
    }
}
