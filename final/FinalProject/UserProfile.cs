using System;
using System.Collections.Generic;

public class UserProfile
{
    public string Username { get; }
    public string Email { get; }
    public List<Purchase> Purchases { get; }
    public List<Debt> Debts { get; }
    public List<Note> Notes { get; }

    public UserProfile(string username, string email)
    {
        Username = username;
        Email = email;
        Purchases = new List<Purchase>();
        Debts = new List<Debt>();
        Notes = new List<Note>();
    }

    public void AddPurchase(Purchase purchase)
    {
        Purchases.Add(purchase);
    }

    public void AddDebt(Debt debt)
    {
        Debts.Add(debt);
    }

    public void AddNote(Note note)
    {
        Notes.Add(note);
    }

    public void PrintSummary()
    {
        Console.WriteLine($"Summary for {Username}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Total Purchases: {Purchases.Count}");
        Console.WriteLine($"Total Debts: {Debts.Count}");
        Console.WriteLine($"Total Notes: {Notes.Count}");
    }
}

