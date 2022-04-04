using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;                //DbContext, DbContextOptionsBuilder

using static System.Console;

namespace Packt.Shared
{
    //This manages the connection to the database
    public class Northwind : DbContext
    {
        //These properties map tables to the database
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Product>? Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //An example of using Fluent API instead of attributes
            //to limit the length of the category name to 15
            modelBuilder.Entity<Category>()
                .Property(category => category.CategoryName)
                .IsRequired()                                               //Not null
                .HasMaxLength(15);
        }
    }
}
