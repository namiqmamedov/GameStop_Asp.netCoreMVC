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
    public class CartController : Controller
    {

        private readonly AppDbContext _context;
        public CartController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
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
                };

                basketVMs.Add(basketVM);
            }

            basket = JsonConvert.SerializeObject(basketVMs);

            HttpContext.Response.Cookies.Append("basket", basket);

            return PartialView("_BasketPartial", await _getBasketItemAsync(basketVMs));

        }

        public async Task<IActionResult> RemoveCart(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            if (!await _context.Products.AnyAsync(p => p.Id == id))
            {
                return NotFound();
            }

            string basket = HttpContext.Request.Cookies["basket"];

            if (string.IsNullOrWhiteSpace(basket))
            {
                return BadRequest();
            }

            List<BasketVM> basketVMs = JsonConvert.DeserializeObject<List<BasketVM>>(basket);

            BasketVM basketVM = basketVMs.Find(p => p.ProductID == id);

            if (basketVM == null)
            {
                return NotFound();
            }
            basketVMs.Remove(basketVM);

            basket = JsonConvert.SerializeObject(basketVMs);

            HttpContext.Response.Cookies.Append("basket", basket);

            return PartialView("_BasketPartial", await _getBasketItemAsync(basketVMs));

        }

        private async Task<List<BasketVM>> _getBasketItemAsync(List<BasketVM> basketVMs)
        {
            foreach (BasketVM item in basketVMs)
            {
                Product dbProduct = await _context.Products.FirstOrDefaultAsync(p => p.Id == item.ProductID);

                item.Image = dbProduct.Image;
                item.Title = dbProduct.Title;
            }

            return basketVMs;
        }


        public IActionResult Checkout(int? id)
        {
            return View();
        }
    }
}
