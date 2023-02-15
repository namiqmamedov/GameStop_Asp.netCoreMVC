using GameStop.DAL;
using GameStop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> CategoryMain(int? id, int? subId)
        {
            IEnumerable<SubCategory> subCategories = await _context.SubCategories
            .Include(c => c.Category)
            .Include(c => c.CategoryId)
            .Include(c => c.Id)
            .Where(c => c.CategoryId == subId && !c.IsDeleted)
            .Where(c => c.Category.Id == id && !c.IsDeleted)
            .Where(c => c.CategoryId == id && !c.IsDeleted)
            .ToListAsync();

            return ViewComponent("SubCategory",subCategories);
        }
    }
}
