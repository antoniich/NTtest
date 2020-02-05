using Microsoft.Extensions.Configuration;

namespace NTtest.Core.Configuration
{
    internal class TestConfig
    {
        public static IConfiguration Get { get; } = new ConfigurationBuilder()
                .AddJsonFile(ConfigFileName, true, true)
                .Build();

        private const string ConfigFileName = "TestConfig.json";
    }
}