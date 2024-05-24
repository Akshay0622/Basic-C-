using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternEx
{
    internal class StarPattern3
    {
        /*StarPattern3

            *
         *  *
      *  *  *

           3
         2 3
       1 2 3

condition- 2 space than value printed
           1 space than value printed
           no space thn value printed

         we can use  if else in for loop 
         */

        public static void Main(string[] args)
        {
            for (int i = 1; i <=3; i++)
            {
                for (int j = 1; j <=3; j++)
                {
                    if (j<=3-i)
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                   
                }
                Console.WriteLine("");

            }
        }
    }
}
