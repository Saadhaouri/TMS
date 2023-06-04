﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransportManagement.Entities;
using TransportManagement.Models.Pagination;
using TransportManagement.Models.Role;
using TransportManagement.Utilities;

namespace TransportManagement.Controllers
{
    [Authorize(Roles = "Quản trị viên hệ thống")]
    public class RoleController : Controller
    {
        private readonly RoleManager<AppIdentityRole> _roleManager;

        public RoleController(RoleManager<AppIdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }
        [HttpGet]
        public IActionResult Index(int page, int pageSize)
        {
            int countRoles = _roleManager.Roles.Count();
            PaginationViewModel<RoleViewModel> model = new PaginationViewModel<RoleViewModel>();
            if (page == 0) page = 1;
            if (pageSize == 0) pageSize = model.PageSizeItem.Min();
            model.Pager = new Pager(countRoles, page, pageSize);
            model.Items = GetRoles(page, pageSize);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateRoleViewModel model)
        {
            string message = String.Empty;
            if (ModelState.IsValid)
            {
                AppIdentityRole newRole = new AppIdentityRole()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = model.RoleName,
                    RolePriority = model.RolePriority,
                    IsActive = true
                };
                var result = await _roleManager.CreateAsync(newRole);
                if (result.Succeeded)
                {
                    message = "New authorization has been created";
                    TempData["UserMessage"] = SystemUtilites.SendSystemNotification(NotificationType.Success, message);
                    return RedirectToAction(actionName: "Index");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            message = "Unknown error, please try again";
            TempData["UserMessage"] = SystemUtilites.SendSystemNotification(NotificationType.Error, message);
            return RedirectToAction(actionName: "Index");
        }

        [HttpPut]
        public async Task<IActionResult> Edit(EditRoleViewModel model)
        {
            string message = String.Empty;
            if (ModelState.IsValid)
            {
                var roleEdit = await _roleManager.FindByIdAsync(model.RoleId);
                if (roleEdit != null)
                {
                    roleEdit.Name = model.RoleName;
                    roleEdit.RolePriority = model.RolePriority;
                    roleEdit.IsActive = model.IsActive;
                    var result = await _roleManager.UpdateAsync(roleEdit);
                    if (result.Succeeded)
                    {
                        message = "Permissions have been adjusted";
                        TempData["UserMessage"] = SystemUtilites.SendSystemNotification(NotificationType.Success, message);
                        return RedirectToAction(actionName: "Index");
                    }
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            message = "Unknown error, please try again";
            TempData["UserMessage"] = SystemUtilites.SendSystemNotification(NotificationType.Error, message);
            return RedirectToAction(actionName: "Index");
        }

        [HttpGet]
        public async Task<IActionResult> DeleteRoleDB(string roleId)
        {
            string message = String.Empty;
            var roleDel = await _roleManager.FindByIdAsync(roleId);
            if (roleDel != null)
            {
                var result = await _roleManager.DeleteAsync(roleDel);
                if (result.Succeeded)
                {
                    message = "Permissions have been removed";
                    TempData["UserMessage"] = SystemUtilites.SendSystemNotification(NotificationType.Success, message);
                    return RedirectToAction(actionName: "Index");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            message = "Unknown error, please try again";
            TempData["UserMessage"] = SystemUtilites.SendSystemNotification(NotificationType.Error, message);
            return RedirectToAction(actionName: "Index");
        }

        [HttpGet]
        public async Task<IActionResult> GetRole(string roleId)
        {
            var role = await _roleManager.FindByIdAsync(roleId);
            RoleViewModel viewRole = new RoleViewModel()
            {
                RoleId = role.Id,
                RoleName = role.Name,
                RolePriority = role.RolePriority,
                IsActive = role.IsActive
            };
            return Ok(viewRole);
        }

        public IEnumerable<RoleViewModel> GetRoles(int page, int pageSize)
        {
            return _roleManager.Roles.OrderBy(r => r.RolePriority)
                                        .Skip((page - 1) * pageSize)
                                        .Take(pageSize)
                                        .Select(r => new RoleViewModel()
                                        {
                                            RoleId = r.Id,
                                            RoleName = r.Name,
                                            RolePriority = r.RolePriority,
                                            IsActive = r.IsActive
                                        });
        }
    }
}