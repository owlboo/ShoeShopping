using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoeShopping.Models.ViewModels
{
    public class ProductsViewModel
    {
        public Products Products { get; set; }
        public IEnumerable<CategoryProduct> CategoryProducts { get; set; }
        public IEnumerable<ProductTags> ProductTags { get; set; }
    }
}
