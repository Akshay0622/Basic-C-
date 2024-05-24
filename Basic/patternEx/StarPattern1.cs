using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternEx
{
    internal class StarPattern1
    {
        /*StarPattern1


        *
        **
        ***


        1 
        1 2
        1 2 3



         */

        public static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <=i; j--)
                {
                    Console.Write("*");
                   // Console.Write(j);
                }
                Console.WriteLine("");

            }
        }
    }
}
