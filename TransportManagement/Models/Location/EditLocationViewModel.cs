using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TransportManagement.Models.Location
{
    public class EditLocationViewModel
    {
        private string _locationId;
        private string _locationName;

        public string LocationId { get => _locationId; set => _locationId = value; }
        [Required(ErrorMessage = "Place name cannot be left blank")]
        [Display(Name = "Place name")]
        public string LocationName { get => _locationName; set => _locationName = value; }
    }
}
