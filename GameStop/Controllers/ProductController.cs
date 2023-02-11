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

        public IActionResult Detail(int? id)
        {

            if (id == null)
            {
                return BadRequest();
            }

            ProductDetailVM productDetailVM = new ProductDetailVM
            {
                Product = _context.Products.Include(p => p.ProductImages).Include(p => p.ProductFeatures).Include(p => p.ProductSpecs).FirstOrDefault(p => p.IsDeleted == false && p.Id == id),
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

        public async Task<IActionResult> addToCart(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            Product product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            string basket = HttpContext.Request.Cookies["basket"];


            List<BasketVM> basketVMs = null;


            if (basket != null)
            {
                basketVMs = JsonConvert.DeserializeObject<List<BasketVM>>(basket);

            }

            else
            {
                basketVMs = new List<BasketVM>();
            }

            if (basketVMs.Exists(p => p.ProductID == id))
            {
                basketVMs.Find(p => p.ProductID == id).Count++;
            }
            else
            {
                BasketVM basketVM = new BasketVM
                {
                    ProductID = product.Id,
                    Count = 1,
                    Image = product.Image,
                    Title = product.Title
                };

                basketVMs.Add(basketVM);
            }

            basket = JsonConvert.SerializeObject(basketVMs);

            HttpContext.Response.Cookies.Append("basket", basket);

            return View(basketVMs);
        }


    }
}
