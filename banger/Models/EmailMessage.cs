using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace banger.Models
{
    public class EmailMessage
    {
        public EmailMessage()
        {
            ToAddresses = new List<EmailAddresss>();
            FromAddresses = new List<EmailAddresss>();
        }

        public string ToAddressess{get;set;}
        public List<EmailAddresss> ToAddresses { get; set; }
        public List<EmailAddresss> FromAddresses { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
    }
}
