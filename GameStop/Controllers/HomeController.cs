using GameStop.ComponentViewModels.Header;
using GameStop.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? id)
        {
            HeaderVM headerVM = new HeaderVM
            {
                Categories = await _context.Categories.Where(c => c.IsDeleted == false).ToListAsync(),
                SubCategories = await _context.SubCategories.Where(sc => sc.IsDeleted == false).ToListAsync(),
            };
            
            return View(headerVM);
        }
    }
}
