﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Autofac.Extensions.DependencyInjection;

namespace NorthWind.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", optional: true)
               // .AddEnvironmentVariables(prefix: "ASPNETCORE_")
               .AddCommandLine(args)
               .Build();

            BuildWebHost(args, config).Run();

        }

        public static IWebHost BuildWebHost(string[] args, IConfigurationRoot config) =>
           WebHost.CreateDefaultBuilder(args)
                .ConfigureServices(services => services.AddAutofac())
               .UseStartup<Startup>()
               .UseUrls(config["host.urls"])
               .Build();
    }
}
