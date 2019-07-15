using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoeShopping.Models.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Products> Products { get; set; }
        public Bills Bills { get; set; }
    }
}
