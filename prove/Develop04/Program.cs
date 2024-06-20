using System;
using System.Reflection;

class Program 
{
    static void Main(string[] args)
    {
       while(true) 

        {
        Console.Clear();
        Console.WriteLine("Mindfulness Activities");
        Console.WriteLine("1.Reflection");
        Console.WriteLine("2.Listing");
        Console.WriteLine("3.Breathing");
        Console.WriteLine("4.Exit");
        Console.Write("Choose an activity: ");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            ReflectionActivity reflection = new ReflectionActivity();
            reflection.Run();
        }
        else if (choice == "2")
        {
            ListingActivity listing = new ListingActivity();
            listing.Run();
        }
        else if (choice == "3")
        {
            BreathingActivity breathing = new BreathingActivity();
            breathing.Run();
        }
        else if (choice == "4")
        {
            break;

        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again");
        }
        }
    }
}