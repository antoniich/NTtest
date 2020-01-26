using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace NTtest.Core.Configuration
{
    class TestConfig
    {
        public static IConfiguration Get = new ConfigurationBuilder()
                .AddJsonFile("TestConfig.json", true, true)
                .Build();
    }
}