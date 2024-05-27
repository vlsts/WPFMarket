using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMarket.Models.Database.Entities
{
    [Table("loyalty_cards")]
    internal class LoyaltyCardEntity
    {
        [Key]
        [Column("card_number")]
        public string CardNumber { get; set; }
        [Column("points")]
        public decimal Points { get; set; }
    }
}
