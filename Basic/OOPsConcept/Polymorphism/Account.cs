using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Account
    {
        // global variables

        public int accno;
        public int balance; // instance variable / object variable / global variable

        // if global variable and local variable names are same , then use this .
       public Account(int accno, int balance)
        {
            this.accno = accno;
            this.balance = balance;
        }

        /*
          constructor is a special method , having same name like classname 
          constructor do not have any return type. Constructor initilize attributes 
         */

        public int deposit(int amount)
        {
            balance=balance+amount;

            return balance;
        }

        // balance=20000
        // amount=7000
        // tembal=13000
        public void withdraw(int amount)
        {
            int tembal = balance - amount;

            if (tembal < 5000)
            {
                Console.WriteLine("insufficient funds");

                return; // It ends function defination just like break ends execution of loop .
            }

            balance = tembal;
        }



        public void display()
        {
            Console.WriteLine("accno={0} and balance={1}",accno,balance);
        }

        /*
        public override string ToString() 
        {
            return "accno=" + accno + " and balance=" + balance;

        }
        */

    }
}
