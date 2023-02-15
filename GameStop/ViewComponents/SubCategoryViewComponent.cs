using GameStop.DAL;
using GameStop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.ViewComponents
{
    public class SubCategoryViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public SubCategoryViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(IEnumerable<SubCategory> subCategories)
        {
            return View(await Task.FromResult(subCategories));
        }
    }
}
