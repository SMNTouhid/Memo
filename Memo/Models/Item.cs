using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Memo.Models
{
    [Table("Item")]
    public class Item
    {
        [Key]
        public int ItemId { get; set; }
        [Display(Name ="Item Name")]
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public int Rate { get; set; }
        public Buyer Buyer { get; set; }
    }
}
