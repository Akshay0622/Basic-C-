using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultithreadingEx
{
    public class Worker
    {

     public  void Rest() {
            Thread.Sleep(10000);

            Console.WriteLine("Worker on rest mode");

    }

        public  void Run()
        {
            Console.WriteLine("Worker on run mode ");


        }



        static void Main(string[] args)
        {

            ThreadStart treadstart = new ThreadStart(Rest);
            ThreadStart treadstart2 = new ThreadStart(Run);
            Thread thr = new Thread(treadstart);
            thr.Start();
            Thread thr1 = new Thread(treadstart2);
            thr1.Start();
        }

    }
}
