using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransportManagement.Entities;
using TransportManagement.Models;
using TransportManagement.Models.Pagination;
using TransportManagement.Models.Route;
using TransportManagement.Services;
using TransportManagement.Services.IServices;
using TransportManagement.Utilities;

namespace TransportManagement.Controllers
{
    [Authorize(Roles = "Quản trị viên hệ thống, Quản lý vận chuyển")]
    public class RouteController : Controller
    {
        private readonly IRouteServices _routeServices;
        private readonly ILocationServices _locationServices;

        public RouteController(IRouteServices routeServices,
                                    ILocationServices locationServices)
        {
            _routeServices = routeServices;
            _locationServices = locationServices;
        }
        public IActionResult Index(int page, int pageSize, string search)
        {
            int countTotalRoutes = _routeServices.CountRoutes();
            PaginationViewModel<RouteViewModel> model = new PaginationViewModel<RouteViewModel>();
            if (page == 0) page = 1;
            if (pageSize == 0) pageSize = model.PageSizeItem.Min();
            model.Pager = new Pager(countTotalRoutes, page, pageSize);
            if (String.IsNullOrEmpty(search))
            {
                model.Items = _routeServices.GetAllRoutes(page, pageSize).ToList();
            }
            else
            {
                model.Items = _routeServices.GetAllRoutes(page, pageSize, search).ToList();
            }
            if (_locationServices.CountLocations() > 0)
            {
                ViewBag.Locations = _locationServices.GetAllLocations().ToList();
            }
            ViewBag.Search = search;
            return View(model);
        }
        public async Task<IActionResult> Create(CreateRouteViewModel model)
        {
            string message = String.Empty;
            if (ModelState.IsValid)
            {
                if (model.ArrivalPlaceId == model.DeparturePlaceId)
                {
                    message = "Departure and destination cannot be the same";
                    TempData["UserMessage"] = SystemUtilites.SendSystemNotification(NotificationType.Error, message);
                    return RedirectToAction(actionName: "Index");
                }
                if (model.Distance <= 0)
                {
                    message = "Route length must be greater than 0";
                    TempData["UserMessage"] = SystemUtilites.SendSystemNotification(NotificationType.Error, message);
                    return RedirectToAction(actionName: "Index");
                }
                if (_routeServices.IsRouteExists(departureId: model.DeparturePlaceId, arrivalId: model.ArrivalPlaceId))
                {
                    message = "This shipping route already exists";
                    TempData["UserMessage"] = SystemUtilites.SendSystemNotification(NotificationType.Error, message);
                    return RedirectToAction(actionName: "Index");
                }
                var arrivalPlace = _locationServices.GetLocation(model.ArrivalPlaceId);
                var departurePlace = _locationServices.GetLocation(model.DeparturePlaceId);
                RouteInformation newRoute = new RouteInformation()
                {
                    RouteId = Guid.NewGuid().ToString(),
                    ArrivalPlace = arrivalPlace.LocationName,
                    DeparturePlace = departurePlace.LocationName,
                    ArrivalPlaceId = model.ArrivalPlaceId,
                    DeparturePlaceId = model.DeparturePlaceId,
                    Distance = model.Distance
                };
                if (await _routeServices.CreateRoute(newRoute))
                {
                    message = "Transport route created";
                    TempData["UserMessage"] = SystemUtilites.SendSystemNotification(NotificationType.Success, message);
                    return RedirectToAction(actionName: "Index");
                }
            }
            message = "Unknown error, please try again";
            TempData["UserMessage"] = SystemUtilites.SendSystemNotification(NotificationType.Error, message);
            return RedirectToAction(actionName: "Index");
        }

        public async Task<IActionResult> Delete(string routeId)
        {
            string message = String.Empty;
            var userMessage = new MessageVM();
            var routeDel = _routeServices.GetRoute(routeId);
            if (routeDel != null)
            {
                if (await _routeServices.DeleteRoute(routeDel))
                {
                    message = "Transport route has been deleted";
                    TempData["UserMessage"] = SystemUtilites.SendSystemNotification(NotificationType.Success, message);
                    return RedirectToAction(actionName: "Index");
                }
            }
            message = "Unknown error, please try again";
            TempData["UserMessage"] = SystemUtilites.SendSystemNotification(NotificationType.Error, message);
            return RedirectToAction(actionName: "Index");
        }

        public async Task<IActionResult> Edit(EditRouteViewModel model)
        {
            string message = String.Empty;
            var userMessage = new MessageVM();
            if (await _routeServices.EditRoute(model))
            {
                message = "The shipping route has adjusted information";
                TempData["UserMessage"] = SystemUtilites.SendSystemNotification(NotificationType.Success, message);
                return RedirectToAction(actionName: "Index");
            }
            message = "Unknown error, please try again";
            TempData["UserMessage"] = SystemUtilites.SendSystemNotification(NotificationType.Error, message);
            return RedirectToAction(actionName: "Index");
        }
    }
}