using System;

namespace NastedLoopsex
{
    internal class Program
    {
        static void Main(string[] args)
        /*
                {
                    DisplaySolution();
                }

                public static void DisplaySolution()
                {

                    int i = 0;
                    int j = 0;

                    for(i = 0; i < 10; i++) {

                        for (j = 1; j < 10; j++)
                            {
                            Console.WriteLine($"{i}x{j}={i*j}");
                            }
                    Console.WriteLine("new table:");

                    }
                }
            }
        }
        */
 // perfect number :


        /*   {

               Console.WriteLine("following are perfect no");
               int n = 6; int sum = 0;

               for (int i = 0; i < 6; i++)
               {
                   if (n % i== 0)
                       sum = sum + i;
               }
               if (sum == n)
               {
                   Console.WriteLine(n + "Is a perfect number");
               }
               else
               {
                   Console.WriteLine(n + "Is not a perfect number");
               }

           }
        */


//Amstroong number


        { 

            int num = 407;
            int len;

            // Function to get order(length)
            len = Order(num);

            // Check if Armstrong
            if (IsArmstrong(num, len))
                Console.WriteLine(num + " is armstrong");
            else
                Console.WriteLine(num + " is not armstrong");
        }

        static int Order(int x)
        {
            int len = 0;
            while (x != 0)
            {
                len++;
                x = x / 10;
            }
            return len;
        }

        static bool IsArmstrong(int num, int len)
        {
            int sum = 0, temp, digit;
            temp = num;

            // Loop to extract digit, find power & add to sum
            while (temp != 0)
            {
                // Extract digit
                digit = temp % 10;

                // Add power to sum
                sum = sum + (int)Math.Pow(digit, len);
                temp /= 10;
            }

            return num == sum;
        }
    }
}



