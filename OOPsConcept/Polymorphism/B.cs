using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    //class B is a child class of class A 

    // parent class / base class  / super class
    // child class /  derived class / sub class

    internal class B : A
    {
        void m2()
        {
            Console.WriteLine("Child class's method");
        }

        B()
        {
            // child class's constructor calls parent class's constructor  

            Console.WriteLine("Child class's constructor");

        }

        // static method is called using class name
        static void show()
        {
            Console.WriteLine("I am static method");
        }
        public static void Main(string[] args)
        {
            // reference of parent can refer to object of child class

            B obj = new B();

            obj.m1(); // non-static method is called using reference.

            obj.m2();

            // using reference of parent , we can call only parent class's method 

            B.show(); // calling static method using class name
           
        }

    }
}
