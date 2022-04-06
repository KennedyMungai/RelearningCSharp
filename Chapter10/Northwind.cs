using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Packt.Shared
{
    //This manages the connection to the database
    public class Northwind : DbContext
    {
        //These properties map to tables in the database
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Product>? Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (ProjectConstants.DatabaseProvider == "SqlServer")
            {
                string connection = "Data Source=.;Initial Catalog=Northwind;Trusted_Connection=true;MultipleActiveResultSets=true;";
                optionsBuilder.UseSqlServer(connection);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //An example of using Fluent API instead of attributes
            //to limit the length of a category name to 15
            modelBuilder.Entity<Category>()
                .Property(category => category.CategoryName)
                .IsRequired()                                           //Not null
                .HasMaxLength(15);

            //Global filter to remove discontinued products
            modelBuilder.Entity<Product>()
                .HasQueryFilter(p => !p.Discontinued);
        }
    }
}
