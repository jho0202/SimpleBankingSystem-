class SavingsAccount : Account{
    private double interestRate;
    public double InterestRate{
        get{return interestRate;}
        set{interestRate = value;}
    }
    public SavingsAccount( int accountNumber, double interestRate) : base(accountNumber){
        this.interestRate = interestRate;
    }
    public void CalculateInterest(){
        double interest = Balance * (interestRate / 100);
        if (interest > 0){
            Deposit(interest);
            Console.WriteLine($"Interest of ${interest} Earned: ${Balance}");
        }
        else{
            Console.WriteLine("No interest added (your balance might be negative)");
        }
    }
}