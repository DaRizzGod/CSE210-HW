public class Description
{
        public void Run()
    {
        Console.Write("Enter the description of the purchase: ");
        string description = Console.ReadLine();
        var purchase = new Purchase();
        purchase.Detail.Description = description;
        Program.AddPurchase(purchase);
    }
}