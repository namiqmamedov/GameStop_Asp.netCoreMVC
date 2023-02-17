using GameStop.Areas.Admin.ViewModels.SettingVM;
using GameStop.DAL;
using GameStop.Extension;
using GameStop.Helpers;
using GameStop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Extensions;

namespace GameStop.Areas.Admin.Controllers
{
    [Area("admin")]
    [Authorize(Roles = "SuperAdmin,Admin")]

    public class SettingController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public SettingController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            Dictionary<string, string> settings = await _context.Settings.ToDictionaryAsync(s => s.Key, s => s.Value);

            return View(settings);
        }

        public async Task<IActionResult> Update(string key)
        {
            if (key == null) return BadRequest();
            Setting setting = await _context.Settings.FirstOrDefaultAsync(k => k.Key == key);
            if (setting == null) return NotFound();
            return View(setting);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(string key, Setting setting)
        {

            if (!ModelState.IsValid)
            {
                return View(setting);
            }

            if (key == null) return BadRequest();
            if (key != setting.Key) return NotFound();

            Setting dbSetting = await _context.Settings.FirstOrDefaultAsync(k => k.Key == key);

            if (dbSetting == null) return NotFound();


            //    if (setting.Value != null)
            //    {
            //        if (!setting.Logo.CheckFileSize(300))
            //        {
            //            ModelState.AddModelError("LogoImg", "Secilen Seklin Olcusu Maksimum 300 Kb Ola Biler");
            //            return View(setting);
            //        }

            //        if (!setting.Logo.CheckFileType("image/jpeg"))
            //        {
            //            ModelState.AddModelError("Logo", "Secilen Seklin Novu Uygun Deil");
            //            return View(setting);
            //        }

            //        Helper.DeleteFile(_env, dbSetting.Value, "assets", "images");

            //        dbSetting.Value = setting.Logo.CreateImage(_env, "assets", "images");
            //    }

            //else
            //{
               

            //}

            dbSetting.Value = setting.Value;
            dbSetting.UpdatedAt = DateTime.Now;
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult UploadImage(List<IFormFile> upload)
        {
            var filepath = "";


            foreach (IFormFile photo in Request.Form.Files)
            {
                string serverMapPath = Path.Combine(_env.WebRootPath, "assets", "img", photo.FileName);
                using (var stream = new FileStream(serverMapPath, FileMode.Create))
                {
                    photo.CopyTo(stream);
                }
                filepath = "/assets/" + "img/" + photo.FileName;
            }

            return Json(new { url = filepath });

        }
    }
}

