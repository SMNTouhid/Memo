using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Memo.Models
{
    [Table("Supplier")]
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }
        [Display(Name ="Supplier Name")]
        public string SupplierName { get; set; }
        public Buyer Buyer { get; set; }
    }
}
