
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.SqlServer;
using ORM.Data.Model;
using System.Text.Json;
using System.Data.SqlClient;

namespace ORM.Data.Contexts
{
    public class CountryDbContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }

        public CountryDbContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-CPU5UM7;Initial Catalog=Countries;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
           modelBuilder.Entity<Country>().HasNoKey();
        }

    }
}
