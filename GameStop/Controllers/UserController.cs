using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }


        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Password()
        {
            return View();
        }


    }
}
