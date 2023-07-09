using Microsoft.Extensions.Configuration;
using Saber.Common.AppSettings;
using System.Configuration;
using System.Dynamic;

namespace Saber.Common
{
    public class Config
    {
        private readonly IConfiguration _config;
        public Config()
        {
            _config = JsonConfiguration.CreateConfigurationContainer();
        }

        public string this[string key]
        {
            get
            {
                return _config[key];
            }
        }

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
    }
}