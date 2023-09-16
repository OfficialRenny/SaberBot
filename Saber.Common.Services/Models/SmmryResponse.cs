using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Saber.Common.Services.Models
{
    public class SmmryResponse
    {
        [JsonPropertyName("sm_api_message")]
        public string Message { get; set; } = string.Empty;

        [JsonPropertyName("sm_api_character_count")]
        public int CharacterCount { get; set; } = 0;

        [JsonPropertyName("sm_api_title")]
        public string Title { get; set; } = string.Empty;

        [JsonPropertyName("sm_api_content")]
        public string Content { get; set; } = string.Empty;

        [JsonPropertyName("sm_api_keyword_array")]
        public string[] Keywords { get; set; } = new string[0];

        [JsonPropertyName("sm_api_error")]
        public int ErrorCode { get; set; } = 0;
    }
}
