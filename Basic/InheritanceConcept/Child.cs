using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConcept
{
    internal class Child : Parent
    {
        public Child()
        {
            Console.WriteLine("Child class's constructor");

        }
        public void m2()
        {
            Console.WriteLine("Child class's method");
        }
    }
}

