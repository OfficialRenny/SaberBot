using Microsoft.Extensions.Configuration;

namespace Saber.Common.AppSettings;

public static class JsonConfiguration
{
    public static IConfiguration ConfigurationContainer { get; private set; }

    public static IConfiguration CreateConfigurationContainer()
    {
        var environment = string.Empty;
        try
        {
            environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            return ConfigurationContainer = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("AppSettings/appSettings.json").Build();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            throw;
        }
    }
}