using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMarket.Models.Database.Entities
{
    [Table("receipts")]
    internal class ReceiptEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("date")]
        public DateTime Date { get; set; }

        [Column("cashier_id")]
        public string CashierId { get; set; }
        [Column("card_number")]
        public string CardNumber { get; set; }
        [Column("total_price")]
        public decimal TotalPrice { get; set; }
        [Column("final_price")]
        public decimal FinalPrice { get; set; }

        [ForeignKey("UserEntity")]
        public UserEntity Cashier { get; set; }
    }
}
