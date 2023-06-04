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
    public class DetailTransInfoViewModel
    {
        private string _transportId;
        private string _cargoTypes;
        private decimal _cargoTonnage;
        private decimal _advanceMoney;
        private decimal _returnOfAdvances;
        private bool _isCompleted;
        private double _dateCompletedLocal;
        private double _dateStartLocal;
        private bool _isCancel;
        private string _reasonCancel;
        private int _vehicleId;
        private string _routeId;
        private string _driverId;
        private string _note;

        public string TransportId { get => _transportId; set => _transportId = value; }
        [Display(Name = "Type of Goods")]
        public string CargoTypes { get => _cargoTypes; set => _cargoTypes = value; }
        [Display(Name = "Volume of goods")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal CargoTonnage { get => _cargoTonnage; set => _cargoTonnage = value; }
        [Display(Name = "Advance amount (VND)")]
        public decimal AdvanceMoney { get => _advanceMoney; set => _advanceMoney = value; }
        [Display(Name = "Advance refund amount (VND)")]
        public decimal ReturnOfAdvances { get => _returnOfAdvances; set => _returnOfAdvances = value; }
        [Display(Name = "Done")]
        public bool IsCompleted { get => _isCompleted; set => _isCompleted = value; }
        [Display(Name = "Cancel")]
        public bool IsCancel { get => _isCancel; set => _isCancel = value; }
        [Display(Name = "Cancellation reason")]
        public string ReasonCancel { get => _reasonCancel; set => _reasonCancel = value; }
        [Display(Name = "Note")]
        public string Note { get => _note; set => _note = value; }
        [Display(Name = "Media")]
        public int VehicleId { get => _vehicleId; set => _vehicleId = value; }
        [Display(Name = "Transport route")]
        public string RouteId { get => _routeId; set => _routeId = value; }
        [Display(Name = "Drive")]
        public string DriverId { get => _driverId; set => _driverId = value; }
        [Display(Name = "End Date")]
        public double DateCompletedLocal { get => _dateCompletedLocal; set => _dateCompletedLocal = value; }
        [Display(Name = "Start Date")]
        public double DateStartLocal { get => _dateStartLocal; set => _dateStartLocal = value; }

        public List<AppIdentityUser> Drivers { get; set; }
        public List<RouteViewModel> Routes { get; set; }
        public List<VehicleViewModel> Vehicles { get; set; }
    }
}
