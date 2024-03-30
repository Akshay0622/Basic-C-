using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ArraysAdvance
{
    internal class TwoDarrays
    {

        static void Main(string[] args)
        {

            int[,] data = new int[3, 2] { { 10, 20 }, { 30, 40 }, { 50, 60 } };

            Console.WriteLine("data:" + data[0, 0]);
            Console.WriteLine("data:" + data[0, 1]);
            Console.WriteLine("data:" + data[1, 0]);
            Console.WriteLine("data:" + data[1, 1]);
            Console.WriteLine("data:" + data[2, 0]);
            Console.WriteLine("data:" + data[2, 1]);

            //Change Array Elements

            //We can also change the elements of a two-dimensional array. To change the element,
            //we simply assign a new value to that particular index. For example,

            data[0, 0] = 100;

            Console.WriteLine("new value [0,0] data:" + data[0, 0]);


            //Iterating C# Array using Loop

           // numbers.GetLength(0) - gives the number of rows in a 2D array
          //numbers.GetLength(1) - gives the number of elements in the row

            int[,] value = new int[2, 3] { { 1, 2, 30 }, { 7, 8, 9 } };

            for (int i = 0; i < value.GetLength(0); i++)
            {
                for (int j = 0; j <value.GetLength(1); j++)
                {
                    Console.Write(value[i, j]+" ");

                }
                Console.WriteLine();  
                


            }
        }
    }
}
