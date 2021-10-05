using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Episode012.SOLID;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Episode012
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddSingleton<IRepository, DatabaseRepository>();
                    //services.AddScoped<IRepository, DatabaseRepository>();
                    //services.AddTransient<IRepository, DatabaseRepository>();
                    services.AddHostedService<Worker>();
                });
    }
}
