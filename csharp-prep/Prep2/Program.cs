using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("What grade percentage do you have for the class? ");
        int grade = Convert.ToInt32(Console.ReadLine());
        
            string letter; 
      

        if (grade >= 90)
        { 
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }
        
            Console.WriteLine($"Your letter grade is {letter}");

            if (grade >= 70)
            {
                Console.WriteLine("Congrats! You passed the course!");
            }
            else
            {
                Console.WriteLine("Don't worry, there's always next time. Keep trying!");   
            }
    }
}


// Ask the user for their grade percentage, 

// Assume that you must have at least a 70 to pass the class. After determining the letter grade 
// and printing it out. Add a separate if statement to determine if the user passed the course, 
// and if so display a message to congratulate them. If not, display a different message to encourage them for next time.

// Change your code from the first part, so that instead of printing the letter grade in the body of each if, elif, or else block,
// instead create a new variable called letter and then in each block, set this variable to the appropriate value. Finally, after
// the whole series of if-elif-else statements, have a single print statement that prints the letter grade once.
// if (x > y)
// {
//     Console.WriteLine("greater than y");
// }
// else if (x > z)
// {
//     Console.WriteLine("greater than z");
// }