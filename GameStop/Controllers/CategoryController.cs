using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index(int? id)
        {
            return View();
        }
    }
}
