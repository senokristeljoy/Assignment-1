internal class BankAccount
{
    private string accountNumber;
    private string accountHolder;
    private double balance;

    public BankAccount(string accountNumber, string accountHolder, double initialBalance)
    {
        this.accountNumber = accountNumber;
        this.accountHolder = accountHolder;
        this.balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit amount must be positive.");
            return;
        }

        balance += amount;
        Console.WriteLine("Deposit Successful!");
    }

    public void DisplayBalance()
    {
        Console.WriteLine($"Current Balance: {balance:0.00}");
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdrawal amount must be positive.");
            return;
        }

        if (amount > balance)
        {
            Console.WriteLine("Insufficient funds.");
            return;
        }

        balance -= amount;
        Console.WriteLine("Withdrawal Successful!");
    }
}