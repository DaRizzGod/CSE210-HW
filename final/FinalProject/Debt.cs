using System;

public class Debt
{
    public string DebtName { get; }
    public double PrincipalAmount { get; private set; }
    public double InterestRate { get; }
    public double MinimumPayment { get; }

    public Debt(string debtName, double principalAmount, double interestRate, double minimumPayment)
    {
        DebtName = debtName;
        PrincipalAmount = principalAmount;
        InterestRate = interestRate;
        MinimumPayment = minimumPayment;
    }

    public void MakePayment(double amount)
    {
        PrincipalAmount -= amount;
    }

    public void PrintDebtDetails()
    {
        Console.WriteLine($"Debt Name: {DebtName}, Principal Amount: {PrincipalAmount}, Interest Rate: {InterestRate}%, Minimum Payment: {MinimumPayment}");
    }
}
