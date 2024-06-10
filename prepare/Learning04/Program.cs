using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Miles Josephson", "Math Class");
        Console.WriteLine(assignment1.GetSummary());

        Mathassignment assignment2 = new Mathassignment("Bro Gibbons", "The Matrix", "8.1", "10-15");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.Gethomeowrklist());

        Writingassignments assingment3 = new Writingassignments("Bob the builder", "Asia Math", "Assassians Creed Shadow");
        Console.WriteLine(assingment3.GetSummary());
        Console.WriteLine(assingment3.GetWritingInformation());


    }
}

