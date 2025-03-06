using System;

class Account
{
    public virtual void CalculateInterest()
    {
        Console.WriteLine("Calculating interest for Account...");
    }
}

class SavingsAccount : Account
{
    public sealed override void CalculateInterest()
    {
        Console.WriteLine("Calculating interest for Savings Account...");
    }
}