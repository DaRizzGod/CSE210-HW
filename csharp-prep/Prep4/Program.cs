using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        string input = "";
        while(true)
        {
            Console.Write("Enter a number (or 'done' to finish): ");
            input = Console.ReadLine();
            if (input.ToLower() == "done")
            {
                break;
            }
            else
            {
                numbers.Add(Convert.ToInt32(input));
            }
        }

        int sum = numbers.Sum();
        double average = numbers.Average();
        int max = numbers.Max();

            Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max} ");
        
    }

}
// Compute the sum, or total, of the numbers in the list.

// Compute the average of the numbers in the list.

// Find the maximum, or largest, number in the list.