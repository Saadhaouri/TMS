using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TransportManagement.Models.Fuel;
using TransportManagement.Models.VehicleBrand;

namespace TransportManagement.Models.Vehicle
{
    public class CreateVehicleViewModel
    {
        private string _licensePlate;
        private string _vehicleName;
        private decimal _fuelConsumptionPerTone;
        private decimal _vehiclePayload;
        private string _specifications;
        private bool _isInUse;
        private bool _isAvailable;
        private int _fuelId;
        [Required(ErrorMessage = "Vehicle license plates cannot be left blank")]
        [MaxLength(15, ErrorMessage = "The maximum allowed length is 15 characters")]
        [Display(Name = "Vehicle license plate")]
        public string LicensePlate { get => _licensePlate; set => _licensePlate = value; }
        [Required(ErrorMessage = "The vehicle name cannot be empty")]
        [Display(Name = "Vehicle name")]
        [MaxLength(100, ErrorMessage = "The maximum allowed length is 100 characters")]
        public string VehicleName { get => _vehicleName; set => _vehicleName = value; }
        [Required(ErrorMessage = "Fuel consumption norms cannot be left blank")]
        [Range(typeof(decimal),"0.1","32767", ErrorMessage = "The value is not correct, please re-enter it")]
        [Display(Name = "Fuel norm/ton of cargo (litre/km)")]
        public decimal FuelConsumptionPerTone { get => _fuelConsumptionPerTone; set => _fuelConsumptionPerTone = value; }
        [Required(ErrorMessage = "Maximum cargo payload cannot be empty")]
        [Range(typeof(decimal), "0.1", "32767", ErrorMessage = "Invalid value, please re-enter")]
        [Display(Name = "Maximum cargo tonnage (tons)")]
        public decimal VehiclePayload { get => _vehiclePayload; set => _vehiclePayload = value; }
        [Required(ErrorMessage = "The vehicle mark cannot be left blank")]
        [Display(Name = "Vehicle brand")]
        public string VehicleBrandId { get; set; }
        [MaxLength(1500, ErrorMessage = "Maximum allowable specification 1,500 characters")]
        [Display(Name = "Specifications")]
        public string Specifications { get => _specifications; set => _specifications = value; }
        [Display(Name = "Using?")]
        public bool IsInUse { get => _isInUse; set => _isInUse = value; }
        [Display(Name = "Owning?")]
        public bool IsAvailable { get => _isAvailable; set => _isAvailable = value; }
        public List<VehicleBrandViewModel> VehicleBrands { get; set; }
        public List<FuelViewModel> Fuels { get; set; }
        [Display(Name = "Fuel used")]
        public int FuelId { get => _fuelId; set => _fuelId = value; }
    }
}
