using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace p5Bank
{
   public partial class Astralis : Form
   {
      public string[] txtFiles = Directory.GetFiles(@"C:\Users\Art\Documents\Visual Studio 2015\Projects\p5Bank\p5Bank\AccountsFolder\", "*.txt");
      public List<string> objProperties = new List<string>(); // holds properties for the object (obtained from textfiles)
      public List<Account> accounts = new List<Account>(); // holds the checking and savings accounts

      public Astralis()
      {
         InitializeComponent();

         // Iterate through txtFiles array to load up accounts list objects from previous sessions
         for (int i = 0; i < txtFiles.Length; i++)
         {
            string line;
            StreamReader file = new StreamReader(txtFiles[i]);
            // Add text file data to objProperties array in order to fill object data fields
            while ((line = file.ReadLine()) != null)
            {
               objProperties.Add(line);
            }
            file.Close();

            string uName = objProperties[0];
            string uPass = objProperties[1];
            decimal uBalance = decimal.Parse(objProperties[2]);
            decimal feeOrInterest = decimal.Parse(objProperties[3]);
            string accType = objProperties[4];

            if (accType == "Checking")
            {
               accounts.Add(new CheckingAccount(uName, uPass, uBalance, feeOrInterest, accType));
            }
            if (accType == "Savings")
            {
               accounts.Add(new SavingAccount(uName, uPass, uBalance, feeOrInterest, accType));
            }
         }
      }

      private void btSignUp_Click(object sender, EventArgs e)
      {
         AstralisAccountCreator accountCreator = new AstralisAccountCreator(accounts);
         accountCreator.Show();
      }

      private void btLogOn_Click(object sender, EventArgs e)
      {
         if(accounts.Count == 0)
            MessageBox.Show("Please sign up before proceeding.");
         else
         {
            string id = userIDTextBox.Text;
            string pw = passTxtBox.Text;
            int index;

            for (int i = 0; i < accounts.Count; i++)
            {
               if (accounts[i].Name == id && accounts[i].Password == pw) // BOTH must match...
               {
                  index = accounts.IndexOf(accounts[i]);
                  AstralisDepositWithdraw depositAndWithdraw = new AstralisDepositWithdraw(index, accounts);
                  depositAndWithdraw.Show();
               }
            }
         }
       
      }

      private void btExit_Click(object sender, EventArgs e)
      {
         Close();
      }
   }
}
