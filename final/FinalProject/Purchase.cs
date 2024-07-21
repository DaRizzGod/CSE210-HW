using System;

public class Purchase
{
    public string Name { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    public PurchaseDetail Detail { get; set; }
}

public class PurchaseDetail
{
    public string Category { get; set; }
    public string Description { get; set; }
}
