using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMarket.Models.Database.Entities
{
    [Table("producers")]
    internal class ProducerEntity
    {
        [Key]
        [Column("name")]
        public string Name { get; set; }
        [Column("country")]
        public string Country { get; set; }
        [Column("active")]
        public string Active { get; set; }
    }
}
