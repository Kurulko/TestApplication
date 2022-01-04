using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplication.ViewModels
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Enter your Email")]
        [EmailAddress]
        [Display(Name = "Write Email")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Enter your password")]
        [Display(Name = "Write password")]
        public string Password { get; set; }
    }
}
