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
            _context = context
        }
        public async Task<IActionResult> Index(int? id, int? subId)
        {
            IEnumerable<SubCategory> subCategories = await _context.SubCategories
            .Include(c => c.Category)
            .Include(c => c.CategoryId)
            .Include(c => c.Id)
            .ToListAsync();
            //.Include(c => c.Category)
            //.Include(et => et.EventTags).ThenInclude(et => et.Tag)
            //.Include(ts => ts.EventSpeakers).ThenInclude(t => t.Teacher)
            //.Where(e => e.IsDeleted == false)
            //.ToListAsync();

            return View();
        }
    }
}
