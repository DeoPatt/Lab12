using System;

class MainClass {
  public static void Main (string[] args) {
    //Console.WriteLine ("Hello World");

    //Write code to implement the test cases below
SavingsAccount s1 = new SavingsAccount();

s1.Balance = 5000;
Console.WriteLine(s1.Balance + " is your balance");
s1.Deposit(1000);
Console.WriteLine(s1.Balance + " is your new balance after deposit");
s1.Withdraw(5000);
Console.WriteLine(s1.Balance);
s1.CalculateInterest();
Console.WriteLine(s1.Balance);
s1.Withdraw(500);
Console.WriteLine(s1.Balance);
            /*Test case 1
             * Create a savingsaccount object
             * Deposit $2000
             * Withdraw $5000
             * Calculate interest
             * Withdraw $500
            */

            /*Test case 2
            * Create a checkingaccount object
            * Deposit $2000
            * Withdraw $5000
            * Calculate interest
            * Withdraw $500
           */
           
CheckingAccount c1 = new CheckingAccount();
c1.Deposit(2000);
c1.Withdraw(5000);
c1.CalculateInterest();
c1.Withdraw(500);
  }
}