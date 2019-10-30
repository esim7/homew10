using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace hw_10
{
    public class Context : DbContext
    {
        private readonly string connectionString;
        public Context(string connectionString)
        {
            this.connectionString = connectionString;
            Database.Migrate();
        }
        public DbSet<Boss> Bosses { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<WorkOffice> WorkOffices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
