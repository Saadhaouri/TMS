using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TransportManagement.Models.Fuel;
using TransportManagement.Models.VehicleBrand;

namespace TransportManagement.Models.Vehicle
{
    public class EditVehicleViewModel
    {
        private int _vehicleId;
        private string _licensePlate;
        private string _vehicleName;
        private decimal _fuelConsumptionPerTone;
        private decimal _vehiclePayload;
        private string _specifications;
        private bool _isInUse;
        private bool _isAvailable;
        private int _fuelId;
        public int VehicleId { get => _vehicleId; set => _vehicleId = value; }
        [Required(ErrorMessage = "Vehicle license plate cannot be empty")]
        [MaxLength(15, ErrorMessage = "Maximum allowed length is 15 characters")]
        [Display(Name = "Vehicle license plate")]
        public string LicensePlate { get => _licensePlate; set => _licensePlate = value; }
        [Required(ErrorMessage = "Media name cannot be empty")]
        [Display(Name = "Media Name")]
        [MaxLength(100, ErrorMessage = "Maximum allowed length is 100 characters")]
        public string VehicleName { get => _vehicleName; set => _vehicleName = value; }
        [Required(ErrorMessage = "Fuel consumption quota cannot be empty")]
        [Range(typeof(decimal), "0.1", "32767", ErrorMessage = "Invalid value, please re-enter")]
        [Display(Name = "Fuel norm/ton of cargo (litre/km)")]
        public decimal FuelConsumptionPerTone { get => _fuelConsumptionPerTone; set => _fuelConsumptionPerTone = value; }
        [Required(ErrorMessage = "Maximum cargo payload cannot be empty")]
        [Range(typeof(decimal), "0.1", "32767", ErrorMessage = "Invalid value, please re-enter")]
        [Display(Name = "Maximum cargo weight (tons)")]
        public decimal VehiclePayload { get => _vehiclePayload; set => _vehiclePayload = value; }
        [Required(ErrorMessage = "Media brand cannot be empty")]
        [Display(Name = "Media Brand")]
        public string VehicleBrandId { get; set; }
        [MaxLength(1500, ErrorMessage = "Maximum specification allowed 1,500 characters")]
        [Display(Name = "Specifications")]
        public string Specifications { get => _specifications; set => _specifications = value; }
        [Display(Name = "Using?")]
        public bool IsInUse { get => _isInUse; set => _isInUse = value; }
        [Display(Name = "Owned?")]
        public bool IsAvailable { get => _isAvailable; set => _isAvailable = value; }
        public List<VehicleBrandViewModel> VehicleBrands { get; set; }
        public List<FuelViewModel> Fuels { get; set; }
        [Display(Name = "Fuel used")]
        public int FuelId { get => _fuelId; set => _fuelId = value; }
    }
}
