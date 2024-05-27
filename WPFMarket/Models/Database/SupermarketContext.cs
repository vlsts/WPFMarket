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
