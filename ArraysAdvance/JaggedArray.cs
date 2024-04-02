using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAdvance
{
    internal class JaggedArray
    {

        /*Points
         * 
        C# Jagged Array
                         In C#, a jagged array consists of multiple arrays as its element.
                         However, unlike multidimensional arrays, each array inside a jagged array 
                         can be of different sizes.

        C# Jagged Array Declaration
                                   Here's a syntax to declare a jagged array in C#.

                          example-
                          dataType[ ][ ] nameOfArray = new dataType[rows][ ];


        */
        static void Main(string[] args)
        {

            int[][] jaggedArray = {
         new int[] {1, 3, 5},
         new int[] {2, 4},
      };

        // print elements of jagged array
        Console.WriteLine("jaggedArray[1][0]: " + jaggedArray[1][0]);
     Console.WriteLine("jaggedArray[1][1]: " + jaggedArray[1][1]);

     Console.WriteLine("jaggedArray[0][2]: " + jaggedArray[0][2]);

     Console.ReadLine();
    }
}
}

