using RestSharp;
using SaberBot.Core.Services.Models;
using SaberBot.Database;
using SaberBot.Database.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaberBot.Core.Services
{
    public class FileUploaderService
    {
        private readonly HttpClient _httpClient;
        private readonly RestClient _client;
        private readonly CachedFileProvider _cachedFileProvider;

        public FileUploaderService(HttpClient httpClient, Db db)
        {
            _httpClient = httpClient;
            _client = new RestClient(httpClient, options: new RestClientOptions
            {
                BaseUrl = new Uri(Config.FileUploaderBaseUrl),
            });

            _cachedFileProvider = new CachedFileProvider(db);
        }

        public async Task<FileUploaderResponse?> UploadFile(string path)
        {
            var fileToSend = new FileInfo(path);

            if (!fileToSend.Exists)
                throw new ArgumentException("Not a valid path.");

            if (!fileToSend.FullName.Contains(Config.TempDir.FullName))
                throw new ArgumentException("Unsafe file path submitted.");

            var request = new RestRequest("/upload", Method.Post);
            request.AddParameter("token", Config.FileUploaderToken);
            request.AddFile("upload", fileToSend.FullName, ContentType.FormUrlEncoded);

            try
            {
                var resp = await _client.ExecuteAsync<FileUploaderResponse>(request);
                return resp.Data;
            } catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public async Task<int> CleanUpFiles()
        {
            var files = _cachedFileProvider.GetFilesPendingRemoval();
            int count = 0;

            foreach (var file in files)
            {
                var deleteUrl = string.Join("/", file.UploadedUrl, "delete", Config.FileUploaderToken);
                var request = await _httpClient.GetAsync(deleteUrl);
                if (request.IsSuccessStatusCode)
                {
                    count++;
                    _cachedFileProvider.Remove(file);
                }
            }

            _cachedFileProvider.Save();
            return count;
        }
    }
}
