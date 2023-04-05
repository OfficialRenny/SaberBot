using System.Configuration;
using System.Reflection;

namespace SaberBot.Core
{
    public static class Config
    {
        public static string DiscordToken => ConfigurationManager.AppSettings["DiscordToken"];
        public static string GoogleApiKey => ConfigurationManager.AppSettings["GoogleApiKey"];
        public static string SmmryKey => ConfigurationManager.AppSettings["SmmryKey"];
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["BotDb"].ConnectionString;
        public static int StarterCurrency => int.Parse(ConfigurationManager.AppSettings["StarterCurrency"]);

        public static string CurPath => Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        public static ulong TestGuildId => ulong.Parse(ConfigurationManager.AppSettings["TestGuildId"]);
        public static DirectoryInfo TempDir
        {
            get
            {
                // get a directory relative to the executable's path, creating it if doesn't exist
                var tempDir = new DirectoryInfo(Path.Combine(CurPath, "temp"));
                if (!tempDir.Exists)
                    tempDir.Create();
                
                return tempDir;
            }
        }
    }
}