using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoeShopping.Models
{
    public class ApplicationUsers:IdentityUser
    {
        [Display(Name="User")]
        public string Name { get; set; }
        public string Address { get; set; }
        public string ShippingAddress { get; set; }
        [NotMapped]
        public bool isSuperAdmin { get; set; }
        
    }
}
