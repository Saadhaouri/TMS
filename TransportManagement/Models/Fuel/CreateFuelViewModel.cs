using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TransportManagement.Models.Fuel
{
    public class CreateFuelViewModel
    {
        private string _fuelName;
        private decimal _fuelPrice;
        [Required(ErrorMessage = "Fuel name cannot be blank")]
        [Display(Name = "Fuel name")]
        [MaxLength(200, ErrorMessage = "Fuel name should not exceed 200 characters")]
        public string FuelName { get => _fuelName; set => _fuelName = value; }
        [Required(ErrorMessage = "Fuel prices cannot be left blank")]
        [Column(TypeName = "decimal(18,0)")]
        [Range(typeof(decimal), "0.1", "100000", ErrorMessage = "Value does not match")]
        [Display(Name = "Raw material price/liter")]
        public decimal FuelPrice { get => _fuelPrice; set => _fuelPrice = value; }
    }
}
