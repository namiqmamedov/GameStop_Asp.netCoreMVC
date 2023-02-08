using GameStop.DAL;
using GameStop.Models;
using GameStop.ViewModels.Products;
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

        public async Task<IActionResult> Index(int? id)
        {
            ProductVM productVM = new ProductVM
            {
                Products = await _context.Products.Where(p => p.IsDeleted == false).ToListAsync()
            };
           return View(productVM);
            
        }

        public IActionResult Detail(int? id)
        {
            ProductDetailVM productDetailVM  = new ProductDetailVM
            {
                Product = _context.Products.Include(p=>p.ProductImages).FirstOrDefault(p => p.IsDeleted == false && p.Id == id),
            };


            return View(productDetailVM);
        }


    }
}
