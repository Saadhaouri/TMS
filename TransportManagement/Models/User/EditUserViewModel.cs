using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TransportManagement.Entities;
using TransportManagement.Models.Role;

namespace TransportManagement.Models.User
{
    public class EditUserViewModel
    {
        private string _userId;
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private string _existsAvatar;
        private IFormFile _avatar;
        private string _password;
        private string _confirmPassword;
        private string _email;
        private string _phoneNumber;
        private string _roleId;
        [Required(ErrorMessage = "Username cannot be blank")]
        [MaxLength(20, ErrorMessage = ("The maximum length of the username is 20"))]
        [Display(Name = "Name")]
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string MiddleName { get => _middleName; set => _middleName = value; }
        [Required(ErrorMessage = "They cannot be left blank")]
        [MaxLength(50, ErrorMessage = ("Their maximum length is 50"))]
        [Display(Name = "last name")]
        public string LastName { get => _lastName; set => _lastName = value; }
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get => _password; set => _password = value; }
        [Compare("Password", ErrorMessage = "Confirmation password is incorrect")]
        [Display(Name = "Confirm password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get => _confirmPassword; set => _confirmPassword = value; }
        public IFormFile Avatar { get => _avatar; set => _avatar = value; }
        [RegularExpression(@"(^[\w])+([\w._])*\@([\w{2,}\-])+(\.[\w]{2,4})$", ErrorMessage = "Incorrect email format")]
        public string Email { get => _email; set => _email = value; }
        [Required(ErrorMessage = "Mobile phone number cannot be blank")]
        [RegularExpression(@"(^0)+(3[2-9]|5[6|8|9]|7[0|6-9]|8[1-6|8-9]|9[0-4|6-9])+([0-9]{7})", ErrorMessage = "Incorrect mobile phone format in Morroco")]
        [Display(Name = "Phone Number ")]
        public string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
        [Required(ErrorMessage = "Permissions cannot be left blank")]
        [Display(Name = "Account Authorization")]
        public string RoleId { get => _roleId; set => _roleId = value; }
        public ICollection<RoleViewModel> Roles { get; set; }
        public string ExistsAvatar { get => _existsAvatar; set => _existsAvatar = value; }
        public string UserId { get => _userId; set => _userId = value; }
    }
}
