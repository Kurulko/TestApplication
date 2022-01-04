using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplication.Models
{
    public class User : IdentityUser
    {
        public List<Test> Tests { get; set; }
    }
}
