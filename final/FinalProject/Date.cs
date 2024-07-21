public class Date
{
    public void Run()
    {
        Console.Write("Enter the date of the purchase (yyyy-mm-dd): ");
        string dateInput = Console.ReadLine();
        if (DateTime.TryParse(dateInput, out DateTime date))
        {
            var purchase = new Purchase();
            purchase.Date = date;
            Program.AddPurchase(purchase);
            Console.WriteLine($"Date: {date:yyyy-MM-dd}");
        }
        else
        {
            Console.WriteLine("Invalid date. Please enter a valid date in the format yyyy-mm-dd.");
        }
    }
}