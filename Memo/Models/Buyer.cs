using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Memo.Models
{
    [Table("Buyer")]
    public class Buyer
    {
        [Key]
        public int RefId { get; set; }
        public int PoNo { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime PoDate { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime ExpectedDate { get; set; }
        public List<Supplier> Suppliers { get; set; }
        [StringLength(50, MinimumLength = 3,
        ErrorMessage = "Remark should be minimum 3 characters and a maximum of 50 characters")]
        [DataType(DataType.Text)]
        public string Remark { get; set; }
        public List<Item> Items { get; set; }
    }
}
