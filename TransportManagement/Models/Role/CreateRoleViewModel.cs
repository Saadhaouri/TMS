using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TransportManagement.Models.Role
{
    public class CreateRoleViewModel
    {
        private string _roleName;
        private byte _rolePriority;
        [Required(ErrorMessage = "Permission name cannot be empty")]
        [MaxLength(30, ErrorMessage = "Permission name cannot exceed 30 characters")]
        [Display(Name = "Permission Name")]
        public string RoleName { get => _roleName; set => _roleName = value; }
        [Required(ErrorMessage = "Permission hierarchy cannot be empty")]
        [Range(typeof(byte), "0", "20", ErrorMessage = "Permission level cannot exceed 20")]
        [Display(Name = "Level of permissions")]
        public byte RolePriority { get => _rolePriority; set => _rolePriority = value; }
    }
}
