// See https://aka.ms/new-console-template for more information
using System;

public abstract class BankAccount
{
    public int AccountNumber { get; set; }
    public decimal Balance { get; set; }

    public virtual void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public virtual void Withdraw(decimal amount)
    {
        Balance -= amount;
    }
}

public class SavingsAccount : BankAccount
{
    public decimal InterestRate { get; set; }

    public override void Deposit(decimal amount)
    {
        base.Deposit(amount);
        Balance += Balance * InterestRate;
    }

    public override void Withdraw(decimal amount)
    {
        if (Balance - amount < 0)
        {
            throw new Exception("Insufficient funds");
        }
        else
        {
            base.Withdraw(amount);
        }
    }
}

public class CheckingAccount : BankAccount
{
    public decimal OverdraftLimit { get; set; }

    public override void Withdraw(decimal amount)
    {
        if (Balance - amount < -OverdraftLimit)
        {
            throw new Exception("Exceeded overdraft limit");
        }
        else
        {
            base.Withdraw(amount);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        SavingsAccount savings = new SavingsAccount();
        savings.AccountNumber = 123456;
        savings.Balance = 1000;
        savings.InterestRate = 0.05m;

        CheckingAccount checking = new CheckingAccount();
        checking.AccountNumber = 654321;
        checking.Balance = 500;
        checking.OverdraftLimit = 200;

        savings.Deposit(500);
        savings.Withdraw(200);

        checking.Deposit(100);
        checking.Withdraw(700);

        Console.WriteLine($"Savings account balance: {savings.Balance}");
        Console.WriteLine($"Checking account balance: {checking.Balance}");
    }
}