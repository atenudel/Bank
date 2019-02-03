using System.Windows.Forms;

namespace p5Bank
{
   public class SavingAccount : Account
   {
      private decimal interestRate;
      private string savingType;

      public SavingAccount(string name, string password, decimal balance) : base(name, password, balance)
      {
      }

      public SavingAccount(string name, string password, decimal balance, decimal interest, string type) : this(name, password, balance)
      {
         InterestRate = interest;
      }

      public string Type
      {
         get { return savingType; }
         set { savingType = value; }
      }

      public decimal InterestRate
      {
         get { return interestRate; }
         set { interestRate = value; }
      }

      public override void Credit(decimal deposit) // Implementation of interest based on user deposit aka credit
      {
         MessageBox.Show("Interest owed is " + CalculateInterest(interestRate).ToString()); // Notify user of interest earned
         setBalance(Balance + CalculateInterest(interestRate) + deposit);
      }

      public decimal CalculateInterest(decimal interestRate)
      {
         decimal owedInterest;
         return owedInterest = (Balance * interestRate);
      }
   }
}