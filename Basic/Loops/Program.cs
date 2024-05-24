// for loop

 int i = 0;
{
 for ( i = 0; i <= 5; i++)
        {
            Console.WriteLine("i is: " + i);
        }
        
        Console.WriteLine("End of for loop");
    
}

//while loop

    
 int a =0;
    { 
        while (a < 3)
        {
            Console.WriteLine("a is: " + a);
            a++;
        }
        
        Console.WriteLine("End of while loop");
}

// do while loop 

int b =0;
{

  do
        {
            Console.WriteLine("b is: " + b);
            b++;
        }
  while (b < 4 );
        
        Console.WriteLine("End of do-while loop");
}





//theory
/*


loop as a set of instructions that you want to execute repeatedly until a certain condition is met

for loop: Use this when you know exactly how many times you want to repeat a block of code.
          You specify the starting point, the condition for continuation, and how the loop variable changes each time

while loop: This loop repeats a block of code as long as a specified condition is true. 
            It's useful when you're not sure how many times the loop needs to run in advance.

do-while loop: Similar to the while loop, but it always executes the block of code at least once before checking the condition.
               After the first execution,it repeats the block of code as long as the condition remains true.






real time example-

// Updating User Records in a Database:
// In a database application, there might be a need to update multiple user records based on certain criteria.
// For example, 
//              let's say we want to update the status of users who are under 18 years old to "Minor".
//              We use a foreach loop to iterate over each user record in the database. 
//              For each user, we check if their age is less than 18. If it is, we update their status to "Minor".
//              This loop allows us to efficiently update multiple user records based on the specified condition



// for (int i = 0; i < users.Length; i++) {
//     User user = users[i];
//     if (user.Age < 18) {
//         user.Status = "Minor";
//     }
// }


// int i = 0;
// do {
//     User user = users[i];
//     if (user.Age < 18) {
//         user.Status = "Minor";
//     }
//     i++;
// } while (i < users.Length);



// int i = 0;
// while (i < users.Length) {
//     User user = users[i];
//     if (user.Age < 18) {
//         user.Status = "Minor";
//     }
//     i++;
// }



// foreach (User user in users) {
//     if (user.Age < 18) {
//         user.Status = "Minor";
//     }
// }



*/