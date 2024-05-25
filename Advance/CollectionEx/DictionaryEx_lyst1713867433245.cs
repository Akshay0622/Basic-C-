using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class DictionaryEx
    {

        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            dictionary.Add(1, "x");

            //  dictionary.Add("x", 1);


            // Dictionary is generic version of hashtable

            bool answer = dictionary.ContainsKey(1);

            Console.WriteLine(answer);


            // String s="shree";

            // key    value

            // char    int

            //  s      1
            //  h      1
            //  r      1
            //  e      2

            // Write a program to count frequency of each character in a given string



        }
    }
}