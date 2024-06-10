using System;
using System.Collections.Generic;
using System.Linq;

class Program
{ 
    static void Main()
    {
        Console.WriteLine("Enter the scripture: ");
        string scripture = Console.ReadLine();

        Console.WriteLine("Enter the reference: ");
        string reference = Console.ReadLine();

        var verse = new Verse(scripture);
        verse.setReference(reference);

        var hiddenWords = new HashSet<string>();
        var words = verse.Words.Select(w => w.Text).ToArray();

        while(true)
        {
            Console.Clear();
            Console.WriteLine($"{verse.Reference}\n{HideWords(verse, hiddenWords)}\n");

            Console.WriteLine("Press enter to hide a word or type 'quit' to exit:" );
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "quit")
            {
                break;
            }

            if (hiddenWords.Count < words.Length)
            {
                var wordToHide = words[new Random().Next(words.Length)];
                hiddenWords.Add(wordToHide);
            }

            if (hiddenWords.Count == words.Length)
            {
                Console.WriteLine("All words are hidden!");
                break;
            }
        }
    }

    static string HideWords(Verse verse, HashSet<string> hiddenWords)
    {
        return string.Join(" ", verse.Words.Select(word => hiddenWords.Contains(word.Text) ? "____" : word.Text));
    }

    public class Word
    {
        public string Text {get; private set; }

        public Word(string text)
        {
            Text = text;
        }
    }
    public class Verse
    {
        public List<Word> Words {get; private set; }
        public string Reference {get; private set; }

        public Verse(string text)
        {
            Words = text.Split().Select(word => new Word(word)).ToList();
        }

        public void setReference(string reference)
        {
            Reference = reference;
        } 
    }
}
