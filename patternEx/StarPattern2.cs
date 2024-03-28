using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternEx
{
    internal class StarPattern2

    {
        /*StarPattern1

        ***
        **
        *

        1 2 3
        1 2
        1



         */

        public static void Main(string[] args)
        {
            for (int i = 3; i >=1; i--)
            {
                for (int j = 1; j <=i; j++)
                {
                    // Console.Write("*");
                    Console.Write(j);
                }
                Console.WriteLine("");

            }
        }
    }
}
