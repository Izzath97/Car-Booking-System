using banger.Models;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

namespace banger.Services
{
    public interface IMessageService
    {
        Task SendEmailAsync(
        string fromDisplayName,
        string fromEmailaddress,
        string toName,
        string toEmailAddress,
        string subject,
        string message,
        params Attachment[] attachments
            );

    }
}
