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
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Enter your password")]
        public string Password { get; set; }
    }
}
