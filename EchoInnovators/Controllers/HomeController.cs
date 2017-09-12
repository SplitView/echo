using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EchoInnovators.Models;

namespace EchoInnovators.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    
        public string Contact(EmailModel model)
        {
            return model.Name;
        }
    }
}
