using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoeShopping.Models
{
    public class ProductSelectedForBill
    {
        public int Id { get; set; }
        public int BillId { get; set; }
        [ForeignKey("BillId")]
        public virtual Bills Bills { get; set; }

        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Products Products { get; set; }

        public int Quantity { get; set; }

    }
}
