﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMarket.Models.Database.Entities
{
    [Table("users")]
    internal class UserEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("username")]
        public string Name { get; set; }
        [Column("totp_secret_key")]
        public string TOTPSecretKey { get; set; }
        [Column("role")]
        public string Role { get; set; }
        [Column("active")]
        public bool Active { get; set; }
    }
}
