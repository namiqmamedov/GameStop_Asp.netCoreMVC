using GameStop.DAL;
using GameStop.Models;
using GameStop.ViewModels.CategoryMain;
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

        public IActionResult Index()
        {
            return View();
        }

        //public async Task<IActionResult> CategoryMain(int? id, int? subId)
        //{
        //    if (id == null) return NotFound();

        //    if (subId == null) return NotFound();

        //    IEnumerable<Category> categories = await _context.Categories
        //    .Include(c => c.SubCategories)
        //    .Where(p => p.Id == id && !p.IsDeleted)
        //    .Where(p => p.SubCategories.Select(x => x.Id).FirstOrDefault() == id && !p.IsDeleted)
        //    .ToListAsync();

        //    return View(categories);
        //}
    }
}
