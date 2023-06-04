﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransportManagement.Entities;
using TransportManagement.Models.Fuel;
using TransportManagement.Services.IServices;
using TransportManagement.Utilities;

namespace TransportManagement.Controllers
{
    [Authorize(Roles = "Quản trị viên hệ thống, Kế toán trưởng")]
    public class FuelController : Controller
    {
        private readonly IFuelServices _fuelServices;

        public FuelController(IFuelServices fuelServices)
        {
            _fuelServices = fuelServices;
        }
        public IActionResult Index()
        {
            List<FuelViewModel> fuels = _fuelServices.GetFuels().ToList();
            return View(fuels);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateFuelViewModel model)
        {
            string message = String.Empty;
            if (ModelState.IsValid)
            {
                if (await _fuelServices.Create(model))
                {
                    message = "New fuel has been created";
                    TempData["UserMessage"] = SystemUtilites.SendSystemNotification(NotificationType.Success, message);
                    return RedirectToAction(actionName: "Index");
                }
            }
            message = "Unknown error, please try again";
            TempData["UserMessage"] = SystemUtilites.SendSystemNotification(NotificationType.Error, message);
            return RedirectToAction(actionName: "Index");
        }
        [HttpPost]
        public async Task<IActionResult> Edit(EditFuelViewModel model)
        {
            string message = String.Empty;
            if (ModelState.IsValid)
            {
                var fuel = _fuelServices.GetFuel(model.FuelId);
                if (fuel != null)
                {
                    if (await _fuelServices.Edit(model))
                    {
                        message = "Fuel info has been edited";
                        TempData["UserMessage"] = SystemUtilites.SendSystemNotification(NotificationType.Success, message);
                        return RedirectToAction(actionName: "Index");
                    }
                }
            }
            message = "Unknown error, please try again";
            TempData["UserMessage"] = SystemUtilites.SendSystemNotification(NotificationType.Error, message);
            return RedirectToAction(actionName: "Index");
        }

        [HttpGet]
        public IActionResult GetFuel(int fuelId)
        {
            var fuel = _fuelServices.GetFuel(fuelId);
            if (fuel != null)
            {
                return Ok(fuel);
            }
            return NotFound();
        }
    }
}