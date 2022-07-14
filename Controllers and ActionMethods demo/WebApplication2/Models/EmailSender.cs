using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class EmailSender : IEmailSender
    {
        public string htmlMessage()
        {
            return "Html message";
        }

        public string txtMessage()
        {
            return "txt message";
        }
    }
}
