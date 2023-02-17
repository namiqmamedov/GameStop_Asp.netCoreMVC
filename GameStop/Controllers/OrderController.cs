using GameStop.DAL;
using GameStop.Models;
using GameStop.ViewModels;
using GameStop.ViewModels.Basket;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.Controllers
{
    //[Authorize(Roles ="Member")]
    public class OrderController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly AppDbContext _context;
        public OrderController(AppDbContext context,UserManager<AppUser> userManager)
        {
            _userManager = userManager;
            _context = context;
        }

        public async Task<IActionResult> Index()
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

            AppUser appUser = await _userManager.FindByNameAsync(User.Identity.Name);

            //List<Cart> carts = await _context.Carts.Include(c=>c.Product) .Where(c=>c.AppUserId == appUser.Id).ToLisyAsync();

            Order order = new Order
            {
                Name = appUser.Name,
                Surname = appUser.Surname,
                Email = appUser.Email,
            };

            OrderVM orderVM = new OrderVM
            {
                Order = order,
                BasketVMs = basketVms,
                //Carts = carts,
            };


            return View(orderVM);
        }


        private async Task<List<BasketVM>> _getBasketItemAsync(List<BasketVM> basketVMs)
        {
            foreach (BasketVM item in basketVMs)
            {
                Product dbProduct = await _context.Products.FirstOrDefaultAsync(p => p.Id == item.ProductID);
                Label dbLabel = await _context.Labels.FirstOrDefaultAsync(c => c.Id == item.LabelId);
                Condition dbCondition = await _context.Conditions.FirstOrDefaultAsync(c => c.Id == item.ConditionId);

                item.Image = dbProduct.Image;
                item.Title = dbProduct.Title;
                item.Price = dbProduct.Price/* > 0 ? dbProduct.DiscountedPrice : dbProduct.Price*/;
                item.DiscountedPrice = dbProduct.DiscountedPrice;
                item.OldPrice = dbProduct.OldPrice;
                item.Label = dbLabel.Name;
                item.Condition = dbCondition.Name;
            }

            return basketVMs;
        }
    }
}
