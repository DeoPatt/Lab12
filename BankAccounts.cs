 using System;
 
 abstract class BankAccount
    {
        public string AcctNbr { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        public DateTime DateCreated { get; set; }

        public BankAccount(): this (1000)
        {
            
        }

         public BankAccount(double balance)
        {
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            Balance = amount + Balance;
            Console.WriteLine(Balance);
        }

        public virtual void Withdraw(double amount)
        {
          
            if (Balance > amount)
            {
              Balance = Balance - amount;
            }
           
        }
         public  abstract void CalculateInterest();

    }