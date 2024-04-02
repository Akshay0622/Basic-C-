using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceArraysEx
{
/*
    internal class SearchEx
    {
        public static int LinearSearch(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    return i; // Return the index of the target element if found
                }
            }
            return -1; // Return -1 if the target element is not found
        }

        public static void Main(string[] args)
        {
            int[] array = { 3, 6, 9, 12, 15, 18, 21, 24 };
            int target = 12;
            int index = LinearSearch(array, target);
            if (index != -1)
            {
                Console.WriteLine($"Element {target} found at index {index} using linear search.");
            }
            else
            {
                Console.WriteLine($"Element {target} not found in the array using linear search.");
            }
        }
    }
}
*/

    /*
    Binary Search:
    Binary search works only on sorted arrays. It repeatedly divides the search interval in half until the target element is found.
    csharp
    Copy code
    using System;

    */




    
     
    public class SearchEx
    {
        public static int BinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (array[mid] == target)
                {
                    return mid; // Return the index of the target element if found
                }
                else if (array[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1; // Return -1 if the target element is not found
        }

        public static void Main(string[] args)
        {
            int[] array = { 3, 6, 9, 12, 15, 18, 21, 24 };
            int target = 12;
            Array.Sort(array); // Binary search requires the array to be sorted
            int index = BinarySearch(array, target);
            if (index != -1)
            {
                Console.WriteLine($"Element {target} found at index {index} using binary search.");
            }
            else
            {
                Console.WriteLine($"Element {target} not found in the array using binary search.");
            }
        }
    }
}

   
