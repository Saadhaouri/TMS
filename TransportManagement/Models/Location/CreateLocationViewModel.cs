using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TransportManagement.Models.Location
{
    public class CreateLocationViewModel
    {
        private string _locationName;
        [Required(ErrorMessage = "Place name cannot be empty")]
        [MaxLength(ErrorMessage = "The maximum allowed length is 200 characters")]
        [Display(Name = "Place name")]
        public string LocationName { get => _locationName; set => _locationName = value; }
    }
}
