using GameStop.DAL;
using GameStop.Extension;
using GameStop.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.Areas.Admin.Controllers
{
    [Area("admin")]
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public ProductController(AppDbContext context,IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Product> products = await _context.Products
           .Where(e => e.IsDeleted == false)
           .ToListAsync();

            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (await _context.Products.AnyAsync(p=>p.Title .ToLower().Trim() == product.Title.ToLower().Trim() && !p.IsDeleted))
            {
                ModelState.AddModelError("Title", $"{product.Title} is already exists");

                return View();
            }

            if (product.File == null)
            {
                ModelState.AddModelError("File", "File is required");
                return View(product);
            }

            if (product.File.ContentType != "image/*")
            {
                ModelState.AddModelError("File", "File extension must belong to the image");
            }
            if (product.File.Length > 20000)
            {
                ModelState.AddModelError("File", "The maximum size should be 20mb !");
                return View(product);
            }

            product.Image = product.File.CreateImage(_env, "assets", "img");



            await _context.Products.AddAsync(product);
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

            Product product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id,Product product)
        {
            if (id == null)
            {
                return BadRequest();
            }

            if (id != product.Id)
            { 
                return BadRequest();
            }

            if (await _context.Products.AnyAsync(p => p.Id != product.Id && !p.IsDeleted && p.Title.ToLower().Trim() == product.Title.ToLower().Trim()))
            {
                ModelState.AddModelError("Title", $"{product.Title} is already exists");

                return View();
            }

            Product dbProduct = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);

            if (dbProduct == null)
            {
                return NotFound();
            }

            dbProduct.Title = product.Title;
            dbProduct.CreatedAt = DateTime.Now;
            dbProduct.UpdatedAt = DateTime.Now;

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
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

            product.IsDeleted = true;
            product.DeletedAt = DateTime.Now;

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }

    }
}
