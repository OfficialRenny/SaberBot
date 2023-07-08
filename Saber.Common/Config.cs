using System.Configuration;

namespace Saber.Common
{
    public static class Config
    {
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