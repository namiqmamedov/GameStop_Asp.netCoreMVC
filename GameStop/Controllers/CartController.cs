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


        public async Task<IActionResult> Index(int? id)
        {
            string basket = HttpContext.Request.Cookies["basket"];
            
            List<BasketVM> basketVms = null;

            if (!string.IsNullOrWhiteSpace(basket))
            {
                basketVms = JsonConvert.DeserializeObject<List<BasketVM>>(basket);  
            }
            else
            {
                basketVms = new List<BasketVM>();
            }

            return View(await _getBasketItemAsync(basketVms));
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

        public async Task<IActionResult> UpdateCount(int? id, int count)
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

            List<BasketVM> basketVms = null;

            if (!string.IsNullOrWhiteSpace(basket))
            {
                basketVms = JsonConvert.DeserializeObject<List<BasketVM>>(basket);

                BasketVM basketVM = basketVms.FirstOrDefault(p => p.ProductID == id);

                if (basketVM == null)
                {
                    return NotFound();  
                }

                basketVM.Count = count <= 0 ? 1 : count;

                basket = JsonConvert.SerializeObject(basketVms);

                HttpContext.Response.Cookies.Append("basket", basket);
            }
            else
            {
                return BadRequest();
            }

            return PartialView("_BasketIndexPartial",await _getBasketItemAsync(basketVms));
        }

        private async Task<List<BasketVM>> _getBasketItemAsync(List<BasketVM> basketVMs)
        {
            foreach (BasketVM item in basketVMs)
            {
                Product dbProduct = await _context.Products.FirstOrDefaultAsync(p => p.Id == item.ProductID);

                item.Image = dbProduct.Image;
                item.Title = dbProduct.Title;
                item.Price = dbProduct.DiscountedPrice > 0 ? dbProduct.DiscountedPrice : dbProduct.Price;
                item.OldPrice = dbProduct.OldPrice;
            }

            return basketVMs;
        }


        public IActionResult Checkout(int? id)
        {
            return View();
        }
    }
}
