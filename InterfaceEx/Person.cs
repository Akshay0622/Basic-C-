using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InterfaceEx
{
    public class Person : IPerson
    {
        // Properties implementation
        public string Name { get; set; }
        public int Age { get; set; }

        // Method implementation
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
