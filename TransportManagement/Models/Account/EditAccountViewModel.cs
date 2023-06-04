using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TransportManagement.Models.Account
{
    public class EditAccountViewModel
    {
        private string _accountId;
        private string _userName;
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private string _password;
        private string _newPassword;
        private string _confirmNewPassword;
        private string _avatar;
        private string _email;
        private string _phoneNumber;
        [Display(Name = "UserName")]
        public string UserName { get => _userName; set => _userName = value; }
        [Display(Name = "Name")]
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string MiddleName { get => _middleName; set => _middleName = value; }
        [Display(Name = "last name")]
        public string LastName { get => _lastName; set => _lastName = value; }
        public string Avatar { get => _avatar; set => _avatar = value; }
        public string Email { get => _email; set => _email = value; }
        [Display(Name = "Mobile phone")]
        public string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
        public string FullName => $"{_lastName} {_firstName}";
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get => _password; set => _password = value; }
        [Display(Name = "A new password")]
        [DataType(DataType.Password)]
        public string NewPassword { get => _newPassword; set => _newPassword = value; }
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "Confirmation password is incorrect")]
        [DataType(DataType.Password)]
        public string ConfirmNewPassword { get => _confirmNewPassword; set => _confirmNewPassword = value; }
        public string AccountId { get => _accountId; set => _accountId = value; }
    }
}
