using GameStop.DAL;
using GameStop.Models;
using GameStop.ViewModels.Basket;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly AppDbContext _context;
        public ShoppingCartController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }




      
    }
}
