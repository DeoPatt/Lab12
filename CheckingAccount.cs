using System;

class CheckingAccount : BankAccount
    {

      override public void CalculateInterest(){
double interest = Balance * .005;

Balance = Balance + interest; 
}
     public void Withdraw(){
       Withdraw();
     }
      
    }
  