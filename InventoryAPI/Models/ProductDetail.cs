using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryAPI.Models
{
    public class ProductDetail
    {
        [Key]
        public int ProductDetailID { get; set; }

        [Column(TypeName ="nvarchar(100)")]
        public string ProductName { get; set; }

        [Column(TypeName = "int")]
        public int Quantity { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime DateCreated { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime UpdatedCreated { get; set; }
    }
}
