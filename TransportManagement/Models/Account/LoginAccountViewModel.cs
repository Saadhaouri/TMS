using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TransportManagement.Models.Account
{
    public class LoginAccountViewModel
    {
        private string _userName;
        private string _password;
        private bool _isRemember;
        [Display(Name = "user name")]
        [Required(ErrorMessage = "Username cannot be blank")]
        public string UserName { get => _userName; set => _userName = value; }
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password can not be blank")]
        [DataType(DataType.Password)]
        public string Password { get => _password; set => _password = value; }
        [Display(Name = "remember account")]
        public bool IsRemember { get => _isRemember; set => _isRemember = value; }
    }
}
