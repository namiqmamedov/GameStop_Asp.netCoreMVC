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
                Products = await _context.Products.Where(p => p.IsDeleted == false).ToListAsync(),
                ProductLabels = await _context.ProductLabels.Where(p => p.IsDeleted == false).ToListAsync(),
                ProductConditions = await _context.ProductConditions.Where(p => p.IsDeleted == false).ToListAsync(),
            };


            return View(productVM);
        }

        public async Task<IActionResult> Matched(int? id)
        {
            if (id == null) return NotFound();
            IEnumerable<Product> products = await _context.Products
                 .Where(p => !p.IsDeleted)
                 .ToListAsync();

            if (products == null) return NotFound();

            return ViewComponent("PriceSort", products);
        }
        public async Task<IActionResult> LowToHigh(int? id)
        {
            if (id == null) return NotFound();
            IEnumerable<Product> products = await _context.Products
                 .OrderBy(m => (m.Price + m.DiscountedPrice))
                 .ToListAsync();

            if (products == null) return NotFound();

            return ViewComponent("PriceSort", products);
        }

        public async Task<IActionResult> HighToLow(int? id)
        {
            if (id == null) return NotFound();
            IEnumerable<Product> products = await _context.Products
                .OrderByDescending(m => (m.Price + m.DiscountedPrice))
                .ToListAsync();

            if (products == null) return NotFound();

            return ViewComponent("PriceSort", products);
        }

        public async Task<IActionResult> AtoZ(int? id)
        {
            if (id == null) return NotFound();
            IEnumerable<Product> products = await _context.Products
                 .OrderBy(p => p.Title)
                 .ToListAsync();

            if (products == null) return NotFound();

            return ViewComponent("PriceSort", products);
        }

        public async Task<IActionResult> ZtoA(int? id)
        {
            if (id == null) return NotFound();
            IEnumerable<Product> products = await _context.Products
                 .OrderByDescending(p => p.Title)
                 .ToListAsync();

            if (products == null) return NotFound();

            return ViewComponent("PriceSort", products);
        }

        public async Task<IActionResult> OldToNew(int? id)
        {
            if (id == null) return NotFound();
            IEnumerable<Product> products = await _context.Products
                 .OrderBy(p => p.CreatedAt)
                 .ToListAsync();

            if (products == null) return NotFound();

            return ViewComponent("PriceSort", products);
        }

        public async Task<IActionResult> NewToOld(int? id)
        {
            if (id == null) return NotFound();
            IEnumerable<Product> products = await _context.Products
                 .OrderByDescending(p => p.CreatedAt)
                 .ToListAsync();

            if (products == null) return NotFound();

            return ViewComponent("PriceSort", products);
        }

        public async Task<IActionResult> PriceFilterOne(int? id)
        {
            if (id == null) return NotFound();
            IEnumerable<Product> products = await _context.Products
                 .Where(p=>p.Price > 0.1 && p.Price < 20)
                 .OrderBy(p=>p.Price)
                 .ToListAsync();

            if (products == null) return NotFound();

            return ViewComponent("PriceSort", products);
        }

        public async Task<IActionResult> PriceFilterTwo(int? id)
        {
            if (id == null) return NotFound();
            IEnumerable<Product> products = await _context.Products
                 .Where(p => p.Price > 10 && p.Price < 25)
                 .ToListAsync();

            if (products == null) return NotFound();

            return ViewComponent("PriceSort", products);
        }
        public async Task<IActionResult> PriceFilterThree(int? id)
        {
            if (id == null) return NotFound();
            IEnumerable<Product> products = await _context.Products
                 .Where(p => p.Price > 25 && p.Price < 50)
                 .ToListAsync();

            if (products == null) return NotFound();

            return ViewComponent("PriceSort", products);
        }

        public async Task<IActionResult> PriceFilterFour(int? id)
        {
            if (id == null) return NotFound();
            IEnumerable<Product> products = await _context.Products
                 .Where(p => p.Price > 50 && p.Price < 75)
                 .ToListAsync();

            if (products == null) return NotFound();

            return ViewComponent("PriceSort", products);
        }

        public async Task<IActionResult> PriceFilterFive(int? id)
        {
            if (id == null) return NotFound();
            IEnumerable<Product> products = await _context.Products
                 .Where(p => p.Price > 75 && p.Price < 100)
                 .ToListAsync();

            if (products == null) return NotFound();

            return ViewComponent("PriceSort", products);
        }

        public async Task<IActionResult> PriceFilterSix(int? id)
        {
            if (id == null) return NotFound();
            IEnumerable<Product> products = await _context.Products
                 .Where(p => p.Price > 100 && p.Price < 200)
                 .ToListAsync();

            if (products == null) return NotFound();

            return ViewComponent("PriceSort", products);
        }


        public async Task<IActionResult> PriceFilterSeven(int? id)
        {
            if (id == null) return NotFound();
            IEnumerable<Product> products = await _context.Products
                 .Where(p => p.Price > 200 && p.Price < 300)
                 .ToListAsync();

            if (products == null) return NotFound();

            return ViewComponent("PriceSort", products);
        }

        public async Task<IActionResult> PriceFilterEight(int? id)
        {
            if (id == null) return NotFound();
            IEnumerable<Product> products = await _context.Products
                 .Where(p => p.Price < 300)
                 .ToListAsync();

            if (products == null) return NotFound();

            return ViewComponent("PriceSort", products);
        }

        public async Task<IActionResult> PriceFilterEighttt(int? id)
        {
            if (id == null) return NotFound();
            IEnumerable<ProductCondition> products = await _context.ProductConditions
                 .Where(p=>p.Product.IsDeleted == false)
                 .ToListAsync();

            if (products == null) return NotFound();

            return ViewComponent("PriceSort", products);
        }

        public async Task<IActionResult> FilterSelect(int? id)
        {
            IQueryable<Product> products = _context.Products;

            if (id != null && id > 0)
            {

                if (id == 2)
                {
                    products = products.Where(p => p.Price < 20);
                }
                else if (id == 2)
                {
                    products = products.Where(p => p.Price < 20);
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
                Product = _context.Products.Include(p => p.ProductImages)
                .Include(p => p.ProductFeatures).
                Include(p => p.ProductSpecs).
                Include(p => p.ProductLabels).
                ThenInclude(p => p.Label)
                .Include(p => p.ProductConditions).
                ThenInclude(p => p.Condition)
                .Where(p => p.ProductLabels.Any(p => p.Count > 0))
                .FirstOrDefault(p => p.IsDeleted == false && p.Id == id),
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
