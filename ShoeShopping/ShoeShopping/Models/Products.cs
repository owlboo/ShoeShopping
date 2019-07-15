using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoeShopping.Models
{
    public class Products
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public double Price { get; set; }
        public double New_Price { get; set; }
        public bool Available { get; set; }
        public int Discount { get; set; }
        public string Material { get; set; }
        public string Origin { get; set; }
        public string Gender { get; set; }
        public int Size { get; set; }
        public string Image { get; set; }
        [Display(Name ="Category")]
        public int CategoryProductId { get; set; }
        [ForeignKey("CategoryProductId")]
        public virtual CategoryProduct CategoryProducts { get; set; }

        [Display(Name ="Product Tag")]
        public int ProductTagId { get; set; }
        [ForeignKey("ProductTagId")]
        public virtual ProductTags ProductTags { get; set; }
    }
}
