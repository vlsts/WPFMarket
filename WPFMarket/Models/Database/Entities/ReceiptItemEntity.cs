using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMarket.Models.Database.Entities
{
    [Table("receipt_items")]
    internal class ReceiptItemEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [ForeignKey("ReceiptEntity")]
        [Column("receipt_id")]
        public int ReceiptId { get; set; }
        [ForeignKey("ProductEntity")]
        [Column("product_id")]
        public string? ProductId { get; set; }
        // liquidation, loyalty points, coupon discount
        [Column("item_type")]
        public string ItemType { get; set; }
        [Column("price")]
        public decimal Price { get; set; }
        [Column("quantity")]
        public int Quantity { get; set; }
        [Column("total_price")]
        public decimal TotalPrice { get; set; }

        public ReceiptEntity Receipt { get; set; }
        public ProductEntity Product { get; set; }
    }
}
