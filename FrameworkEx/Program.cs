using Microsoft.EntityFrameworkCore;

namespace FrameworkEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            

            ProductContext productContext=new ProductContext();



            Product product = new Product();
            product.pid = 1;
            product.name = "pen";
            product.price = 100;

            productContext.Products.Add(product);


            int count= productContext.SaveChanges();


           Console.WriteLine(count);

           Console.WriteLine("Record added");


        }
    }
}
