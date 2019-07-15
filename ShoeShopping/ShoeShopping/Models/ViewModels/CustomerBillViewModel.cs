using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoeShopping.Models.ViewModels
{
    public class CustomerBillViewModel
    {
        public List<Bills> Bills { get; set; }
        public ApplicationUsers Users { get; set; }
    }
}
