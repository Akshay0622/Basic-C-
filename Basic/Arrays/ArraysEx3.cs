using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{

    /// <summary>
    /// find even no from  given array
    /// </summary>
    /// int []a={1,2,3,4,5,6,7,8,9,10}
    internal class ArraysEx3    {


        public static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };


            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)
                {
                    Console.WriteLine("num is even:" + num[i]);
                }
            }
        }

    }
}
