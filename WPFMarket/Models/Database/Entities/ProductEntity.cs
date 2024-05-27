using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMarket.Models.Database.Entities
{
    [Table("products")]
    internal class ProductEntity
    {
        [Key]
        [Column("barcode")]
        public string Barcode { get; set; }
        [Column("name")]
        public string name { get; set; }
        [Column("unit_of_measurement")]
        public string UnitOfMeasurement { get; set; }
        [Column("price")]
        public decimal Price { get; set; }
        [Column("discounted_price")]
        public bool Discounted { get; set; }

        [ForeignKey("ProducerEntity")]
        [Column("producer_id")]
        public string ProducerId { get; set; }
        [ForeignKey("CategoryEntity")]
        [Column("category_id")]
        public string CategoryId { get; set; }
        [Column("active")]
        public bool Active { get; set; }

        public CategoryEntity Category { get; set; }
        public ProducerEntity Producer { get; set; }
    }
}
