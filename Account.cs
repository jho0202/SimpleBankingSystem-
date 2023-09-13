using System;
class Account{
    private int accountNumber;
    protected double balance;
    public int AccountNumber{
        get {return accountNumber;}
    }
    public double Balance{
        get{ return balance;}
    }
    public Account(int accountNumber){
        this.accountNumber = accountNumber;
        this.balance = 0;
    }
    public void Deposit(double amount){
        if(amount > 0){
            balance += amount;
            Console.WriteLine($"Deposited ${amount}. into Account: {accountNumber}");
        }
        else{
            Console.WriteLine("Invalid deposit amount.");
        }
    }
    public virtual void Withdraw(double amount){
        if(amount > 0 && balance >= amount){
            balance -= amount;
            Console.WriteLine($"Withdrawn ${amount}. into Account: {accountNumber}");
        }
        else{
            Console.WriteLine("invalid withdrwal amount or insufficient balance.");
        }
    }
}