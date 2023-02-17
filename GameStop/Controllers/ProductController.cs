using GameStop.DAL;
using GameStop.Models;
using GameStop.ViewModels;
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

        public async Task<IActionResult> Index(int? id, int page)
        {
            IQueryable<Product> products = _context.Products
                .Where(b => b.IsDeleted == false)
                .Where(c => c.Category.IsDeleted == false)
                .OrderBy(c => c.Id);

            return View(PageNationList<Product>.Create(products, page, 24));
        }

        public async Task<IActionResult> Matched(int? id, int page)
        {
            if (id == null) return NotFound();
            IQueryable<Product> products = _context.Products
                .Where(p => p.IsDeleted == false);

            if (products == null) return NotFound();

            return ViewComponent("PriceSort", PageNationList<Product>.Create(products, page, 24));
        }
        public async Task<IActionResult> LowToHigh(int? id, int page)
        {
            if (id == null) return NotFound();
            IQueryable<Product> products = _context.Products
                                 .Where(p => p.IsDeleted == false)

                 .OrderBy(m => (m.Price + m.DiscountedPrice));

            if (products == null) return NotFound();

            return ViewComponent("PriceSort", PageNationList<Product>.Create(products, page, 24));
        }

        public async Task<IActionResult> HighToLow(int? id, int page)
        {
            if (id == null) return NotFound();
            IQueryable<Product> products = _context.Products
                 .Where(p => p.IsDeleted == false)
                .OrderByDescending(m => (m.Price + m.DiscountedPrice));

            if (products == null) return NotFound();

            return ViewComponent("PriceSort", PageNationList<Product>.Create(products, page, 24));
        }

        public async Task<IActionResult> AtoZ(int? id, int page)
        {
            if (id == null) return NotFound();
            IQueryable<Product> products = _context.Products
                 .Where(p => p.IsDeleted == false)
                 .OrderBy(p => p.Title);

            if (products == null) return NotFound();

            return ViewComponent("PriceSort", PageNationList<Product>.Create(products, page, 24));
        }

        public async Task<IActionResult> ZtoA(int? id, int page)
        {
            if (id == null) return NotFound();
            IQueryable<Product> products = _context.Products
                 .Where(p => p.IsDeleted == false)
                 .OrderByDescending(p => p.Title);

            if (products == null) return NotFound();

            return ViewComponent("PriceSort", PageNationList<Product>.Create(products, page, 24));

        }

        public async Task<IActionResult> OldToNew(int? id, int page)
        {
            if (id == null) return NotFound();
            IQueryable<Product> products = _context.Products
                  .Where(p => p.IsDeleted == false)
                 .OrderBy(p => p.CreatedAt);

            if (products == null) return NotFound();

            return ViewComponent("PriceSort", PageNationList<Product>.Create(products, page, 24));
        }

        public async Task<IActionResult> NewToOld(int? id, int page)
        {
            if (id == null) return NotFound();
            IQueryable<Product> products = _context.Products
                  .Where(p => p.IsDeleted == false)
                 .OrderByDescending(p => p.CreatedAt);

            if (products == null) return NotFound();

            return ViewComponent("PriceSort", PageNationList<Product>.Create(products, page, 24));
        }

        public async Task<IActionResult> PriceFilterOne(int? id, int page)
        {
            if (id == null) return NotFound();
            IQueryable<Product> products = _context.Products
                 .Where(p => p.Price > 0.1 && p.Price < 10 || p.DiscountedPrice > 0.1 || p.DiscountedPrice < 10)
                 .Where(p => p.IsDeleted == false)
                 .OrderBy(m => (m.Price + m.DiscountedPrice));

            if (products == null) return NotFound();

            return ViewComponent("PriceSort", PageNationList<Product>.Create(products, page, 24));
        }

        public async Task<IActionResult> PriceFilterTwo(int? id, int page)
        {
            if (id == null) return NotFound();
            IQueryable<Product> products = _context.Products
                 .Where(p => p.Price > 10 && p.Price < 25 || p.DiscountedPrice > 10 && p.DiscountedPrice < 25)
                  .Where(p => p.IsDeleted == false)
                 .OrderBy(m => (m.Price + m.DiscountedPrice));

            if (products == null) return NotFound();

            return ViewComponent("PriceSort", PageNationList<Product>.Create(products, page, 24));

        }
        public async Task<IActionResult> PriceFilterThree(int? id, int page)
        {
            if (id == null) return NotFound();
            IQueryable<Product> products = _context.Products
                 .Where(p => p.Price > 25 && p.Price < 50 ||
                 p.DiscountedPrice > 25 &&  p.DiscountedPrice < 50)
                 .Where(p => p.IsDeleted == false)
                .OrderBy(m => (m.Price + m.DiscountedPrice));

            if (products == null) return NotFound();

            return ViewComponent("PriceSort", PageNationList<Product>.Create(products, page, 24));

        }

        public async Task<IActionResult> PriceFilterFour(int? id, int page)
        {
            if (id == null) return NotFound();
            IQueryable<Product> products = _context.Products
                 .Where(p => p.Price > 50 && p.Price < 75 ||
                 p.DiscountedPrice > 50 && p.DiscountedPrice < 75)
                  .Where(p => p.IsDeleted == false)
                  .OrderBy(m => (m.Price + m.DiscountedPrice));


            if (products == null) return NotFound();

            return ViewComponent("PriceSort", PageNationList<Product>.Create(products, page, 24));

        }

        public async Task<IActionResult> PriceFilterFive(int? id, int page)
        {
            if (id == null) return NotFound();
            IQueryable<Product> products = _context.Products
                 .Where(p => p.Price > 75 && p.Price < 100 ||
                 p.DiscountedPrice > 75 && p.DiscountedPrice < 100)
                 .Where(p => p.IsDeleted == false)
                 .OrderBy(m => (m.Price + m.DiscountedPrice));


            if (products == null) return NotFound();

            return ViewComponent("PriceSort", PageNationList<Product>.Create(products, page, 24));

        }

        public async Task<IActionResult> PriceFilterSix(int? id, int page)
        {
            if (id == null) return NotFound();
            IQueryable<Product> products = _context.Products
                 .Where(p => p.Price > 100 && p.Price < 200 ||
                 p.DiscountedPrice > 100 && p.DiscountedPrice < 200)
                 .Where(p => p.IsDeleted == false)
                 .OrderBy(m => (m.Price + m.DiscountedPrice));


            if (products == null) return NotFound();

            return ViewComponent("PriceSort", PageNationList<Product>.Create(products, page, 24));

        }


        public async Task<IActionResult> PriceFilterSeven(int? id, int page)
        {
            if (id == null) return NotFound();
            IQueryable<Product> products = _context.Products
                 .Where(p => p.Price > 200 && p.Price < 300 ||
                 p.DiscountedPrice > 200 && p.DiscountedPrice < 300)
                 .Where(p => p.IsDeleted == false)
                 .OrderBy(m => (m.Price + m.DiscountedPrice));
            if (products == null) return NotFound();

            return ViewComponent("PriceSort", PageNationList<Product>.Create(products, page, 24));

        }

        public async Task<IActionResult> PriceFilterEighttt(int? id)
        {
            if (id == null) return NotFound();
            IEnumerable<ProductCondition> products = await _context.ProductConditions
                 .Where(p => p.Product.IsDeleted == false)
                 .Where(p => p.IsDeleted == false)
                 .OrderBy(p => p.Product)
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
                .Include(p => p.ProductFeatures)
                .Include(p => p.ProductDescriptions)
                .Include(p => p.ProductSpecs).
                Include(p => p.ProductLabels).
                ThenInclude(p => p.Label)
                .Include(p => p.ProductConditions).
                ThenInclude(p => p.Condition)
                .Where(p => p.ProductLabels.Any(p => p.Count > 0))
                .Where(p => p.ProductConditions.Any(p => p.Count > 0))
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
