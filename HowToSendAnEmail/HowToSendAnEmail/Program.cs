using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace HowToSendAnEmail
{
    public class Program
    {
        private const string EMAIL_SETTINGS_CONFGIG = "EmailSettings";
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    var configuration = hostContext.Configuration;

                    services.Configure<EmailSettings>(configuration.GetSection(EMAIL_SETTINGS_CONFGIG));
                    services.AddSingleton<IEmailService, EmailService>();
                    services.AddHostedService<Worker>();
                });
    }
}
