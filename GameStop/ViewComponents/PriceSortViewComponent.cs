using GameStop.DAL;
using GameStop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.ViewComponents
{
    public class PriceSortViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public PriceSortViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(IEnumerable<Product> products)
        {
            return View(await Task.FromResult(products));
        }
    }
}
