using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TransportManagement.Models.Fuel
{
    public class EditFuelViewModel
    {
        private int _fuelId;
        private string _fuelName;
        private decimal _fuelPrice;
        [Required(ErrorMessage = "Fuel name cannot be blank")]
        [Display(Name = "Fuel name")]
        [MaxLength(200)]
        public string FuelName { get => _fuelName; set => _fuelName = value; }
        [Required(ErrorMessage = "Fuel prices cannot be left blank")]
        [Column(TypeName = "decimal(18,0)")]
        [Range(typeof(decimal), "0.1", "100000", ErrorMessage = "Value does not match")]
        [Display(Name = "Raw material price/liter")]
        public decimal FuelPrice { get => _fuelPrice; set => _fuelPrice = value; }
        public int FuelId { get => _fuelId; set => _fuelId = value; }
    }
}
