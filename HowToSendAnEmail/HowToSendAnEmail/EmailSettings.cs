using System;
namespace HowToSendAnEmail
{
    public class EmailSettings
    {
        public string Server { get; set; }
        public bool UseAuthentication { get; set; }
        public bool UseSSL { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Port { get; set; }
    }
}
