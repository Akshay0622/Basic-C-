using FrameworkEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkEx
{
   
    internal class UpdateEx
    {

      public static void Main(string[] args)
{


            ProductContext productContext = new ProductContext();

            Console.WriteLine("Enter name of product :- ");
            String name = Console.ReadLine();

            try
            {
                Product product = productContext.Products.Single(product => product.name == name);

                product.price = 200;

                productContext.SaveChanges();

                Console.WriteLine(product);
            }
            catch (Exception ex)
            {

                Console.WriteLine("No matching record found");
            }
        }
    }
}

