using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmailService _emailsender;
        public HomeController(IEmailService email)
        {
            _emailsender = email;
        }
        public string Index()
        {
            return _emailsender.HtmlMsg();
        }
        public string Index1()
        {
            return _emailsender.HtmlMsg();
        }
    }
}
