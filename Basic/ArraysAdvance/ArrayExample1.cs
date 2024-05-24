using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAdvance
{
    //Find sum of each row from 2d array

    //Find min number of each row from 2d array
    internal class ArrayExample
    {


    }
}
/*
    public static void Main(string[] args)
    {
            int[,] a = new int[2,2];

            a[0,0] = 10;
            a[0,1] = 25;
            a[1,0] = 15;
            a[1,1] = 20;


           

         //   int minvalue = int.MinValue;
        //    int maxvalue = int.MinValue;
            for (int i = 0; i < a.GetLength(0); i++)

            {
                int min = a[i, 0];
                int sum = 0;
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    if (a[i,j] < min)
                    {
                        min = a[i, j];
                    }
                    
                    sum += a[i,j];
                }

                Console.WriteLine("Sum of row {0}: {1}", i + 1,sum);
                Console.WriteLine("Minimum number of row {0}: {1}", i + 1, min); // Print the minimum number of current row

            }
            
                Console.WriteLine();
            }
    }
    }

*/