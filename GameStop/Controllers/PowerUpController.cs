using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.Controllers
{
    public class PowerUpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
