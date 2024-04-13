using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Parent
    {
        public int a = 10;

        public virtual void acceptPayement()
        {
            Console.WriteLine("Accept cash payements ");
        }
    }
}
