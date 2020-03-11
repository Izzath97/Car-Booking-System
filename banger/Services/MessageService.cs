using banger.Models;
using MailKit.Net.Smtp;
using MimeKit;
using Org.BouncyCastle.Crypto.Tls;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

namespace banger.Services
{
    public class MessageService : IMessageService
    {
        private readonly IEmailConfiguration _emailConfiguration;
        public MessageService(IEmailConfiguration emailConfiguration) {
            _emailConfiguration = emailConfiguration;

        }

        public async Task SendEmailAsync(
            string fromDisplayName,
            string fromEmailaddress,
            string toName,
            string toEmailAddress,
            string subject,
            string message,
            params Attachment[] attachments)
        {
            var email = new MimeMessage();
            email.From.Add(new MailboxAddress(fromDisplayName, fromEmailaddress));
            email.To.Add(new MailboxAddress(toName, toEmailAddress));
            email.Subject = subject;

            var body = new BodyBuilder
            {
                HtmlBody = message
            };

            foreach (var attachment in attachments)
            {

                using (var stream = await attachment.ContentToStreamAsync())
                {
                    body.Attachments.Add(attachment.FileName, stream);

                }
            }
            System.Net.Mail.MailMessage MyMailMessage = new System.Net.Mail.MailMessage();
            MyMailMessage.From = new System.Net.Mail.MailAddress(fromEmailaddress);
            MyMailMessage.To.Add(toEmailAddress);// Mail would be sent to this address
            MyMailMessage.Subject = subject;

            MyMailMessage.Body = message.ToString();
            using (System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient(_emailConfiguration.SmtpServer))
            {
                client.Port = _emailConfiguration.SmtpPort;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential(_emailConfiguration.SmtpUsername, _emailConfiguration.SmtpPassword);
                client.EnableSsl = true;
                client.Send(MyMailMessage);
                client.Dispose();
                
            }


         
      

        }


    }
}