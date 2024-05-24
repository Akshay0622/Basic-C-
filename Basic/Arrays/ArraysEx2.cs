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

//second max value
            int[] allvalue = { 10, 40, 50, 30, 60, 70 };


            int maxvalue = int.MinValue;
            int secondMaxvalue = int.MinValue;
            Console.WriteLine("we are checking min value : "+ int.MinValue);
            
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
