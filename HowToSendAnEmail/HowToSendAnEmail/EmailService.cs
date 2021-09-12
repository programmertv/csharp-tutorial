using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace HowToSendAnEmail
{
    public class EmailService: IEmailService
    {
        private readonly EmailSettings _emailSettings;

        public EmailService(IOptions<EmailSettings> options)
        {
            _emailSettings = options.Value;
        }

        public async Task Send(IEnumerable<string> emails,
            string subject, string body, bool isHtml = false, string filename = null, byte[] attachment = null)
        {
            using var sender = new SmtpClient(_emailSettings.Server, _emailSettings.Port);
            sender.UseDefaultCredentials = _emailSettings.UseAuthentication;
            sender.EnableSsl = _emailSettings.UseSSL;
            sender.Credentials = new NetworkCredential(_emailSettings.UserName, _emailSettings.Password);
            var message = new MailMessage();
            message.Subject = subject;
            foreach (var email in emails)
                message.To.Add(new MailAddress(email));
            message.Body = body;
            message.From = new MailAddress(_emailSettings.UserName);
            message.IsBodyHtml = isHtml;
            if(attachment != null && !string.IsNullOrEmpty(filename))
                message.Attachments.Add(new Attachment(new MemoryStream(attachment), filename));

            await sender.SendMailAsync(message);
        }
    }
}
