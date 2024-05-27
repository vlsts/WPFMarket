using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMarket.Models.Database.Entities
{
    internal class UserEntity
    {
        public int id { get; set; }
        public string name { get; set; }
        public string totp_secret_key { get; set; }
        public string role { get; set; }
        public bool active { get; set; }
    }
}
