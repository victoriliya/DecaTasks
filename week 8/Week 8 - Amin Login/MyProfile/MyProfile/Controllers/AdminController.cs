using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyProfile.Models;
using MyProfile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProfile.Controllers
{

    public class AdminController : Controller
    {
        private readonly UserManager<Admin> _userManager;
        private SignInManager<Admin> _signInManager { get; } 
        public AdminController(UserManager<Admin> userManager, SignInManager<Admin> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Register() {
            var model = new RegisterViewModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model) {
            if (!ModelState.IsValid)
                return View(model);
            // Check if email exist

            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user != null)
            {
                ModelState.AddModelError("", "Email already exist");
            }

            // AutoMapper API makes this easier
            var userToAdd = new Admin
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                PasswordHash = model.Password,
                UserName = model.Email
            };

            var result = await _userManager.CreateAsync(userToAdd, model.Password);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(model);
            }

            var emailConfirmationToken = await _userManager.GenerateEmailConfirmationTokenAsync(userToAdd);
            var emailConfirmationUrl = Url.Action("RegistrationConfirmation", "Admin", new { userId = userToAdd.Id, token = emailConfirmationToken }, Request.Scheme);
            //To do email confirmation

            return RedirectToAction("RegistrationConfirmationPage", new { link = emailConfirmationUrl, str = $"{userToAdd.FirstName} {userToAdd.LastName}" });

            /*return RedirectToAction("AccountConfirmation", new { str = $"{userToAdd.FirstName} {userToAdd.LastName}"});*/
        }

        [HttpGet]
        public IActionResult RegistrationConfirmationPage(string link, string str)
        {
            ViewBag.Username = str;
            ViewBag.Link = link;
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> RegistrationConfirmation(string userId, string token)
        {
            if (!string.IsNullOrWhiteSpace(userId) && !string.IsNullOrWhiteSpace(token))
            {
                var user = await _userManager.FindByIdAsync(userId);
                var result = await _userManager.ConfirmEmailAsync(user, token);
                if (!result.Succeeded)
                {
                    ViewBag.ErrorMessage = "Email not confirmed";
                    return View();
                }

                return RedirectToAction("AccountConfirmation", new { str = $"{user.FirstName} {user.LastName}" });
            }

            ViewBag.ErrorMessage = "Invalid credentials";
            return View();
            
        }

        [HttpGet]
        public IActionResult AccountConfirmation(string str)
        {
            ViewBag.UserName = str;
            return View();
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult>  Login(AdminViewModel model) {
            if (!ModelState.IsValid)
                return View(model);

            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user == null)
            {
                ModelState.AddModelError("", "Invalid credentials");
                ViewBag.ErrorMessage = "Invalid credentials";
                return View();
            }

            if (!await _userManager.IsEmailConfirmedAsync(user))
            {
                ModelState.AddModelError("", "Email not comfirmed");
                ViewBag.ErrorMessage = "Email not comfirmed";
                return View(model);
            }

            var result = await _signInManager.PasswordSignInAsync(user, model.Password, isPersistent: model.RememberMe, false);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Invalid credentials");
                ViewBag.ErrorMessage = "Invalid credentials";
                return View(model);
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
