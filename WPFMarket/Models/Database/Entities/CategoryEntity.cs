using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMarket.Models.Database.Entities
{
    [Table("categories")]
    internal class CategoryEntity
    {
        [Key]
        [Column("name")]
        public string Name { get; set; }
        [Column("liquidation_discount")]
        public int LiquidationDiscount { get; set; }

        [Column("active")]
        public bool Active { get; set; }

    }
}
