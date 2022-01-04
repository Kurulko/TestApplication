using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplication.ViewModels
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Enter your Email")]
        [EmailAddress]
        [Display(Name = "Write Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter your password")]
        [DataType(DataType.Password)]
        [Display(Name = "Write password")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Password mismatch")]
        [DataType(DataType.Password)]
        [Display(Name = "Repeat password")]
        public string ConfirmPassword { get; set; }
    }
}
