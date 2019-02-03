using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace p5Bank
{
   public partial class AstralisAccountCreator : Form
   {
      public List<Account> account;
      string accType;

      public AstralisAccountCreator(List<Account> account)
      {
         this.account = account;
         InitializeComponent();
      }

      private void AstralisAccountCreator_Load(object sender, EventArgs e)
      {

      }

      private void cBoxType_SelectedIndexChanged(object sender, EventArgs e)
      {
         accType = cBoxType.Text;
         if (accType == "Checking")
            lblInterest.Text = "Enter transaction fee: ";

         if (accType == "Savings")
            lblInterest.Text = "     Enter interest rate: ";
      }

      private void btCreate_Click(object sender, EventArgs e)
      {
         decimal firstDeposit = decimal.Parse(initDepositTxtBox.Text);
         Account initDepCheck = new CheckingAccount(); // test account
         initDepCheck.setBalance(firstDeposit); // initial deposit has to be check in the common properties account

         if (firstDeposit >= 0)
         {
            string name = accNameTxtBox.Text; // Username of account
            string pass = pwTxtBox.Text; // password for the account
            decimal initialDeposit = decimal.Parse(initDepositTxtBox.Text);
            decimal feeOrInterestRate = decimal.Parse(rateTxtBox.Text);

            string folderName = @"C:\Users\Art\Documents\Visual Studio 2015\Projects\p5Bank\p5Bank\AccountsFolder";
            string fileName = name + "File.txt";

            // Create the filepath
            string pathString = System.IO.Path.Combine(folderName, fileName);

            // Create the new user file
            System.IO.FileStream newFile = System.IO.File.Create(pathString);

            if (accType == "Checking")
            {
               byte[] nameByte = new UTF8Encoding(true).GetBytes(name + Environment.NewLine);
               byte[] pwByte = new UTF8Encoding(true).GetBytes(pass + Environment.NewLine);
               byte[] initDepByte = new UTF8Encoding(true).GetBytes(Convert.ToString(initialDeposit) + Environment.NewLine);
               byte[] feeOrIntByte = new UTF8Encoding(true).GetBytes(Convert.ToString(feeOrInterestRate) + Environment.NewLine);
               byte[] typeByte = new UTF8Encoding(true).GetBytes(accType);
               // Write the new user file
               newFile.Write(nameByte, 0, nameByte.Length);
               newFile.Write(pwByte, 0, pwByte.Length);
               newFile.Write(initDepByte, 0, initDepByte.Length);
               newFile.Write(feeOrIntByte, 0, feeOrIntByte.Length);
               newFile.Write(typeByte, 0, typeByte.Length);

               account.Add(new CheckingAccount(name, pass, initialDeposit, feeOrInterestRate, accType));
            }

            if (accType == "Savings") // checks initial deposit
            {
               byte[] nameByte = new UTF8Encoding(true).GetBytes(name + Environment.NewLine);
               byte[] pwByte = new UTF8Encoding(true).GetBytes(pass + Environment.NewLine);
               byte[] initDepByte = new UTF8Encoding(true).GetBytes(Convert.ToString(initialDeposit) + Environment.NewLine);
               byte[] feeOrIntByte = new UTF8Encoding(true).GetBytes(Convert.ToString(feeOrInterestRate) + Environment.NewLine);
               byte[] typeByte = new UTF8Encoding(true).GetBytes(accType);
               // Write the new user file
               newFile.Write(nameByte, 0, nameByte.Length);
               newFile.Write(pwByte, 0, pwByte.Length);
               newFile.Write(initDepByte, 0, initDepByte.Length);
               newFile.Write(feeOrIntByte, 0, feeOrIntByte.Length);
               newFile.Write(typeByte, 0, typeByte.Length);

               account.Add(new SavingAccount(name, pass, initialDeposit, feeOrInterestRate, accType));
            }
            MessageBox.Show("Account has been created. Exit Menu");
            newFile.Close();
         }
         else
         {
            throw new ArgumentOutOfRangeException("Initial Blance", firstDeposit, "Initial Balance must be >= 0");
         }
      }

      private void btCancel_Click(object sender, EventArgs e)
      {
         Close();
      }
   }
}
