using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class ArraysEx2
    { public static void Main(string[] args)
        {

            int[] allvalue = { 40, 40, 40, 40, 40, 40 };


            int maxvalue = int.MinValue;
            int secondMaxvalue = int.MinValue;

            for (int i = 0; i < allvalue.Length; i++)
            {
                if (allvalue[i] > maxvalue)
                {
                    secondMaxvalue = maxvalue;
                    maxvalue = allvalue[i];
                }
                else if (allvalue[i] > secondMaxvalue && allvalue[i] != maxvalue)
                {

                    secondMaxvalue = allvalue[i];
                }
            }

                Console.WriteLine("2nd max value:" + secondMaxvalue);
         }
    }
}
