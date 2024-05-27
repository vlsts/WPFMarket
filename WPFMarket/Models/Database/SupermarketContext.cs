using dotenv.net;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFMarket.Models.Database.Entities;

namespace WPFMarket.Models.Database
{
    internal class SupermarketContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<ProducerEntity> Producers { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<LoyaltyCardEntity> LoyaltyCards { get; set; }
        public DbSet<StockEntity> Stocks { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<ReceiptDiscountEntity> ReceiptDiscounts { get; set; }
        public DbSet<ReceiptEntity> Receipts { get; set; }
        public DbSet<ReceiptItemEntity> ReceiptItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var environmentVariables = DotEnv.Read();
            var connectionString =
                $"Host={environmentVariables["PGSQL_HOST"]};" +
                $"Port={environmentVariables["PGSQL_PORT"]};" +
                $"Database={environmentVariables["PGSQL_DB"]};" +
                $"Username={environmentVariables["PGSQL_USER"]};" +
                $"Password={environmentVariables["PGSQL_PASSWORD"]}";
            optionsBuilder.UseNpgsql(connectionString);
        }
    }
}
