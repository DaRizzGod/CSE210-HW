using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static UserProfileManager UserProfileManager = new UserProfileManager();
    public static UserProfile CurrentUser = null;

    static void Main(string[] args)
    {
        // Sample user profiles for demonstration
        UserProfileManager.AddProfile(new UserProfile("Alice", "alice@example.com"));
        UserProfileManager.AddProfile(new UserProfile("Bob", "bob@example.com"));

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Simplified Budgeting App");
            Console.WriteLine("1. Login");
            Console.WriteLine("2. List Users");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Login();
            }
            else if (choice == "2")
            {
                UserProfileManager.ListProfiles();
            }
            else if (choice == "3")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }

    static void Login()
    {
        Console.Write("Enter your username: ");
        string username = Console.ReadLine();

        CurrentUser = UserProfileManager.GetProfile(username);
        if (CurrentUser == null)
        {
            Console.WriteLine("User not found. Please try again.");
            return;
        }

        while (true)
        {
            Console.Clear();
            Console.WriteLine($"Welcome, {CurrentUser.Username}");
            Console.WriteLine("1. Manage Purchases");
            Console.WriteLine("2. Manage Debts");
            Console.WriteLine("3. Manage Notes");
            Console.WriteLine("4. View Summary");
            Console.WriteLine("5. Logout");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                ManagePurchases();
            }
            else if (choice == "2")
            {
                ManageDebts();
            }
            else if (choice == "3")
            {
                ManageNotes();
            }
            else if (choice == "4")
            {
                CurrentUser.PrintSummary();
                Console.WriteLine("Press any key to return to the menu...");
                Console.ReadKey();
            }
            else if (choice == "5")
            {
                CurrentUser = null;
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }

public static void ManagePurchases()
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine("Manage Purchases");
        Console.WriteLine("1. Add Purchase");
        Console.WriteLine("2. View Purchases");
        Console.WriteLine("3. Back to Main Menu");
        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            AddPurchase(); // This will now correctly call the parameterized AddPurchase method
        }
        else if (choice == "2")
        {
            ViewPurchases();
        }
        else if (choice == "3")
        {
            break;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}

    public static void AddPurchase()
    {
        Console.Write("Enter Purchase Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Amount: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal amount))
        {
            Console.WriteLine("Invalid amount.");
            return;
        }

        Console.Write("Enter Date (yyyy-mm-dd): ");
        if (!DateTime.TryParse(Console.ReadLine(), out DateTime date))
        {
            Console.WriteLine("Invalid date.");
            return;
        }

        Console.Write("Enter Category: ");
        string category = Console.ReadLine();

        Console.Write("Enter Description: ");
        string description = Console.ReadLine();

        var purchase = new Purchase
        {
            Name = name,
            Amount = amount,
            Date = date,
            Detail = new PurchaseDetail
            {
                Category = category,
                Description = description
            }
        };

        if (CurrentUser != null)
        {
            CurrentUser.AddPurchase(purchase); // Correctly use the parameterized method
            Console.WriteLine("Purchase added successfully!");
        }
        else
        {
            Console.WriteLine("No user is currently logged in.");
        }
    }


    public static void ViewPurchases()
    {
        Console.WriteLine("Your Purchases:");
        if (CurrentUser != null)
        {
            foreach (var purchase in CurrentUser.Purchases)
            {
                Console.WriteLine($"Name: {purchase.Name}, Amount: {purchase.Amount:C}, Date: {purchase.Date:yyyy-MM-dd}, Category: {purchase.Detail.Category}, Description: {purchase.Detail.Description}");
            }
        }
        else
        {
            Console.WriteLine("No user is currently logged in.");
        }
    }

    public static void ManageDebts()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Manage Debts");
            Console.WriteLine("1. Add Debt");
            Console.WriteLine("2. View Debts");
            Console.WriteLine("3. Make Payment");
            Console.WriteLine("4. Back to Main Menu");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                AddDebt();
            }
            else if (choice == "2")
            {
                ViewDebts();
            }
            else if (choice == "3")
            {
                MakePayment();
            }
            else if (choice == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }

    public static void AddDebt()
    {
        Console.Write("Enter Debt Name: ");
        string debtName = Console.ReadLine();

        Console.Write("Enter Principal Amount: ");
        if (!double.TryParse(Console.ReadLine(), out double principalAmount))
        {
            Console.WriteLine("Invalid principal amount.");
            return;
        }

        Console.Write("Enter Interest Rate: ");
        if (!double.TryParse(Console.ReadLine(), out double interestRate))
        {
            Console.WriteLine("Invalid interest rate.");
            return;
        }

        Console.Write("Enter Minimum Payment: ");
        if (!double.TryParse(Console.ReadLine(), out double minimumPayment))
        {
            Console.WriteLine("Invalid minimum payment.");
            return;
        }

        var newDebt = new Debt(debtName, principalAmount, interestRate, minimumPayment);
        CurrentUser?.AddDebt(newDebt);

        Console.WriteLine("Debt added successfully!");
    }

    public static void ViewDebts()
    {
        Console.WriteLine("Your Debts:");
        if (CurrentUser != null)
        {
            foreach (var debt in CurrentUser.Debts)
            {
                debt.PrintDebtDetails();
            }
        }
        else
        {
            Console.WriteLine("No user is currently logged in.");
        }
    }

    public static void MakePayment()
    {
        Console.Write("Enter Debt Name: ");
        string debtName = Console.ReadLine();

        var debt = CurrentUser?.Debts.FirstOrDefault(d => d.DebtName.Equals(debtName, StringComparison.OrdinalIgnoreCase));

        if (debt != null)
        {
            Console.Write("Enter Payment Amount: ");
            if (!double.TryParse(Console.ReadLine(), out double paymentAmount))
            {
                Console.WriteLine("Invalid payment amount.");
                return;
            }

            debt.MakePayment(paymentAmount);

            Console.WriteLine("Payment made successfully!");
        }
        else
        {
            Console.WriteLine("Debt not found.");
        }
    }

    public static void ManageNotes()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Manage Notes");
            Console.WriteLine("1. Add Note");
            Console.WriteLine("2. View Notes");
            Console.WriteLine("3. Back to Main Menu");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                AddNote();
            }
            else if (choice == "2")
            {
                ViewNotes();
            }
            else if (choice == "3")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }

    public static void AddNote()
    {
        Console.Write("Enter Note Title: ");
        string title = Console.ReadLine();

        Console.Write("Enter Note Content: ");
        string content = Console.ReadLine();

        var newNote = new Note(title, content);
        CurrentUser?.AddNote(newNote);

        Console.WriteLine("Note added successfully!");
    }

    public static void ViewNotes()
    {
        Console.WriteLine("Your Notes:");
        if (CurrentUser != null)
        {
            foreach (var note in CurrentUser.Notes)
            {
                note.PrintNoteDetails();
            }
        }
        else
        {
            Console.WriteLine("No user is currently logged in.");
        }
    }

    internal static void AddPurchase(Purchase purchase)
    {
        throw new NotImplementedException();
    }
}

// Additional classes (UserProfile, UserProfileManager, Note, Debt, Purchase, PurchaseDetail) remain the same
