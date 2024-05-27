using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMarket.Models.Database.Entities
{
    [Table("stocks")]
    internal class StockEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [ForeignKey("ProductEntity")]
        [Column("product_id")]
        public string BarcodeId { get; set; }
        [Column("quantity")]
        public int Quantity { get; set; }
        [Column("acquisition_price")]
        public decimal AcquisitionPrice { get; set; }
        [Column("acquisition_date")]
        public DateTime AcquisitionDate { get; set; }
        [Column("expiration_date")]
        public DateTime ExpirationDate { get; set; }
        [Column("active")]
        public bool Active { get; set; }

        public ProductEntity Product { get; set; }
    }
}
