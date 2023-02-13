using GameStop.DAL;
using GameStop.Models;
using GameStop.ViewModels.Basket;
using GameStop.ViewModels.Products;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
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

        public async Task<IActionResult> FilterSelect(int? id)
        {
            IQueryable<Product> products = _context.Products;

            if (id != null && id > 0)
            {
                
                if (id == 2)
                {
                    products = products.Where(p=>p.Price < 20);
                }
                else if (id == 2)
                {
                      products = products.Where(p=>p.Price < 20);
                }
                else if (id == 3)
                {
                    products = products.Where(p => p.Price < 20);
                }
            }

            ViewBag.Status = id;

            return PartialView("_BasketPartial", await products.ToListAsync());
        }

        public IActionResult Detail(int? id)
        {

            if (id == null)
            {
                return BadRequest();
            }

            ProductDetailVM productDetailVM = new ProductDetailVM
            {
                Product = _context.Products.Include(p => p.ProductImages).Include(p => p.ProductFeatures).Include(p => p.ProductSpecs).Include(p=>p.ProductLabels).ThenInclude(p=>p.Label).FirstOrDefault(p => p.IsDeleted == false && p.Id == id),
            };



            if (productDetailVM == null)
            {
                return NotFound();

            }


            return View(productDetailVM);
        }

        public async Task<IActionResult> Search(string search)
        {
            List<Product> products = await _context.Products.Where(p => p.Title.ToLower()
            .Contains(search.ToLower()) || p.SubCategory.Name.ToLower()
            .Contains(search.ToLower())).ToListAsync();

            return PartialView("_ProductSearchPartial", products);
        }

    }
}
