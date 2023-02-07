using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Accessibility()
        {
            return View();
        }

        public IActionResult Affiliates()
        {
            return View();
        }
    }
}
