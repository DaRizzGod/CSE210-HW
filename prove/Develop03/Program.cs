using System;
using System.Collections.Generic;
using System.Linq;

public class Word
{
    public string Text { get; private set; }
    public bool IsHidden { get; private set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    public void HideWord()
    {
        IsHidden = true;
    }

    public override string ToString()
    {
        return IsHidden ? "" : Text;
    }
}

public class Verse
{
    public List<Word> Words { get; private set; }
    public (string book, int chapter, int startVerse, int endVerse) Reference { get; private set; }

    public Verse(string text)
    {
        Words = text.Split().Select(word => new Word(word)).ToList();
    }

    public void SetReference(string book, int chapter, int startVerse, int endVerse)
    {
        Reference = (book, chapter, startVerse, endVerse);
    }

    public void HideWords()
    {
        foreach (var word in Words)
        {
            word.HideWord();
        }
    }

    public bool AllWordsHidden()
    {
        return Words.All(word => word.IsHidden);
    }

    public override string ToString()
    {
        return string.Join(" ", Words);
    }
}

public class Program
{
    public static void Main()
    {
        var verse1 = new Verse("In the beginning God created the heavens and the earth.");
        verse1.SetReference("Genesis", 1, 1, 1);
        Console.WriteLine(verse1);
        verse1.HideWords();
        Console.WriteLine(verse1.AllWordsHidden());

        var verse2 = new Verse("I, Nephi, having been born of goodly parents, therefore I was taught somewhat in all the learning of my father; and having seen many afflictions in the course of my days, nevertheless, having been highly favored of the Lord in all my days; yea, having had a great knowledge of the goodness and the mysteries of God, therefore I make a record of my proceedings in my days.");
        verse2.SetReference("1st Nephi", 1,1, 1);
        Console.WriteLine(verse2);
        verse2.HideWords();
        Console.WriteLine(verse2.AllWordsHidden());

        
        var verse3 = new Verse("In the beginning God created the heavens and the earth.");
        verse3.SetReference("Genesis", 1, 1, 1);
        Console.WriteLine(verse3);
        verse3.HideWords();
        Console.WriteLine(verse3.AllWordsHidden());
    }
}
