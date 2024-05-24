using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkEx
{
    internal class ReadingBasedOnCondition
    {

        static void Main(string[] args)
        {


            ProductContext productContext = new ProductContext();


            try
            {
                List<Product> list = productContext.Products.Where(product => product.price>5).ToList();

                Console.WriteLine(list);

                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("No matching record found");
            }

        }

    }
}
