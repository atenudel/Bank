using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace p5Bank
{
   public partial class AstralisDepositWithdraw : Form
   {
      public List<Account> accounts;
      public List<string> objProperties = new List<string>();
      int index;

      public AstralisDepositWithdraw(int index, List<Account> accounts)
      {
         InitializeComponent();
         this.accounts = accounts;
         this.index = index;
         lblName.Text = "Please make a transaction, " + accounts[index].Name;
         lblBalance.Text = "Your current balance is:   " + Convert.ToString(accounts[index].Balance);
      }

      private void btConfirm_Click(object sender, EventArgs e)
      {

         if (string.IsNullOrWhiteSpace(txtBoxDeposit.Text))
            txtBoxDeposit.Text = "0";

         if (string.IsNullOrWhiteSpace(txtBoxWithdraw.Text))
            txtBoxWithdraw.Text = "0";

         // Obtain the file names
         string[] files = Directory.GetFiles(@"C:\Users\Art\Documents\Visual Studio 2015\Projects\p5Bank\p5Bank\AccountsFolder\").Select(file => Path.GetFileName(file)).ToArray();
         foreach (string file in files)
            Path.GetFileName(file);

         string[] txtFiles = Directory.GetFiles(@"C:\Users\Art\Documents\Visual Studio 2015\Projects\p5Bank\p5Bank\AccountsFolder\", "*.txt");
         string fileName = accounts[index].Name + "File.txt";
         decimal depositCredit = decimal.Parse(txtBoxDeposit.Text);
         decimal withdrawDebit = decimal.Parse(txtBoxWithdraw.Text);

         // apply the new properties

         accounts[index].Credit(depositCredit);
         accounts[index].Debit(withdrawDebit);
         
         for (int i = 0; i < files.Length; i++)
         {
            StreamReader file = new StreamReader(txtFiles[i]); // this reads from the file at current index from the files found in directory
            string line;

            if (fileName == files[i])
            {
               // Obtain the user data from their file
               while ((line = file.ReadLine()) != null)
               {
                  objProperties.Add(line);
               }

               file.Close();

               string folderName = @"C:\Users\Art\Documents\Visual Studio 2015\Projects\p5Bank\p5Bank\AccountsFolder";

               // Combine to add the file name to the path
               string pathString = Path.Combine(folderName, fileName);

               // Change the user file
               FileStream modFile = File.Create(pathString);
               byte[] nameByte = new UTF8Encoding(true).GetBytes(accounts[index].Name + Environment.NewLine);
               byte[] pwByte = new UTF8Encoding(true).GetBytes(accounts[index].Password + Environment.NewLine);
               byte[] balByte = new UTF8Encoding(true).GetBytes(Convert.ToString(accounts[index].Balance) + Environment.NewLine);
               byte[] feeOrIntByte = new UTF8Encoding(true).GetBytes(Convert.ToString(objProperties[3]) + Environment.NewLine);
               byte[] accTypeByte = new UTF8Encoding(true).GetBytes(objProperties[4]);

               modFile.Write(nameByte, 0, nameByte.Length);
               modFile.Write(pwByte, 0, pwByte.Length);
               modFile.Write(balByte, 0, balByte.Length);
               modFile.Write(feeOrIntByte, 0, feeOrIntByte.Length);
               modFile.Write(accTypeByte, 0, accTypeByte.Length);

               modFile.Close();
            }
         }
         lblBalance.Text = "New Balance:     " + Convert.ToString(accounts[index].Balance);
      }

      private void btLogOut_Click(object sender, EventArgs e)
      {
         Close();
      }
   }
}
