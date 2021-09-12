using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace HowToSendAnEmail
{
    public class Worker : BackgroundService
    {
        private readonly IEmailService _emailService;

        public Worker(IEmailService emailService)
        {
            _emailService = emailService;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            Console.WriteLine("Sending an email...");

            /*
            await _emailService.Send(new[]
                                {
                                        "ewan@gmail.com"
                                },
                               "Sample Subject Only",
                               "Sample email body only... ");
            */
            await _emailService.Send(new[]
                                {
                                        "ewan@gmail.com"
                                },
                               "Sample HTML Subject Only",
                               "<p>Sample email <b>html body only</b>... </p>",
                               true,
                               "appsettings.json",
                               File.ReadAllBytes("appsettings.json"));

            Console.WriteLine("Email Sent!!!");
        }
    }
}
