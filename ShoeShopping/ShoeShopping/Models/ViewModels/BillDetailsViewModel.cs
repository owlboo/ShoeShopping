using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoeShopping.Models.ViewModels
{
    public class BillDetailsViewModel
    {
        public Bills Bills { get; set; }
        public ApplicationUsers Users { get; set; }
        public List<Products> Products { get; set; }
    }
}
