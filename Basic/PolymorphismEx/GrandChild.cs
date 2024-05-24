using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismEx
{
    internal class GrandChild : Child
    {
        public override void acceptPayement()
        {
            Console.WriteLine("No Payement");
        }
    }
}
