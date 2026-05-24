using System;

class BankAccount
{
    private decimal balance;

    public BankAccount(decimal initialBalance)
    {
        if (initialBalance < 0)
        {
            throw new ArgumentException("Initial balance cannot be negative.");
        }

        balance = initialBalance;
    }

    public void Withdraw(decimal amount)
    {
        try
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be greater than zero.");
            }

            if (amount > balance)
            {
                throw new InvalidOperationException("Insufficient balance.");
            }

            balance -= amount;

            Console.WriteLine($"Withdrawal successful. Remaining balance: {balance:C}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Input Error: {ex.Message}");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Transaction Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected Error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Transaction completed.");
        }
    }
}

class Program
{
    static void Main()
    {
        try
        {
            BankAccount account = new BankAccount(1000);

            account.Withdraw(500);
            account.Withdraw(2000);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Fatal Error: {ex.Message}");
        }
    }
}