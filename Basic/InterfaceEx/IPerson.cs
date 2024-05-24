using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEx
{
    public interface IPerson
    {
        // Interface members declaration
         string Name { get; set; }
         int Age { get; set; }

        // Interface method declaration
         void DisplayInfo();
    }
}
