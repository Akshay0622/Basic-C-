using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class Vehicle
    {

        public static void main(string[] args)
        {
          
       


        }

        public abstract void run();
     

    }

    public class Car : Vehicle
    {
        public Car() {
            Vehicle b = new Bike();
            b.run();
        }
        public override void run()
        {
            Console.WriteLine("this car run on highway");

        }

    }
    public class Bike : Vehicle
    {

        public Bike()
        {

        }

        public override void run()
        {
            Console.WriteLine("This bike run on city road");
        }
    }
}

