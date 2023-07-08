using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saber.Common.AppSettings
{
    public static class JsonConfiguration
    {

        public static IConfiguration ConfigurationContainer { get; private set; }

        public static IConfiguration CreateConfigurationContainer()
        {
            var environment = string.Empty;
            try
            {
                environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
                Console.WriteLine($"Found environment variable : {environment}");
                if (string.IsNullOrWhiteSpace(environment))
                {
                    Console.WriteLine($"Setting up Production appsettings.");
                    //WE ARE IN PROD !!
                    return ConfigurationContainer = new ConfigurationBuilder()
                        .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                        .AddJsonFile($"bin/AppSettings/appSettings.json").Build();
                }

                Console.WriteLine($"Setting up {environment} appsettings.");
                return ConfigurationContainer = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile($"bin/AppSettings/appsettings-{environment}.json").Build();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}
