using GameStop.ViewModels;
using GameStop.DAL;
using GameStop.Extension;
using GameStop.Helpers;
using GameStop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
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
    [Authorize(Roles = "SuperAdmin,Admin")]
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public ProductController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index(int page, int userId)
        {
            IQueryable<Product> products = _context.Products
           .OrderBy(c => c.Id);

            return View(PageNationList<Product>.Create(products, page, 5));
        }

        public async Task<IActionResult> Modal(int? id)
        {
            Product product = await _context.Products.Include(p => p.ProductImages)
            .FirstOrDefaultAsync(p => p.IsDeleted == false && p.Id == id);

            return View(product);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Category = await _context.Categories.Where(p => !p.IsDeleted).ToListAsync();
            ViewBag.SubCategory = await _context.SubCategories.Where(p => !p.IsDeleted).ToListAsync();
            ViewBag.Label = await _context.Labels.Where(p => !p.IsDeleted).ToListAsync();
            ViewBag.Specifications = await _context.ProductSpecs.Where(p => !p.IsDeleted).ToListAsync();
            ViewBag.Condition = await _context.Conditions.Where(p => !p.IsDeleted).ToListAsync();
            ViewBag.Features = await _context.ProductFeatures.Where(p => !p.IsDeleted).ToListAsync();
            ViewBag.Description = await _context.ProductDescriptions.Where(p => !p.IsDeleted).ToListAsync();


            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product)
        {
            ViewBag.Category = await _context.Categories.Where(p => !p.IsDeleted).ToListAsync();
            ViewBag.SubCategory = await _context.SubCategories.Where(p => !p.IsDeleted).ToListAsync();
            ViewBag.Label = await _context.Labels.Where(p => !p.IsDeleted).ToListAsync();
            ViewBag.Specifications = await _context.ProductSpecs.Where(p => !p.IsDeleted).ToListAsync();
            ViewBag.Condition = await _context.Conditions.Where(p => !p.IsDeleted).ToListAsync();
            ViewBag.Features = await _context.ProductFeatures.Where(p => !p.IsDeleted).ToListAsync();
            ViewBag.Description = await _context.ProductDescriptions.Where(p => !p.IsDeleted).ToListAsync();


            if (!ModelState.IsValid)
            {
                return View();
            }



            if (product.ConditionIds.Count == 0)
            {
                ModelState.AddModelError("", "minimum bir dene ola biler");
                return View(product);
            }


            if (product.LabelIds.Count == 0)
            {
                ModelState.AddModelError("", "minimum bir dene ola biler");
                return View(product);
            }

            if (!await _context.Categories.AnyAsync(p => !p.IsDeleted && p.Id == product.CategoryId))
            {
                ModelState.AddModelError("CategoryId", $"Please select a correct category");

                return View();
            }

            if (!await _context.SubCategories.AnyAsync(p => !p.IsDeleted && p.Id == product.SubCategoryId))
            {
                ModelState.AddModelError("SubcategoryId", $"Please select a correct subcategory");

                return View();
            }


            if (await _context.Products.AnyAsync(p => p.Title.ToLower().Trim() == product.Title.ToLower().Trim() && !p.IsDeleted))
            {
                ModelState.AddModelError("Title", $"{product.Title} is already exists");

                return View();
            }


            if (product.File == null)
            {
                ModelState.AddModelError("File", "File is required");
                return View(product);
            }

            if (product.File != null)
            {
                if (!product.File.CheckFileType("image/jpeg"))
                {
                    ModelState.AddModelError("File", "File is required");
                    return View(product);
                }

                product.Image = product.File.CreateImage(_env, "assets", "img", "products");

            }


            if (product.ProductImagesFile != null && product.ProductImagesFile.Count() > 0)
            {
                List<ProductImage> productImages = new List<ProductImage>();

                foreach (IFormFile file in product.ProductImagesFile)
                {
                    if (!file.CheckFileType("image/jpeg"))
                    {
                        ModelState.AddModelError("File", "File extension must belong to the image");
                        return View();
                    }

                    //if (file.Length > 20000)
                    //{
                    //    ModelState.AddModelError("File", "The maximum size should be 20mb !");
                    //    return View(product);
                    //}

                    if (product.ProductImagesFile.Count() > 8)
                    {
                        ModelState.AddModelError("File", "You cannot select more than 8 images");
                        return View(product);
                    }

                    ProductImage productImage = new ProductImage
                    {
                        Image = file.CreateImage(_env, "assets", "img", "products")

                    };
                    productImages.Add(productImage);
                }

                product.ProductImages = productImages;
            }

            if (product.ProductDescriptionMain != null)
            {
                List<ProductDescription> productDescriptions = new List<ProductDescription>();
                for (int i = 0; i < product.ProductDescriptionMain.Count; i++)
                {
                    ProductDescription productDescription = new ProductDescription
                    {
                        Description = product.ProductDescriptionMain[i],
                    };
                    productDescriptions.Add(productDescription);
                }
                product.ProductDescriptions = productDescriptions;
            }

            if (product.ProductFeaturesMain != null)
            {
                List<ProductFeatures> productFeatures = new List<ProductFeatures>();
                for (int i = 0; i < product.ProductFeaturesMain.Count; i++)
                {
                    ProductFeatures productFeature = new ProductFeatures
                    {
                        Description = product.ProductFeaturesMain[i],
                    };
                    productFeatures.Add(productFeature);
                }
                product.ProductFeatures = productFeatures;
            }


            List<ProductLabel> productLabels = new List<ProductLabel>();

            for (int i = 0; i < product.LabelIds.Count(); i++)
            {
                if (!await _context.Labels.AnyAsync(p => p.Id == product.LabelIds[i]))
                {
                    ModelState.AddModelError("", $"This condition id {product.LabelIds[i]} is incorrect");
                    return View(product);
                }

                //if (product.Counts[i] < 0)
                //{
                //    ModelState.AddModelError("", "Count is incorrect");
                //    return View(product);
                //}

                ProductLabel productLabel = new ProductLabel
                {
                    LabelId = product.LabelIds[i],
                    Count = product.CondCounts[i]
                };
                productLabels.Add(productLabel);
            }
            product.ProductLabels = productLabels;


            List<ProductCondition> productConditions = new List<ProductCondition>();

            for (int i = 0; i < product.ConditionIds.Count(); i++)
            {
                if (!await _context.Conditions.AnyAsync(p=>p.Id == product.ConditionIds[i]))
                {
                    ModelState.AddModelError("", $"This condition id {product.ConditionIds[i]} is incorrect");
                    return View(product);
                }

                //if (product.Counts[i] < 0)
                //{
                //    ModelState.AddModelError("", "Count is incorrect");
                //    return View(product);
                //}

                ProductCondition productCondition = new ProductCondition
                {
                    ConditionId = product.ConditionIds[i],
                    Count = product.Counts[i]
                };
                productConditions.Add(productCondition);
            }
            product.ProductConditions = productConditions;



            product.Title = product.Title.Trim();
            product.CreatedAt = DateTime.Now;
            product.Count = productConditions.Sum(x => x.Count);
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Update(int? id)
        {
            ViewBag.Category = await _context.Categories.Where(p => !p.IsDeleted).ToListAsync();
            ViewBag.SubCategory = await _context.SubCategories.Where(p => !p.IsDeleted).ToListAsync();
            ViewBag.Label = await _context.Labels.Where(p => !p.IsDeleted).ToListAsync();
            ViewBag.Specifications = await _context.ProductSpecs.Where(p => !p.IsDeleted).ToListAsync();
            ViewBag.Condition = await _context.Conditions.Where(p => !p.IsDeleted).ToListAsync();
            ViewBag.Features = await _context.ProductFeatures.Where(p => !p.IsDeleted).ToListAsync();
            ViewBag.Description = await _context.ProductDescriptions.Where(p => !p.IsDeleted).ToListAsync();

            if (id == null)
            {
                return BadRequest();
            }

            Product product = await _context.Products
                .Include(p => p.ProductImages)
                .Include(p => p.ProductDescriptions)
                .Include(p => p.ProductFeatures)
                .Include(p => p.ProductSpecs)
                .Include(p => p.ProductLabels)
                .ThenInclude(p => p.Label)
                .Include(p => p.ProductConditions)
                .ThenInclude(p => p.Condition)
                .FirstOrDefaultAsync(p => p.Id == id && !p.IsDeleted);

            if (product == null)
            {
                return NotFound();
            }

            product.LabelIds = await _context.ProductLabels.Where(pt => pt.ProductId == id).Select(t => t.LabelId).ToListAsync();
            product.ConditionIds = await _context.ProductConditions.Where(pt => pt.ProductId == id).Select(t => t.ConditionId).ToListAsync();
            //product.ProductFeaturesMain = product.ProductFeatures.Select(p => p.Description).ToList();
            //product.ProductDescriptionMain = product.ProductDescriptions.Select(p => p.Description).ToList();
            //product.ProductSpecMain = product.ProductSpecs.Select(p => p.Spe).ToList();




            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Product product)
        {
            ViewBag.Category = await _context.Categories.Where(p => !p.IsDeleted).ToListAsync();
            ViewBag.SubCategory = await _context.SubCategories.Where(p => !p.IsDeleted).ToListAsync();
            ViewBag.Label = await _context.Labels.Where(p => !p.IsDeleted).ToListAsync();
            ViewBag.Specifications = await _context.ProductSpecs.Where(p => !p.IsDeleted).ToListAsync();
            ViewBag.Condition = await _context.Conditions.Where(p => !p.IsDeleted).ToListAsync();
            ViewBag.Features = await _context.ProductFeatures.Where(p => !p.IsDeleted).ToListAsync();
            ViewBag.Description = await _context.ProductDescriptions.Where(p => !p.IsDeleted).ToListAsync();


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

            if (!await _context.Categories.AnyAsync(p => !p.IsDeleted && p.Id == product.CategoryId))
            {
                ModelState.AddModelError("CategoryId", $"Please select a correct category");

                return View();
            }

            if (!await _context.SubCategories.AnyAsync(p => !p.IsDeleted && p.Id == product.SubCategoryId))
            {
                ModelState.AddModelError("SubcategoryId", $"Please select a correct subcategory");

                return View();
            }

            Product dbProduct = await _context.Products
                .Include(p => p.ProductFeatures)
                .Include(p => p.ProductDescriptions)
                .Include(p => p.ProductImages)
                .Include(p => p.ProductSpecs)
                .Include(p => p.ProductConditions)
                .ThenInclude(p => p.Condition)
                .Include(p => p.ProductLabels)
                .ThenInclude(p => p.Label)
                .FirstOrDefaultAsync(p => p.Id == id && !p.IsDeleted);

            //if (product.LabelIds.Count != product.Counts.Count)
            //{
            //    ModelState.AddModelError("", "Incorrect Count");
            //    return View(dbProduct);
            //}

            //if (product.ConditionIds.Count != product.Counts.Count)
            //{
            //    ModelState.AddModelError("", "Incorrect Count");
            //    return View(dbProduct);
            //}

            if (dbProduct == null)
            {
                return NotFound();
            }

            if (product.File != null)
            {
                if (!product.File.CheckFileType("image/jpeg"))
                {
                    ModelState.AddModelError("File", "File is required");
                    return View(product);
                }

                if (product.File.CheckFileSize(20000))
                {
                    ModelState.AddModelError("File", "The maximum size should be 20mb !");
                    return View(product);
                }

                Helper.DeleteFile(_env, dbProduct.Image, "assets", "img", "products");

                dbProduct.Image = product.File.CreateImage(_env, "assets", "img", "products");
            }

            if (product.ProductImagesFile != null && product.ProductImagesFile.Count() > 0)
            {
                List<ProductImage> productImages = new List<ProductImage>();

                foreach (IFormFile file in product.ProductImagesFile)
                {
                    if (!file.CheckFileType("image/jpeg"))
                    {
                        ModelState.AddModelError("File", "File extension must belong to the image");
                        return View();
                    }

                    //if (file.CheckFileSize(20000))
                    //{
                    //    ModelState.AddModelError("File", "The maximum size should be 20mb !");
                    //    return View(product);
                    //}

                    if (product.ProductImagesFile.Count() > 8)
                    {
                        ModelState.AddModelError("File", "You cannot select more than 8 images");
                        return View(product);
                    }

                    ProductImage productImage = new ProductImage
                    {
                        Image = file.CreateImage(_env, "assets", "img", "products")

                    };
                    productImages.Add(productImage);
                }

                dbProduct.ProductImages.AddRange(productImages);
            }

            if (product.ProductFeaturesMain != null)
            {
                _context.ProductFeatures.RemoveRange(dbProduct.ProductFeatures);

                List<ProductFeatures> productFeatures = new List<ProductFeatures>();

                for (int i = 0; i < product.ProductFeaturesMain.Count; i++)
                {
                    if (product.ProductFeaturesMain[i] != null)
                    {
                        ProductFeatures productFeature = new ProductFeatures
                        {
                            Description = product.ProductFeaturesMain[i],
                        };
                        productFeatures.Add(productFeature);
                    }

                }
                product.ProductFeatures = productFeatures;
                dbProduct.ProductFeatures = product.ProductFeatures;
            }

            if (product.ProductDescriptionMain != null)
            {
                _context.ProductDescriptions.RemoveRange(dbProduct.ProductDescriptions);

                List<ProductDescription> productDescriptions = new List<ProductDescription>();

                for (int i = 0; i < product.ProductDescriptionMain.Count; i++)
                {
                    if (product.ProductDescriptionMain[i] != null)
                    {
                        ProductDescription productDescription = new ProductDescription
                        {
                            Description = product.ProductDescriptionMain[i],
                        };
                        productDescriptions.Add(productDescription);
                    }

                }
                product.ProductDescriptions = productDescriptions;
                dbProduct.ProductDescriptions = product.ProductDescriptions;
                dbProduct.UpdatedAt = DateTime.Now;
            }

            if (product.LabelIds.Count() > 0)
            {
                _context.ProductLabels.RemoveRange(dbProduct.ProductLabels);

                List<ProductLabel> productLabels = new List<ProductLabel>();
                for (int i = 0; i < product.LabelIds.Count; i++)
                {
                    ProductLabel productLabel = new ProductLabel
                    {
                        LabelId = product.LabelIds[i],
                        Count = product.CondCounts[i]
                    };
                    productLabels.Add(productLabel);
                }
                product.ProductLabels = productLabels;
                dbProduct.ProductLabels = product.ProductLabels;
            }


            if (product.ConditionIds.Count() > 0)
            {
                _context.ProductConditions.RemoveRange(dbProduct.ProductConditions);

                List<ProductCondition> productConditions = new List<ProductCondition>();
                for (int i = 0; i < product.ConditionIds.Count; i++)
                {
                    ProductCondition productCondition = new ProductCondition
                    {
                        ConditionId = product.ConditionIds[i],
                        Count = product.Counts[i]
                    };
                    productConditions.Add(productCondition);
                }
                product.ProductConditions = productConditions;
                dbProduct.ProductConditions = product.ProductConditions;

            }
            else
            {
                ModelState.AddModelError("", "Error");
                return View(dbProduct);
            }


            dbProduct.Title = product.Title.Trim();
            dbProduct.Price = product.Price;
            dbProduct.Count = product.Count;
            dbProduct.DiscountedPrice = product.DiscountedPrice;
            dbProduct.OldPrice = product.OldPrice;
            dbProduct.Brand = product.Brand;
            dbProduct.UpdatedAt = DateTime.Now;
            dbProduct.CategoryId = product.CategoryId;
            dbProduct.SubCategoryId = product.SubCategoryId;

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }



        public async Task<IActionResult> DeleteProd(int? id, int page)
        {

            IQueryable<Product> products = _context.Products
            .OrderByDescending(p => p.Id);
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

            return PartialView("_ProductIndexPartial", PageNationList<Product>.Create(products, page, 5));

        }

        public async Task<IActionResult> RestoreProd(int? id, int page)
        {
            IQueryable<Product> products = _context.Products
            .OrderByDescending(p => p.Id);
            if (id == null)
            {
                return BadRequest();
            }

            if (id == null)
            {
                return BadRequest();
            }

            Product product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            product.IsDeleted = false;
            product.DeletedAt = null;

            await _context.SaveChangesAsync();

            return PartialView("_ProductIndexPartial", PageNationList<Product>.Create(products, page, 5));

        }

        public async Task<IActionResult> GetLabelCount()
        {
            ViewBag.Label = await _context.Labels.Where(p => !p.IsDeleted).ToListAsync();
            return PartialView("_ProductLabelPartial");
        }


        public async Task<IActionResult> GetLabelCountt()
        {
            ViewBag.Label = await _context.Labels.Where(p => !p.IsDeleted).ToListAsync();
            return PartialView("_LabelPartial");
        }


        public async Task<IActionResult> GetCondCount()
        {
            ViewBag.Condition = await _context.Conditions.Where(p => !p.IsDeleted).ToListAsync();
            return PartialView("_ProductConditionPartial");
        }
        //public async Task<IActionResult> GetLabelCountt()
        //{
        //    ViewBag.Label = await _context.Labels.Where(p => !p.IsDeleted).ToListAsync();
        //    return PartialView("_ProductLabelPartial");
        //}
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

        [HttpGet]
        public async Task<IActionResult> RemoveImg(int? id)
        {
            if (id == null) return BadRequest();

            ProductImage productImage = await _context.ProductImages.Include(p => p.Product).FirstOrDefaultAsync(p => p.Id == id);

            if (productImage == null) return NotFound();

            Product product = await _context.Products.Include(p => p.ProductImages).FirstOrDefaultAsync(p => p.Id == productImage.ProductId);

            _context.ProductImages.Remove(productImage);

            await _context.SaveChangesAsync();

            Helper.DeleteFile(_env, productImage.Image);

            return PartialView("_ProductImagePartial", product.ProductImages);

        }

        [HttpGet]
        public async Task<IActionResult> RemoveLabel(int? id)
        {
            if (id == null) return BadRequest();

            ProductLabel productLabel = await _context.ProductLabels.Include(p => p.Product).FirstOrDefaultAsync(p => p.Id == id);

            if (productLabel == null) return NotFound();

            Product product = await _context.Products.Include(p => p.ProductLabels).FirstOrDefaultAsync(p => p.Id == productLabel.ProductId);

            _context.ProductLabels.Remove(productLabel);

            await _context.SaveChangesAsync();

            return PartialView("_ProductLabelPartial", product.ProductLabels);

        }

        // FILTER OPTIONS 

        public async Task<IActionResult> Matched(int? id, int page)
        {
            if (id == null) return NotFound();

            IQueryable<Product> products = _context.Products
                .Where(p => p.IsDeleted == false);


            if (products == null) return NotFound();

            return PartialView("_ProductIndexPartial", PageNationList<Product>.Create(products, page, 5));
        }


        public async Task<IActionResult> Active(int? id, int page)
        {
            if (id == null) return NotFound();
            IQueryable<Product> products = _context.Products
            .OrderByDescending(c => c.IsDeleted == false);


            if (products == null) return NotFound();

            return PartialView("_ProductIndexPartial", PageNationList<Product>.Create(products, page, 5));
        }

        public async Task<IActionResult> InActive(int? id, int page)
        {
            if (id == null) return NotFound();
            IQueryable<Product> products = _context.Products
            .OrderByDescending(c => c.IsDeleted);

            if (products == null) return NotFound();

            return PartialView("_ProductIndexPartial", PageNationList<Product>.Create(products, page, 5));
        }


        public async Task<IActionResult> OldToNew(int? id, int page)
        {
            if (id == null) return NotFound();
            IQueryable<Product> products = _context.Products
            .OrderBy(c => c.CreatedAt);

            if (products == null) return NotFound();

            return PartialView("_ProductIndexPartial", PageNationList<Product>.Create(products, page, 5));

        }

        public async Task<IActionResult> NewToOld(int? id, int page)
        {
            if (id == null) return NotFound();
            IQueryable<Product> products = _context.Products
           .OrderByDescending(c => c.CreatedAt);

            if (products == null) return NotFound();

            return PartialView("_ProductIndexPartial", PageNationList<Product>.Create(products, page, 5));
        }

        public async Task<IActionResult> AtoZ(int? id, int page)
        {
            if (id == null) return NotFound();
            IQueryable<Product> products = _context.Products
           .OrderBy(c => c.Title);

            if (products == null) return NotFound();

            return PartialView("_ProductIndexPartial", PageNationList<Product>.Create(products, page, 5));
        }

        public async Task<IActionResult> ZtoA(int? id, int page)
        {
            if (id == null) return NotFound();
            IQueryable<Product> products = _context.Products
           .OrderByDescending(c => c.Title);

            if (products == null) return NotFound();

            return PartialView("_ProductIndexPartial", PageNationList<Product>.Create(products, page, 5));
        }



    }
}
