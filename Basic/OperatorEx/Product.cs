using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorEx
{
    internal class Product
    {
 {
        int pid;

        String name;

        int price;

        public Product(int pid, String name, int price)
        {
            this.pid = pid;
            this.name = name;
            this.price = price;

        }

        public override string ToString()
        {
            return pid + ":" + name + ":" + price;

        }

        public static bool operator ==(Product p1, Product p2)
        {
            if (p1.pid == p2.pid && p2.name.Equals(p2.name) && p1.price == p2.price)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Product p1, Product p2)
        {
            if (p1.pid == p2.pid && p2.name.Equals(p2.name) && p1.price == p2.price)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}



    }
}
