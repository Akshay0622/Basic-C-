using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class ArraysEx1
    {
        //find maximum element from an array
       public static void Main(string[] args)
        {

            int[] allvalue = { 10, 20, 30 };

            int maxvalue = allvalue[0];

            for (int i = 1; i < allvalue.Length; i++)
            {

                if (allvalue[i] > maxvalue) {

                    maxvalue = allvalue[i];
                }
            }
            Console.WriteLine("Max value:" + maxvalue);
        }
    }
}
