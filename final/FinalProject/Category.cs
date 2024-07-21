public class Category
{
    public void Run()
    {
        Console.Write("Enter the category of the purchase: ");
        string category = Console.ReadLine();
        var purchase = new Purchase();
        purchase.Detail.Category = category;
        Program.AddPurchase(purchase);
    }
}