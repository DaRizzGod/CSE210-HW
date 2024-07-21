public class Amount
{
    public void Run()
    {
        Console.Write("Please enter an amount of money: ");
        string input = Console.ReadLine();
        if (decimal.TryParse(input, out decimal amount))
        {
            var purchase = new Purchase();
            purchase.Amount = amount;
            Program.AddPurchase(purchase);
            Console.WriteLine($"You entered: {amount:C}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid amount of money.");
        }
    }
}

