using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMarket.Models.Database.Entities
{
    [Table("receipt_discount")]
    internal class ReceiptDiscountEntity

    {
        [Key]
        [Column("discount_code")]
        public string DiscountCode { get; set; }

        [Column("receipt_id")]
        public string ReceiptId { get; set; }
        [Column("discount_percent")]
        public int DiscountPercent { get; set; }
        [ForeignKey("ProductEntity")]
        [Column("product_id")]
        public int ProductId { get; set; }
        [Column("start_date")]
        public DateTime StartDate { get; set; }
        [Column("end_date")]
        public DateTime EndDate { get; set; }
        [Column("active")]
        public bool Active { get; set; }

        [ForeignKey("ReceiptEntity")]
        public ReceiptEntity Receipt { get; set; }
        public ProductEntity Product { get; set; }
    }
}
