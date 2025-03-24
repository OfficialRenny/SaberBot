using RestSharp;
using Saber.Common.Services.Models;
using Saber.Database;
using Saber.Database.Providers;

namespace Saber.Common.Services;

public class FileUploaderService
{
    private readonly CachedFileProvider _cachedFileProvider;
    private readonly RestClient _client;
    private readonly Config _config;
    private readonly HttpClient _httpClient;

    public FileUploaderService(Config config, HttpClient httpClient, Db db)
    {
        _config = config;
        _httpClient = httpClient;
        _client = new RestClient(httpClient, new RestClientOptions
        {
            BaseUrl = new Uri(_config["FileUploaderBaseUrl"])
        });

        _cachedFileProvider = new CachedFileProvider(db);
    }

    public async Task<FileUploaderResponse?> UploadFile(string path)
    {
        var fileToSend = new FileInfo(path);

        if (!fileToSend.Exists)
            throw new ArgumentException("Not a valid path.");

        if (!fileToSend.FullName.StartsWith(_config.TempDir.FullName))
            throw new ArgumentException("Unsafe file path submitted.");

        var request = new RestRequest("/upload", Method.Post);
        request.AddParameter("token", _config["FileUploaderToken"]);
        request.AddFile("upload", fileToSend.FullName, ContentType.FormUrlEncoded);

        try
        {
            var resp = await _client.ExecuteAsync<FileUploaderResponse>(request);
            return resp.Data;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            return null;
        }
    }

    public async Task<int> CleanUpFiles()
    {
        var files = _cachedFileProvider.GetFilesPendingRemoval();
        var count = 0;

        foreach (var file in files)
        {
            var deleteUrl = string.Join("/", file.UploadedUrl, "delete", _config["FileUploaderToken"]);
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