namespace Arrays
{
    internal class Program
    {
    
   //Theory --

 //  C# Arrays
    //   An array is a collection of similar types of data. 
    //   For example,
    //   Suppose we need to record the age of 5 students. Instead of creating 5 separate variables,
    //    we can simply create an array:
    
    
    // We can also declare and allocate the memory of an array in a single line. For example,

        // int[] age = new int[5];

      //  Array initialization in C#
     //  In C#, we can initialize an array during the declaration. For example,

     // declare an arra
         // declare an array
int[] age = new int[5];

// //initializing array
// age[0] = 12;
// age[1] = 4;
// age[2] = 5;


// Note:

// An array index always starts at 0. That is, the first element of an array is at index 0.
// If the size of an array is 5, the index of the last element will be at 4 (5 - 1).


int [] numbers = {1, 2, 3, 4, 5};
    
    
   /* 
    4. Change Array Elements
We can also change the elements of an array. To change the element, we simply assign a new value to that particular index. For example,
    
    5. Iterating C# Array using Loops
























We can also use a foreach loop to iterate through the elements of an array. For example,

Example: Using foreach loop
using System;

namespace AccessArrayForeach {
  class Program {
    static void Main(string[] args) {
      int[] numbers = {1, 2, 3};

      Console.WriteLine("Array Elements: ");

      foreach(int num in numbers) {
        Console.WriteLine(num);
      }

      Console.ReadLine();
    }
  }
}
Output

Array Elements:
1
2
3






  */  
    
    
    
    
    
    
    
    }


}
