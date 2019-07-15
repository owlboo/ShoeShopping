using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoeShopping.Models
{
    public class Bills
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name ="User Name")]
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual ApplicationUsers Users { get; set; }
        public DateTime BillDate { get; set; }
        public DateTime BillTime { get; set; }
        public double TotalPrice { get; set; }
        public bool IsPaid { get; set; }
    }
}
