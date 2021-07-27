using System;

class SavingsAccount : BankAccount
    {
override public void CalculateInterest(){
double interest = Balance * .05;
Balance = Balance + interest;
}
      public void Withdraw(){
        if (Balance<2000)
        {
          Console.WriteLine("Insufficent funds");

        }
        else
        {
          Withdraw();
        }
      }
    }