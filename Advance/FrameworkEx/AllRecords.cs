using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkEx
{
    internal class AllRecords
    {

        static void Main(string[] args)
        {


            ProductContext productContext = new ProductContext();

            productContext.Products.ToList().ForEach(p => { Console.WriteLine(p); });

        }

    }
 }
