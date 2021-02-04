using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace CopaFilmes.IntegrationTests
{
    public static class ConfigurationFactory
    {
        public static IConfiguration Create()
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            return configuration;
        }
    }
}
