using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TransportManagement.Models.VehicleBrand
{
    public class CreateVehicleBrandViewModel
    {
        private string _brandName;
        [Required(ErrorMessage = "Vehicle brand name cannot be left blank")]
        [Display(Name = "Car brand")]
        [MaxLength(30, ErrorMessage = "The allowed length is 30 characters")]
        public string BrandName { get => _brandName; set => _brandName = value; }
    }
}
