using System.Diagnostics;
public class Name
{
    public void Run()
    {
        Console.Write("Please enter the purchase name: ");
        string purchaseName = Console.ReadLine();
        var purchase = new Purchase
        {
            Name = purchaseName
        };
        Program.AddPurchase(purchase);
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
