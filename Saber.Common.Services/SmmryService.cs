using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Saber.Common.Services.Models;
using Newtonsoft.Json;

namespace Saber.Common.Services
{
    public class SmmryService
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

            if (uri == null)
                return null;

            var parameters = new
            {
                SM_API_KEY = _config["SmmryKey"],
                SM_URL = url,
                SM_LENGTH = length,
            };

            return await _client.GetJsonAsync<SmmryResponse>("/", parameters);

        }
    }
}
