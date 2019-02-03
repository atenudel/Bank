using System;
using System.Windows.Forms;

namespace p5Bank
{
   public class Account
   {
      private string name;
      private string password;
      private decimal balance;
      // Default
      public Account()
      {
      }

      public Account(string name, string password, decimal balance)
      {
         this.name = name;
         this.password = password;
         this.balance = balance;
      }

      public string Name
      {
         get { return name; }
         set { name = value; }
      }

      public string Password
      {
         get { return password; }
         set { password = value; }
      }

      public decimal Balance
      {
         get { return balance; }
         set { balance = value; }

      }

      public void setBalance(decimal initBalance) // CHANGE balance in other class
      {
         InitialBalance(initBalance);
      }

      public void InitialBalance(decimal initialBalance) // throws exception
      {
         if (initialBalance >= 0)
         {
            Balance = initialBalance;
         }
         else
            throw new ArgumentOutOfRangeException("Initial Blance", initialBalance, "Initial Balance must be >= 0");
      }

      public virtual void Credit(decimal deposit) // DEPOSIT, to be overriden in derived class
      {
         balance += deposit;
      }

      public virtual void Debit(decimal withdrawal) // WITHDRAW, to be overriden in derived class
      {
         if (withdrawal > balance)
            MessageBox.Show("Debit amount exceeded account Balance");
         else
            balance -= withdrawal;
      }
   }
}


