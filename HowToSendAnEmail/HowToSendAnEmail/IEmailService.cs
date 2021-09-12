using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HowToSendAnEmail
{
    public interface IEmailService
    {
        Task Send(IEnumerable<string> emails, string subject, string body, bool isHtml = false, string filename = null, byte[] attacment = null);
    }
}
