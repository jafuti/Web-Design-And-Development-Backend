using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
  public interface IEmailService
    {
        string HtmlMsg();
        string TextMsg();
    }
}
