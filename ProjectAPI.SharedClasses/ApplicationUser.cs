using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWebAPI.SharedClasses
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [MinLength(4)]
        public string UserName { get; set; }
        [Required]
        [MinLength(4)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
