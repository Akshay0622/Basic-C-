using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class HashTableEx
    {

        static void Main(string[] args)
        {

            // Hashtable do not maitain insertion order

            Hashtable hashtable = new Hashtable();

            hashtable.Add(1, "shree");// Add(key , value)

            hashtable.Add(2, "akshay");

            Console.WriteLine(hashtable);

            
            ICollection collection=hashtable.Keys;  // [1,2] collection

            foreach (var key in collection)
            {
                var value=hashtable[key]; // hashtable[1] will give shree i.e value associated with key

                Console.WriteLine(key + " " + value);
            }


            //hashtable.Add(1, "krutika"); // It will throw exception as key 1 is already present

            Console.WriteLine(hashtable);

            hashtable[1] = "kamal";

            Console.WriteLine(hashtable[1]);


            // In Hashtable treat key as index . In array , we have integer index
            // In Hashtable , index can be non-integer also
        
        
            Hashtable hashtable1=new Hashtable();
            hashtable1.Add("shree", 87677667686);
            hashtable1.Add("manoj", 57655757578);

            // here key is string type and key is like index only.

        }



    }
}
