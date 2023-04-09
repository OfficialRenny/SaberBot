using System.Configuration;
using System.Reflection;

namespace SaberBot.Core
{
    public static class Config
    {
        public static string DiscordToken => ConfigurationManager.AppSettings["DiscordToken"];
        public static string GoogleApiKey => ConfigurationManager.AppSettings["GoogleApiKey"];
        public static string SmmryKey => ConfigurationManager.AppSettings["SmmryKey"];

        public static string FileUploaderBaseUrl => ConfigurationManager.AppSettings["FileUploaderBaseUrl"];
        public static string FileUploaderToken => ConfigurationManager.AppSettings["FileUploaderToken"];
        
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["BotDb"].ConnectionString;
        public static int StarterCurrency => int.Parse(ConfigurationManager.AppSettings["StarterCurrency"]);

        public static ulong TestGuildId => ulong.Parse(ConfigurationManager.AppSettings["TestGuildId"]);
        public static DirectoryInfo TempDir
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