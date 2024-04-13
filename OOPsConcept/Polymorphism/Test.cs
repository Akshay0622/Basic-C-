using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Test
    {

	// having multiple methods with same name but different argument is called method overloading

        public static void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static void add(int a, int b, int c)
        {
            Console.WriteLine(a + b);

        }

        public  void Main(string[] args)
        {
            Test obj = new Test();

            Test.add(10, 2); // method calling

            Test.add(1, 2,3); // method calling

            // static method or static variable is called by class name directly .
        }
    }
}







