using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Lamar.Microsoft.DependencyInjection;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace GreenOne.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((context, builder) => {
                    var env = context.HostingEnvironment;
                    builder
                    .AddJsonFile("appsetttings.json", optional:true, reloadOnChange:true)
                    .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional:true);
                })
                .UseLamar()
                .UseStartup<Startup>()
                .UseApplicationInsights();
    }
}
