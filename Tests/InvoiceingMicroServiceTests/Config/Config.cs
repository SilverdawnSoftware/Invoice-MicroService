using System.IO;
using Microsoft.Extensions.Configuration;

namespace InvoiceingMicroServiceTests.Config    
{
    

    public class Config
    {
        public static EmailSettings EmailSettings;

        static Config()
        {
            EmailSettings = GetTestSettings();
        }

        public static IConfigurationRoot GetIConfigurationRoot(string outputPath)
        {
            return new ConfigurationBuilder()
                .SetBasePath(outputPath)
                .AddJsonFile("appsettings.json", optional: true)
                .AddUserSecrets<Config>()
                .AddEnvironmentVariables()
                .Build();
        }

        public static EmailSettings GetTestSettings()
        {
            var configuration = new EmailSettings();

            var iConfig = GetIConfigurationRoot(Directory.GetCurrentDirectory());

            iConfig
                .GetSection("TestSettings")
                .Bind(configuration);

            return configuration;
        }
    }

}
