using GameStop.DAL;
using GameStop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.Areas.Admin.Controllers
{
    [Area("admin")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int page)
        {
            IEnumerable<Category> categories = await _context.Categories
               .ToListAsync();

            int totalPages = (int)Math.Ceiling((decimal)categories.Count() / 5);

            if (page < 1 || page > totalPages)
            {
                page = 1;
            }

            ViewBag.TotalPages = totalPages;
            ViewBag.PageIndex = page;

            categories = categories
           .Skip((page - 1) * 5)
           .Take(5);

            return View(categories);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (await _context.Categories.AnyAsync(p => p.Name.ToLower().Trim() == category.Name.ToLower().Trim() && !p.IsDeleted))
            {
                ModelState.AddModelError("Title", $"{category.Name} is already exists");

                return View();
            }

            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }


        [HttpGet]

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            Category category = await _context.Categories.FirstOrDefaultAsync(p => p.Id == id);

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Category category)
        {
            if (id == null)
            {
                return BadRequest();
            }

            if (id != category.Id)
            {
                return BadRequest();
            }

            if (await _context.Categories.AnyAsync(p => p.Id != category.Id && !p.IsDeleted && p.Name.ToLower().Trim() == category.Name.ToLower().Trim() && !p.IsDeleted))
            {
                ModelState.AddModelError("Name", $"{category.Name} is already exists");

                return View();
            }

            Category dbCategory = await _context.Categories.FirstOrDefaultAsync(p => p.Id == id);

            if (dbCategory == null)
            {
                return NotFound();
            }

            dbCategory.Name = category.Name;
            dbCategory.CreatedAt = DateTime.Now;
            dbCategory.UpdatedAt = DateTime.Now;

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            Category category = await _context.Categories.FirstOrDefaultAsync(p => p.Id == id);

            if (category == null)
            {
                return NotFound();
            }

            category.IsDeleted = true;
            category.DeletedAt = DateTime.Now;

            await _context.SaveChangesAsync();

            return PartialView("_CategoryIndexPartial", await _context.Categories
                .ToListAsync());

        }

        public async Task<IActionResult> Restore(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            Category category = await _context.Categories.FirstOrDefaultAsync(p => p.Id == id);

            if (category == null)
            {
                return NotFound();
            }

            category.IsDeleted = false;
            category.DeletedAt = null;

            await _context.SaveChangesAsync();

            return PartialView("_CategoryIndexPartial", await _context.Categories
                .ToListAsync());

        }

        // FILTER OPTIONS 

        public async Task<IActionResult> Matched(int? id, int page)
        {
            if (id == null) return NotFound();
            IEnumerable<Category> categories = await _context.Categories
                 .ToListAsync();

            int totalPages = (int)Math.Ceiling((decimal)categories.Count() / 5);

            if (page < 1 || page > totalPages)
            {
                page = 1;
            }

            ViewBag.TotalPages = totalPages;
            ViewBag.PageIndex = page;

            categories = categories
           .Skip((page - 1) * 5)
           .Take(5);


            if (categories == null) return NotFound();

            return PartialView("_CategoryIndexPartial", categories);
        }
        public async Task<IActionResult> Active(int? id, int page)
        {
            if (id == null) return NotFound();
            IEnumerable<Category> categories = await _context.Categories
                 .Where(p => !p.IsDeleted)
                 .ToListAsync();

            int totalPages = (int)Math.Ceiling((decimal)categories.Count() / 5);

            if (page < 1 || page > totalPages)
            {
                page = 1;
            }

            ViewBag.TotalPages = totalPages;
            ViewBag.PageIndex = page;

            categories = categories
           .Skip((page - 1) * 5)
           .Take(5);

            if (categories == null) return NotFound();

            return PartialView("_CategoryIndexPartial", categories);
        }

        public async Task<IActionResult> InActive(int? id, int page)
        {
            if (id == null) return NotFound();
            IEnumerable<Category> categories = await _context.Categories
                 .Where(p => p.IsDeleted)
                 .ToListAsync();

            int totalPages = (int)Math.Ceiling((decimal)categories.Count() / 5);

            if (page < 1 || page > totalPages)
            {
                page = 1;
            }

            ViewBag.TotalPages = totalPages;
            ViewBag.PageIndex = page;

            categories = categories
           .Skip((page - 1) * 5)
           .Take(5);

            if (categories == null) return NotFound();

            return PartialView("_CategoryIndexPartial", categories);
        }


        public async Task<IActionResult> OldToNew(int? id, int page)
        {
            if (id == null) return NotFound();
            IEnumerable<Category> categories = await _context.Categories
                   .OrderBy(p => p.CreatedAt)
                 .ToListAsync();

            int totalPages = (int)Math.Ceiling((decimal)categories.Count() / 5);

            if (page < 1 || page > totalPages)
            {
                page = 1;
            }

            ViewBag.TotalPages = totalPages;
            ViewBag.PageIndex = page;

            categories = categories
           .Skip((page - 1) * 5)
           .Take(5);

            if (categories == null) return NotFound();

            return PartialView("_CategoryIndexPartial", categories);
        }

        public async Task<IActionResult> NewToOld(int? id, int page)
        {
            if (id == null) return NotFound();
            IEnumerable<Category> categories = await _context.Categories
                   .OrderByDescending(p => p.CreatedAt)
                 .ToListAsync();

            int totalPages = (int)Math.Ceiling((decimal)categories.Count() / 5);

            if (page < 1 || page > totalPages)
            {
                page = 1;
            }

            ViewBag.TotalPages = totalPages;
            ViewBag.PageIndex = page;

            categories = categories
           .Skip((page - 1) * 5)
           .Take(5);

            if (categories == null) return NotFound();

            return PartialView("_CategoryIndexPartial", categories);
        }


        public async Task<IActionResult> AtoZ(int? id,int page)
        {
            if (id == null) return NotFound();
            IEnumerable<Category> categories = await _context.Categories
           .OrderBy(p => p.Name)
           .ToListAsync();

            int totalPages = (int)Math.Ceiling((decimal)categories.Count() / 5);

            if (page < 1 || page > totalPages)
            {
                page = 1;
            }

            ViewBag.TotalPages = totalPages;
            ViewBag.PageIndex = page;

            categories = categories
           .Skip((page - 1) * 5)
           .Take(5);

            if (categories == null) return NotFound();

            return PartialView("_CategoryIndexPartial", categories);
        }

        public async Task<IActionResult> ZtoA(int? id,int page)
        {
            if (id == null) return NotFound();
            IEnumerable<Category> categories = await _context.Categories
            .OrderByDescending(p => p.Name)
            .ToListAsync();

            int totalPages = (int)Math.Ceiling((decimal)categories.Count() / 5);

            if (page < 1 || page > totalPages)
            {
                page = 1;
            }

            ViewBag.TotalPages = totalPages;
            ViewBag.PageIndex = page;

            categories = categories
           .Skip((page - 1) * 5)
           .Take(5);

            if (categories == null) return NotFound();

            return PartialView("_CategoryIndexPartial", categories);
        }

    }
}
