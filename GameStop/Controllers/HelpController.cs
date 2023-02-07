using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.Controllers
{
    public class HelpController : Controller
    {
        public IActionResult Faq()
        {
            return View();
        }

        public IActionResult Return()
        {
            return View();
        }

        public IActionResult Support()
        {
            return View();
        }
    }
}
