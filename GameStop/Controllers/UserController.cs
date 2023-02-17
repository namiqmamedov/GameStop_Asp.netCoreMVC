using GameStop.Models;
using GameStop.ViewModels.UserVM;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStop.Controllers
{
    public class UserController : Controller
    {

        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public UserController(RoleManager<IdentityRole> roleManager, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public async Task<IActionResult> Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (!ModelState.IsValid) return View();

            AppUser appUser = await _userManager.Users.FirstOrDefaultAsync(u => u.NormalizedEmail == loginVM.Email.Trim().ToUpperInvariant() && !u.IsAdmin);

            if (appUser == null)
            {
                ModelState.AddModelError("", "Email or Password is InCorrect");
                return View(loginVM);
            }

            Microsoft.AspNetCore.Identity.SignInResult signInResult = await _signInManager.PasswordSignInAsync(appUser, loginVM.Password, true, true);

            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError("", "Email or Password is InCorrect");
                return View(loginVM);
            }


            await _signInManager.PasswordSignInAsync(appUser, loginVM.Password, loginVM.RememberMe, true);


            return RedirectToAction("Index", "Home");
        }

        public IActionResult Reset()
        {
            return View();
        }


        public IActionResult Address()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            AppUser appUser = new AppUser
            {
                Name = registerVM.Name,
                Surname = registerVM.Surname,
                UserName = registerVM.Username,
                Email = registerVM.Email,
                IsAdmin = false
            };

            IdentityResult result = await _userManager.CreateAsync(appUser, registerVM.Password);

            if (!result.Succeeded)
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View();
            }


            await _userManager.AddToRoleAsync(appUser, "Member");

            await _signInManager.SignInAsync(appUser, true);

            return RedirectToAction("Index", "Login");
        }

        public IActionResult Password()
        {
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("index", "home");
        }

        public async Task<IActionResult> Profile()
        {

            if (User.Identity.IsAuthenticated)
            {
                AppUser appUser = await _userManager.FindByNameAsync(User.Identity.Name);

                if (appUser == null) return NotFound();

                ProfileVM profileVM = new ProfileVM
                {
                    Name = appUser.Name,
                    Email = appUser.Email,
                    Username = appUser.UserName,

                };

                return View(profileVM);
            }
             
            return RedirectToAction("Login");
        }

        [HttpPost]
        public async Task<IActionResult> Update(ProfileVM profileVM)
        {

            if (ModelState.IsValid) return View("Profile", profileVM);

            AppUser dbAppUser = await _userManager.FindByNameAsync(User.Identity.Name);

            if (dbAppUser.NormalizedUserName != profileVM.Username.Trim().ToUpperInvariant() || dbAppUser.Name.ToUpperInvariant() != profileVM.Name.Trim().ToUpperInvariant() || dbAppUser.NormalizedEmail != profileVM.Email.Trim().ToUpperInvariant())
            {
                dbAppUser.Name = profileVM.Name;
                dbAppUser.Email = profileVM.Email;
                dbAppUser.UserName = profileVM.Username;

                IdentityResult identityResult = await _userManager.UpdateAsync(dbAppUser);

                if (!identityResult.Succeeded)
                {
                    foreach (var item in identityResult.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }

                    return View("Profile", profileVM);
                }
            }


            if (profileVM.CurrentPassword != null && profileVM.Password != null)
            {

                if (await _userManager.CheckPasswordAsync(dbAppUser,profileVM.CurrentPassword) && profileVM.CurrentPassword == profileVM.CurrentPassword)
                {
                    ModelState.AddModelError("", "New password is the same your current password");
                }

                IdentityResult identityResult = await _userManager.ChangePasswordAsync(dbAppUser, profileVM.CurrentPassword, profileVM.Password);


                if (!identityResult.Succeeded)
                {
                    foreach (var item in identityResult.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }

                    return View("Profile", profileVM);
                }
            }

            return RedirectToAction("Profile");
        }

    }
}
