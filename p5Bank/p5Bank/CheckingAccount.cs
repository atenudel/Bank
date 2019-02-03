namespace p5Bank
{
   public class CheckingAccount : Account
   {
      private decimal feePerTransaction;
      private string checkingType;

      public CheckingAccount()
      {
      }

      // Constructor from base class
      public CheckingAccount(string name, string password, decimal balance) : base(name, password, balance)
      {
      }

      // Constructor with fee
      public CheckingAccount(string name, string password, decimal balance, decimal fee, string type) : this(name, password, balance)
      {
         Fee = fee;
      }

      public string Type
      {
         get { return checkingType; }
         set { checkingType = value; }
      }

      public decimal Fee
      {
         get { return feePerTransaction; }
         set { feePerTransaction = value; }
      }

      public override void Debit(decimal fee) // THIS IS WITHDRAW
      {
         decimal Balance = this.Balance; // Take the fee away from the balance when transaction succeeds

         if (fee <= 0)
         {
            setBalance(Balance);
         }
         else
         {
            setBalance(Balance - fee - feePerTransaction);
         }
      }

   }
}

