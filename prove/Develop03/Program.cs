using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.CompilerServices;

class Program
{ 
    private string Words;
    private string Verse;
    private string Reference;

    static void Main()
    {
        Reference reference = new Reference("Ether", 12 , 27, 27);
        Console.WriteLine($"{reference.GetBook}");
        string scripturetext ="And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them";
        Scripture scripture = new Scripture(reference, scripturetext);

        while(true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetFullScripture());

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("All words are hidden. Programs will now end.");
                break;
            }

            Console.WriteLine("Please Enter to hide a word or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.hiderandomword();

        }

    }

}