using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TransportManagement.Entities;
using TransportManagement.Models.Route;
using TransportManagement.Models.Vehicle;

namespace TransportManagement.Models.TransportInformation
{
    public class EditTransInfoViewModel
    {
        private string _transportId;
        private string _cargoTypes;
        private decimal _cargoTonnage;
        private decimal _advanceMoney;
        private decimal _returnOfAdvances;
        private double _dateCompletedUTC;
        private double _dateCompletedLocal;
        private bool _isCancel;
        private string _reasonCancel;
        private int _vehicleId;
        private string _routeId;
        private string _driverId;
        private string _note;

        public string TransportId { get => _transportId; set => _transportId = value; }
        [MaxLength(200)]
        [Display(Name = "Type of Goods")]
        public string CargoTypes { get => _cargoTypes; set => _cargoTypes = value; }
        [Range(typeof(decimal), "0", "20000")]
        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "Volume of goods (ton)")]
        public decimal CargoTonnage { get => _cargoTonnage; set => _cargoTonnage = value; }
        [Required(ErrorMessage = "If no advance, enter 0")]
        [Display(Name = "Advance amount (Dh)")]
        [Range(typeof(decimal), "0", "2000000000", ErrorMessage = "Advance amount does not exceed 2 billion VND")]
        public decimal AdvanceMoney { get => _advanceMoney; set => _advanceMoney = value; }
        [Required(ErrorMessage = "If the advance is not refunded, enter 0")]
        [Display(Name = "Advance refund amount (Dh)")]
        [Range(typeof(decimal), "0", "2000000000", ErrorMessage = "The amount of the advance refund does not exceed VND 2 billion")]
        public decimal ReturnOfAdvances { get => _returnOfAdvances; set => _returnOfAdvances = value; }
        [Display(Name = "Cancel")]
        public bool IsCancel { get => _isCancel; set => _isCancel = value; }
        [Display(Name = "Cancellation reason")]
        public string ReasonCancel { get => _reasonCancel; set => _reasonCancel = value; }
        [Display(Name = "Note")]
        public string Note { get => _note; set => _note = value; }
        [Display(Name = "Media selection")] 
        public int VehicleId { get => _vehicleId; set => _vehicleId = value; }
        [Display(Name = "Selection of shipping route")]
        public string RouteId { get => _routeId; set => _routeId = value; }
        [Display(Name = "Driver Selection")]
        public string DriverId { get => _driverId; set => _driverId = value; }
        public double DateCompletedUTC { get => _dateCompletedUTC; set => _dateCompletedUTC = value; }
        public double DateCompletedLocal { get => _dateCompletedLocal; set => _dateCompletedLocal = value; }

        public List<AppIdentityUser> Drivers { get; set; }
        public List<RouteViewModel> Routes { get; set; }
        public List<VehicleViewModel> Vehicles { get; set; }

    }
}
