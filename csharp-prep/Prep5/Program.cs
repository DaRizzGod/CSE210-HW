using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Reflection;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program");
    }
    static string PromptUserName ()
    {
        Console.WriteLine("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber ()
    {
        Console.WriteLine("Please enter your favorite number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        return number;
    }
    static int SquareNumber (int number)
    {
       return number * number; 
    }

    
    static void DsiplayResult(string userName, int squaredNumber )
    {
        Console.WriteLine($"{userName}, The square that you told me was {squaredNumber}");
    } 
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int number = PromptUserNumber();
        int squaredNumber = SquareNumber(number);
        DsiplayResult(userName, squaredNumber);
    }
}   

// PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
// SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
