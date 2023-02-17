using GameStop.Areas.Admin.ViewModels.AccountVM;
using GameStop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.Areas.Admin.Controllers
{
    [Area("admin")]
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (!ModelState.IsValid) return View();

            AppUser appUser = await _userManager.Users.FirstOrDefaultAsync(u => u.NormalizedUserName == loginVM.Username.ToUpper() && !u.IsAdmin);

            if (appUser == null)
            {
                ModelState.AddModelError("", "Username or Password is InCorrect");
                return View(loginVM);
            }

            Microsoft.AspNetCore.Identity.SignInResult signInResult = await _signInManager.PasswordSignInAsync(appUser, loginVM.Password, true, true);


            //if (signInResult.IsLockedOut)
            //{
            //    ModelState.AddModelError("", $"Login to your account has been temporarily disabled. Please wait {appUser.LockoutEnd.Value.Second} seconds and login again.");
            //    return View(loginVM);
            //}

            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError("", "Username or password is incorrect");
                return View(loginVM);
            }

            return RedirectToAction("Index","Product");
        }


        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("login", "account");
        }

        public IActionResult Profile()
        {
            return View();
        }


    }
}
