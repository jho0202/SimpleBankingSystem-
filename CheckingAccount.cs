class CheckingAccount : Account{
    private double overdraftLimit;
    public double OverdraftLimit{
        get{ return overdraftLimit;}
        set {overdraftLimit = value;}
    }
    public CheckingAccount(int accountNumber, double overdraftLimit) : base(accountNumber){
        this.overdraftLimit = overdraftLimit;
    }
    public override void Withdraw(double amount){
        if (amount > 0 && (Balance - amount) >= -overdraftLimit){
            balance -= amount;
            Console.WriteLine($"Withdrawn ${amount}. Current Balance: ${Balance}");
        }
        else{
            Console.WriteLine("Invalid withdrawal amount or exceeding overdraft limit");
        }
    }
}