using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TransportManagement.Models.Route
{
    public class EditRouteViewModel
    {
        private string _routeId;
        private string _departurePlaceId;
        private string _arrivalPlaceId;
        private int _distance;
        [Required(ErrorMessage = "Departure cannot be empty")]
        [Display(Name = "Starting Location")]
        public string DeparturePlaceId { get => _departurePlaceId; set => _departurePlaceId = value; }
        [Required(ErrorMessage = "Destination cannot be empty")]
        [Display(Name = "Destinations")]
        public string ArrivalPlaceId { get => _arrivalPlaceId; set => _arrivalPlaceId = value; }
        [Required(ErrorMessage = "Route length cannot be empty")]
        [Range(0, Int32.MaxValue, ErrorMessage = "Invalid value, please re-enter")]
        [Display(Name = "Route length")]
        public int Distance { get => _distance; set => _distance = value; }
        [Display(Name = "Active Status")]
        public string RouteId { get => _routeId; set => _routeId = value; }
    }
}
