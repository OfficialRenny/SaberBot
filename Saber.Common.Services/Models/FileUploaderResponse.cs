using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Saber.Common.Services.Models
{
    public class FileUploaderResponse
    {
        [JsonPropertyName("message")]
        public string Message { get; set; } = "";
        [JsonPropertyName("version")]
        public string Version { get; set; } = "";
        [JsonPropertyName("url")]
        public string Url { get; set; } = "";
    }
}
