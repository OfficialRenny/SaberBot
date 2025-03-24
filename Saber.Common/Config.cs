using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;
using Saber.Common.AppSettings;

namespace Saber.Common;

public class Config : IConfiguration
{
    private readonly IConfiguration _config = JsonConfiguration.CreateConfigurationContainer();

    public DirectoryInfo TempDir
    {
        get
        {
            // get a directory relative to the executable's path, creating it if doesn't exist
            var tempDir = new DirectoryInfo(Path.Combine(Environment.CurrentDirectory, "temp"));
            if (!tempDir.Exists)
                tempDir.Create();

            return tempDir;
        }
    }

    public IConfigurationSection GetSection(string key)
    {
        return _config.GetSection(key);
    }

    public IEnumerable<IConfigurationSection> GetChildren()
    {
        return _config.GetChildren();
    }

    public IChangeToken GetReloadToken()
    {
        return _config.GetReloadToken();
    }

    public string this[string key]
    {
        get => _config[key];
        set => _config[key] = key;
    }
}