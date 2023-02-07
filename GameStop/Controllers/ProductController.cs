using GameStop.DAL;
using GameStop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> ProductIndex(int? id)
        {
            Product product = await _context.Products.Include(p => p.ProductImages).FirstOrDefaultAsync(p => p.IsDeleted == false && p.Id == id);

                return View();
            
        }
    }
}
