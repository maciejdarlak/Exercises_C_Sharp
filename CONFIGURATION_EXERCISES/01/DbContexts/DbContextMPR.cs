using System;
using System.Collections.Generic;
using System.Text;
using _01.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;


namespace _01.DbContexts
{
    public class DbContextMPR : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseOracle("User Id = mpr; Password = ....; Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = ....)(PORT = ....))) (CONNECT_DATA = (SERVICE_NAME = ....)))");
            optionsBuilder.LogTo(msg => System.Diagnostics.Debug.WriteLine(msg), LogLevel.Information);
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("MPR");
        }

        public virtual DbSet<MP> MEAUSERMENT_POINTS { get; set; }
    }
}
