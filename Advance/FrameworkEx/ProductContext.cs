using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FrameworkEx
{
    internal class ProductContext:DbContext
    {

        public ProductContext()
        {

            

        }
       public ProductContext(DbContextOptions options):base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=mydata;Trusted_Connection=True;encrypt=false");
        }


        public DbSet<Product> Products { get; set; }
             

    }
}
