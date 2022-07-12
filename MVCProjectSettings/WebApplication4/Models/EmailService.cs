using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class EmailService : IEmailService
    {
        public string HtmlMsg()
        {
            return "Html msg";
        }

        public string TextMsg()
        {
            return "TextMesg";
        }
    }
}
