using GameStop.ViewModels;
using GameStop.DAL;
using GameStop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.Areas.Admin.Controllers
{

    [Area("admin")]
    [Authorize(Roles = "SuperAdmin,Admin")]
    public class SubCategoryController : Controller
    {

        private readonly AppDbContext _context;

        public SubCategoryController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int page)
        {
            IQueryable<SubCategory> subCategories = _context.SubCategories
                .OrderBy(c => c.Id);

            return View(PageNationList<SubCategory>.Create(subCategories, page, 5));
        }


        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Category = await _context.Categories.Where(p => !p.IsDeleted).ToListAsync();
            
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SubCategory subCategory)
        {
            ViewBag.Category = await _context.Categories.Where(p => !p.IsDeleted).ToListAsync();
            ViewBag.SubCategory = await _context.SubCategories.Where(p => !p.IsDeleted).ToListAsync();

            if (!ModelState.IsValid)
            {
                return View();
            }

            if (!await _context.Categories.AnyAsync(p => !p.IsDeleted && p.Id == subCategory.CategoryId))
            {
                ModelState.AddModelError("CategoryId", $"Please select a correct category");

                return View();
            }

            if (await _context.Categories.AnyAsync(p => p.Name.ToLower().Trim() == subCategory.Name.ToLower().Trim() && !p.IsDeleted))
            {
                ModelState.AddModelError("Title", $"{subCategory.Name} is already exists");

                return View();
            }

            subCategory.Name = subCategory.Name.Trim();
            subCategory.CreatedAt = DateTime.Now;
            await _context.SubCategories.AddAsync(subCategory);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }


        [HttpGet]

        public async Task<IActionResult> Update(int? id)
        {
            ViewBag.SubCategory = await _context.SubCategories.Where(p => !p.IsDeleted).ToListAsync();
            ViewBag.Category = await _context.Categories.Where(p => !p.IsDeleted).ToListAsync();


            if (id == null)
            {
                return BadRequest();
            }

            SubCategory subCategory = await _context.SubCategories.FirstOrDefaultAsync(p => p.Id == id);

            if (subCategory == null)
            {
                return NotFound();
            }

            return View(subCategory);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, SubCategory subCategory)
        {

            if (!await _context.Categories.AnyAsync(p => !p.IsDeleted && p.Id == subCategory.CategoryId))
            {
                ModelState.AddModelError("SubcategoryId", $"Please select a correct category");

                return View();
            }

            if (id == null)
            {
                return BadRequest();
            }

            if (id != subCategory.Id)
            {
                return BadRequest();
            }

            if (await _context.Categories.AnyAsync(p => p.Id != subCategory.Id && !p.IsDeleted && p.Name.ToLower().Trim() == subCategory.Name.ToLower().Trim() && !p.IsDeleted))
            {
                ModelState.AddModelError("Name", $"{subCategory.Name} is already exists");

                return View();
            }

            SubCategory dbSubCategory = await _context.SubCategories.FirstOrDefaultAsync(p => p.Id == id);

            if (dbSubCategory == null)
            {
                return NotFound();
            }

            dbSubCategory.Name = subCategory.Name;
            dbSubCategory.UpdatedAt = DateTime.Now;

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id, int page)
        {

            IQueryable<SubCategory> subCategories = _context.SubCategories
            .OrderByDescending(c => c.Id);
            if (id == null)
            {
                return BadRequest();
            }

            SubCategory subCategory = await _context.SubCategories.FirstOrDefaultAsync(p => p.Id == id);

            if (subCategory == null)
            {
                return NotFound();
            }

            subCategory.IsDeleted = true;
            subCategory.DeletedAt = DateTime.Now;

            await _context.SaveChangesAsync();

            return PartialView("_SubCategoryIndexPartial", PageNationList<SubCategory>.Create(subCategories, page, 5));

        }

        public async Task<IActionResult> Restore(int? id, int page)
        {
            IQueryable<SubCategory> subCategories = _context.SubCategories
             .OrderByDescending(c => c.Id);
            if (id == null)
            {
                return BadRequest();
            }

            if (id == null)
            {
                return BadRequest();
            }

            SubCategory subCategory = await _context.SubCategories.FirstOrDefaultAsync(p => p.Id == id);

            if (subCategory == null)
            {
                return NotFound();
            }

            subCategory.IsDeleted = false;
            subCategory.DeletedAt = null;

            await _context.SaveChangesAsync();

            return PartialView("_SubCategoryIndexPartial", PageNationList<SubCategory>.Create(subCategories, page, 5));

        }

        // FILTER OPTIONS 
        public async Task<IActionResult> Matched(int? id, int page)
        {
            if (id == null) return NotFound();

            IQueryable<SubCategory> subCategories = _context.SubCategories
                .OrderByDescending(c => c.Id);


            if (subCategories == null) return NotFound();

            return PartialView("_SubCategoryIndexPartial", PageNationList<SubCategory>.Create(subCategories, page, 5));
        }


        public async Task<IActionResult> Active(int? id, int page)
        {
            if (id == null) return NotFound();
            IQueryable<SubCategory> subCategories = _context.SubCategories
                .OrderByDescending(c => c.IsDeleted == false);


            if (subCategories == null) return NotFound();

            return PartialView("_SubCategoryIndexPartial", PageNationList<SubCategory>.Create(subCategories, page, 5));
        }

        public async Task<IActionResult> InActive(int? id, int page)
        {
            if (id == null) return NotFound();
            IQueryable<SubCategory> subCategories = _context.SubCategories
            .OrderByDescending(c => c.IsDeleted == true);

            if (subCategories == null) return NotFound();

            return PartialView("_SubCategoryIndexPartial", PageNationList<SubCategory>.Create(subCategories, page, 5));
        }


    }
}
