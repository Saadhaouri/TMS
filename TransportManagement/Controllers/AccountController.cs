using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransportManagement.DbContexts;
using TransportManagement.Entities;
using TransportManagement.Models.Account;
using TransportManagement.Utilities;

namespace TransportManagement.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly SignInManager<AppIdentityUser> _signInManager;
        private readonly UserManager<AppIdentityUser> _userManager;

        public AccountController(UserManager<AppIdentityUser> userManager,
                                    SignInManager<AppIdentityUser> signInManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Profile(string userId)
        {
            var account = String.IsNullOrEmpty(userId) ? await _userManager.GetUserAsync(User) : await _userManager.FindByIdAsync(userId);
            if (account != null)
            {
                AccountViewModel model = new AccountViewModel()
                {
                    AccountId = account.Id,
                    Avatar = account.Avatar,
                    Email = account.Email,
                    FirstName = account.FirstName,
                    MiddleName = account.MiddleName,
                    LastName = account.LastName,
                    PhoneNumber = account.PhoneNumber,
                    UserName = account.UserName
                };
                return View(model);
            }
            return RedirectToAction(actionName: "Login");
        }

        [HttpGet]
        public async Task<IActionResult> Edit()
        {
            var account = await _userManager.GetUserAsync(User);
            if (account != null)
            {
                EditAccountViewModel model = new EditAccountViewModel()
                {
                    Avatar = account.Avatar,
                    Email = account.Email,
                    FirstName = account.FirstName,
                    MiddleName = account.MiddleName,
                    LastName = account.LastName,
                    PhoneNumber = account.PhoneNumber,
                    UserName = account.UserName
                };
                return View(model);
            }
            return RedirectToAction(actionName: "Login");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditAccountViewModel model)
        {
            string message = String.Empty;
            var user = await _userManager.GetUserAsync(User);
            if (user != null)
            {
                if (ModelState.IsValid)
                {
                    if (user.Id == model.AccountId)
                    {
                        if (!String.IsNullOrEmpty(model.NewPassword) && !String.IsNullOrEmpty(model.ConfirmNewPassword))
                        {
                            if (await _userManager.CheckPasswordAsync(user, model.Password))
                            {
                                var result = await _userManager.ChangePasswordAsync(user, model.Password, model.NewPassword);
                                if (result.Succeeded)
                                {
                                    message = "Password has been changed";
                                    TempData["UserMessage"] = SystemUtilites.SendSystemNotification(NotificationType.Success, message);
                                    return RedirectToAction(actionName: "SignOut");
                                }
                                foreach (var error in result.Errors)
                                {
                                    ModelState.AddModelError("", error.Description);
                                }
                                message = "Unknown error, please try again";
                                TempData["UserMessage"] = SystemUtilites.SendSystemNotification(NotificationType.Error, message);
                                return View(model);
                            }
                            message = "Password can only be changed when the old password is provided";
                            TempData["UserMessage"] = SystemUtilites.SendSystemNotification(NotificationType.Error, message);
                            return RedirectToAction(actionName: "Profile");
                        }
                    }
                    message = "Only edit your own information";
                    TempData["UserMessage"] = SystemUtilites.SendSystemNotification(NotificationType.Error, message);
                    return RedirectToAction(actionName: "Profile");
                }
                message = "Unknown error, please try again";
                TempData["UserMessage"] = SystemUtilites.SendSystemNotification(NotificationType.Error, message);
                return RedirectToAction(actionName: "Profile");

            }
            return RedirectToAction(actionName: "Login");
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(LoginAccountViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(model.UserName);
                if (user != null)
                {
                    if (user.IsActive)
                    {
                        var result = await _signInManager.PasswordSignInAsync(user, model.Password, isPersistent: model.IsRemember, lockoutOnFailure: false);
                        if (result.Succeeded)
                        {
                            if (await _userManager.IsInRoleAsync(user, "Lái xe"))
                            {
                                return RedirectToAction(actionName: "Mobile", controllerName: "Home", new { area = "Driver" });
                            }
                            return RedirectToAction(actionName: "Index", controllerName: "Home");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "Account has been locked");
                        return View(model);
                    }
                }
            }
            ModelState.AddModelError("", "Login failed, please try again");
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> SignOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(actionName: "Login");
        }
    }
}