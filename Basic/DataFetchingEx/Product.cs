using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFetchingEx
{
    public class Product
    {
        public int pId;
        public string name;
        public double price;
        public  string category;

        public Product() { }
        public Product(int PID,string Name,double Price, string Category)
        {
            this.pId = PID;
            this.name = Name;
            this.price = Price;
            this.category = Category;

        }

        public  static void GetProducts(string ccategory, Product[] products)
        {

            foreach (var p in products)
            {
                if (p.category == ccategory)
                {
                    Console.WriteLine(p);
                }

            }
        }

        public override string ToString()
        {

            Console.WriteLine();
             return $"Product: {name}, PID: {pId} Price:{price} Category:{category}";
        }




    }
}

