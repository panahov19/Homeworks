using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;



namespace ORM_project.Model
{
    public class CountryDbContext :DbContext
    {
        public DbSet<Country> Countries { get; set; }

        public CountryDbContext()
        {

        }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            ConfigurationBuilder builder = new ConfigurationBuilder(); 

            builder.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            string connectionString = configuration.GetConnectionString("LocalConnection");

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
