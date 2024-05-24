using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class TestAccount
    {

       public static void Main(string[] args)
        {
            Account account1 = new Account(101, 5000);

            // account1 ===> [accno=101  balance=5000  display() , withdraw() , deposit() ] Account class's object
                        
            account1.deposit(5000);

            account1.display();


            account1.withdraw(7000);

            account1.display();


            /*
            Console.WriteLine(account1.accno);

            Console.WriteLine(account1.balance);

            
            Console.WriteLine(account1.ToString());

            Console.WriteLine(account1);
            */







        }
    }
}
