using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.Controllers
{
    public class PrivacyController : Controller
    {
        public IActionResult Transparency()
        {
            return View();
        }

        public IActionResult Condition()
        {
            return View();
        }


        public IActionResult PrivacyPolicy()
        {
            return View();
        }


        public IActionResult TermsCondition()
        {
            return View();
        }
    }
}
