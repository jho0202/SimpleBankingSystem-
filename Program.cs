class Program{
    static void DisplayAccountDetails(Account account){
        Console.WriteLine($"Account Number: {account.AccountNumber}");
        Console.WriteLine($"Balance: ${account.Balance}");
    }
    static void Main(string [] args){
        SavingsAccount savingsAccount = new SavingsAccount(1001, 5.0);
        CheckingAccount checkingAccount = new CheckingAccount(2001, 500.0);

        savingsAccount.Deposit(1000);
        DisplayAccountDetails(savingsAccount);
        savingsAccount.CalculateInterest();
        DisplayAccountDetails(savingsAccount);

        Console.WriteLine();

        checkingAccount.Deposit(100);
        DisplayAccountDetails(checkingAccount);
        checkingAccount.Withdraw(600);
        DisplayAccountDetails(checkingAccount);
    }
}