using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;


public class JournalEntry
{
    public DateTime _entryDateTime {get; set;}
    public string _entryPrompt {get; set;}
    public string _entryContent {get; set;}

    public JournalEntry(string prompt, string content)
    {
        _entryDateTime = DateTime.Now;
        _entryPrompt = prompt;
        _entryContent = content;
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_entryDateTime}");
        Console.WriteLine($"Prompt: {_entryPrompt}");
        Console.WriteLine($"Entry: {_entryContent}");
    }
}

public class Journal
{
    public List<string> _prompts = new List<string>
    {
        "Where have you seen God's Hand in your life?",
        "What are you grateful for today?",
        "What made you smile today?",
    };

    private Random _random = new Random();

    public List<JournalEntry> _entries { get; set;}

    public Journal()
    {
        _entries = new List<JournalEntry>();
    }

    public void AddEntry()
    {
        Console.WriteLine("Tell me how your feeling today: ");
        string content = Console.ReadLine();

        string prompt = _prompts[_random.Next(_prompts.Count)];

        JournalEntry newEntry = new JournalEntry(prompt, content);
        _entries.Add(newEntry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in _entries)
        {
            entry.DisplayEntry();
            Console.WriteLine("--------------");
        }
    }

    public void SaveJouurnal(string filePath)
    {
        using (StreamWriter file = new StreamWriter(filePath))
        {
            foreach (var entry in _entries)
            {
                file.WriteLine($"{entry._entryDateTime}/{entry._entryPrompt}/{entry._entryContent}");
            }
        }
    }

    public void LoadJournal(string filePath)
    {
        _entries.Clear();

        using (StreamReader file = new StreamReader(filePath))
        {
            string line;
            while((line = file.ReadLine()) != null)
            {
                var parts = line.Split('/');
                if (parts.Length == 3)
                {
                    _entries.Add(new JournalEntry(parts[1], parts[2]) { _entryDateTime = DateTime.Parse(parts[0]) });
                }
            }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Journal myJournal = new Journal();
            string userInput = "";

            while (userInput != "exit")
            {
                Console.WriteLine("Enter 'add' to add a new entry, 'view' to view all entries, 'save' to save the journal, 'load' to load the journal, or 'exit' to quit:");
                userInput = Console.ReadLine();

                if (userInput == "add")
                {
                    myJournal.AddEntry();
                }
                else if (userInput == "view")
                {
                    myJournal.DisplayEntries();
                }
                else if (userInput == "save")
                {
                    Console.WriteLine("Enter the file path to save the journal: ");
                    string filePath = Console.ReadLine();
                    myJournal.SaveJouurnal(filePath);
                }
                else if (userInput == "load")
                {
                    Console.WriteLine("Enter the file path to load the journal: ");
                    string filePath = Console.ReadLine();
                    myJournal.LoadJournal(filePath);
                }
            }
        }
    }    
}