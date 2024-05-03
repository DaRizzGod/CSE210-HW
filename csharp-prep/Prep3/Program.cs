using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the Magical Number");
        int magicNumber = int.Parse(Console.ReadLine());
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,101);
    
        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("What number are you guessing? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("A lil Lower");
            }
            else
            {
                Console.WriteLine("Wahoooo!!!");
            }
        }
}   }

