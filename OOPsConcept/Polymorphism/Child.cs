using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal sealed class Child : Parent
    {
        public int a = 20;
        
        void display()
        {
            Console.WriteLine(a);

            Console.WriteLine(base.a);
            
            // base is a reference and it point to Base class's object 

        }
        public sealed override void acceptPayement()
        {
            Console.WriteLine("Accept Online , UPI  payements ");
        }

        // pass 3 command line arguments C C++ c#
        // for this , select debug menu=> debug properties => In command line arguments window 

        // string[] args =[C ,C++ ,c#]
        //                 0   1    2

        public static void Main(string[] args)
        {
	// Exception is runtime error . when exception occur programs gets terminated midway .To handle exception:-

	// Keep error-prone statements in try block and then when exception occur catch block will handle it .

            try
            {
                Console.WriteLine(args.Length);

                Console.WriteLine(args[1]);
            }
            catch 
            {
                Console.WriteLine("Exception Handled");
            }


            Parent c = new Child();
            c.acceptPayement();

            Child obj = new Child();
            obj.display();
        }
    }
}
