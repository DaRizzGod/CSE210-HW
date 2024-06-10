using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

public class Program
{ 
    private string Word;
    private string Verse;

    static void Main()
    {
        // Word behold= new Word("behold");
        // Console.WriteLine($"{behold.GetText()}");

        Verse bullet= new Verse("27 And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them");
        Console.WriteLine($"{bullet.GetVerse()}");
        bullet.hiderandomword();
        Console.WriteLine($"{bullet.GetVerse()}");

        Verse bullet1= new Verse1("28 ¶ Come unto me, all ye that labour and are heavy laden, and I will give you rest.");
        Console.WriteLine($"{bullet1.GetVerse1()}");
        bullet1.hiderandomword1();
        Console.WriteLine($"{bullet1.GetVerse1()}");




        Console.WriteLine("What is the word that I'm thinking about?");
    }

}