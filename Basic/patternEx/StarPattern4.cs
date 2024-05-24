using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternEx
{
    internal class StarPattern4
    {


        /*
         
Star Pattern-4

             * 
          *
       *

Star pattern-5

        *
          *
            *



  */
        public static void Main(string[] args)
        { 
        for (int i = 1; i <= 3; i++)
{


   // for (int j = 3; j >= i; j--)                  //pattern-4

     for (int j=1; j<=3; j++)                      // pattern -5
     {
         if (i == j)
             Console.Write("*");
         else
             Console.Write(" ");
     }

    Console.WriteLine();
    }
}
}
}
