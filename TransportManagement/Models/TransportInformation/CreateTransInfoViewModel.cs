using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TransportManagement.Entities;
using TransportManagement.Models.Route;
using TransportManagement.Models.Vehicle;

namespace TransportManagement.Models.TransportInformation
{
    public class CreateTransInfoViewModel
    {
        private string _cargoTypes;
        private decimal _advanceMoney;
        private string _note;
        private int _vehicleId;
        private string _routeId;
        private string _driverId;
        [MaxLength(200)]
        [Display(Name = "Type of Goods")]
        public string CargoTypes { get => _cargoTypes; set => _cargoTypes = value; }
        [Required(ErrorMessage = "If no advance, enter 0")]
        [Display(Name = "Advance amount (VND)")]
         [Range(typeof(decimal), "0", "2000000000", ErrorMessage = "The maximum advance amount is not more than 2 billion VND")]
        public decimal AdvanceMoney { get => _advanceMoney; set => _advanceMoney = value; }
        [Display(Name = "Note")]
        public string Note { get => _note; set => _note = value; }
        [Display(Name = "Media selection")]
        public int VehicleId { get => _vehicleId; set => _vehicleId = value; }
        [Display(Name = "Selection of shipping route")]
        public string RouteId { get => _routeId; set => _routeId = value; }
        [Display(Name = "Driver Selection")]
        public string DriverId { get => _driverId; set => _driverId = value; }
        public List<AppIdentityUser> Drivers { get; set; }
        public List<RouteViewModel> Routes { get; set; }
        public List<VehicleViewModel> Vehicles { get; set; }
    }
}
