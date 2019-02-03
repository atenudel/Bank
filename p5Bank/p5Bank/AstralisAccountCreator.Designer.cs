namespace p5Bank
{
   partial class AstralisAccountCreator
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.lblNewAccName = new System.Windows.Forms.Label();
         this.lblNewPw = new System.Windows.Forms.Label();
         this.btCreate = new System.Windows.Forms.Button();
         this.accNameTxtBox = new System.Windows.Forms.TextBox();
         this.pwTxtBox = new System.Windows.Forms.TextBox();
         this.initDepositTxtBox = new System.Windows.Forms.TextBox();
         this.lblInitDeposit = new System.Windows.Forms.Label();
         this.pBoxLogo = new System.Windows.Forms.PictureBox();
         this.cBoxType = new System.Windows.Forms.ComboBox();
         this.gBox = new System.Windows.Forms.GroupBox();
         this.rateTxtBox = new System.Windows.Forms.TextBox();
         this.lblInterest = new System.Windows.Forms.Label();
         this.btCancel = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).BeginInit();
         this.gBox.SuspendLayout();
         this.SuspendLayout();
         // 
         // lblNewAccName
         // 
         this.lblNewAccName.AutoSize = true;
         this.lblNewAccName.Location = new System.Drawing.Point(16, 49);
         this.lblNewAccName.Name = "lblNewAccName";
         this.lblNewAccName.Size = new System.Drawing.Size(106, 13);
         this.lblNewAccName.TabIndex = 0;
         this.lblNewAccName.Text = "New Account Name:";
         // 
         // lblNewPw
         // 
         this.lblNewPw.AutoSize = true;
         this.lblNewPw.Location = new System.Drawing.Point(41, 75);
         this.lblNewPw.Name = "lblNewPw";
         this.lblNewPw.Size = new System.Drawing.Size(81, 13);
         this.lblNewPw.TabIndex = 1;
         this.lblNewPw.Text = "New Password:";
         // 
         // btCreate
         // 
         this.btCreate.Location = new System.Drawing.Point(141, 150);
         this.btCreate.Name = "btCreate";
         this.btCreate.Size = new System.Drawing.Size(75, 23);
         this.btCreate.TabIndex = 2;
         this.btCreate.Text = "Create";
         this.btCreate.UseVisualStyleBackColor = true;
         this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
         // 
         // accNameTxtBox
         // 
         this.accNameTxtBox.Location = new System.Drawing.Point(128, 46);
         this.accNameTxtBox.Name = "accNameTxtBox";
         this.accNameTxtBox.Size = new System.Drawing.Size(100, 20);
         this.accNameTxtBox.TabIndex = 3;
         // 
         // pwTxtBox
         // 
         this.pwTxtBox.Location = new System.Drawing.Point(128, 72);
         this.pwTxtBox.Name = "pwTxtBox";
         this.pwTxtBox.Size = new System.Drawing.Size(100, 20);
         this.pwTxtBox.TabIndex = 4;
         // 
         // initDepositTxtBox
         // 
         this.initDepositTxtBox.Location = new System.Drawing.Point(128, 98);
         this.initDepositTxtBox.Name = "initDepositTxtBox";
         this.initDepositTxtBox.Size = new System.Drawing.Size(100, 20);
         this.initDepositTxtBox.TabIndex = 5;
         // 
         // lblInitDeposit
         // 
         this.lblInitDeposit.AutoSize = true;
         this.lblInitDeposit.Location = new System.Drawing.Point(49, 101);
         this.lblInitDeposit.Name = "lblInitDeposit";
         this.lblInitDeposit.Size = new System.Drawing.Size(73, 13);
         this.lblInitDeposit.TabIndex = 6;
         this.lblInitDeposit.Text = "Initial Deposit:";
         // 
         // pBoxLogo
         // 
         this.pBoxLogo.Image = global::p5Bank.Properties.Resources.logo;
         this.pBoxLogo.Location = new System.Drawing.Point(32, 12);
         this.pBoxLogo.Name = "pBoxLogo";
         this.pBoxLogo.Size = new System.Drawing.Size(254, 100);
         this.pBoxLogo.TabIndex = 7;
         this.pBoxLogo.TabStop = false;
         // 
         // cBoxType
         // 
         this.cBoxType.FormattingEnabled = true;
         this.cBoxType.Items.AddRange(new object[] {
            "Checking",
            "Savings"});
         this.cBoxType.Location = new System.Drawing.Point(22, 19);
         this.cBoxType.Name = "cBoxType";
         this.cBoxType.Size = new System.Drawing.Size(206, 21);
         this.cBoxType.TabIndex = 8;
         this.cBoxType.Text = "Select Desired Account Type...";
         this.cBoxType.SelectedIndexChanged += new System.EventHandler(this.cBoxType_SelectedIndexChanged);
         // 
         // gBox
         // 
         this.gBox.Controls.Add(this.btCancel);
         this.gBox.Controls.Add(this.rateTxtBox);
         this.gBox.Controls.Add(this.lblInterest);
         this.gBox.Controls.Add(this.cBoxType);
         this.gBox.Controls.Add(this.lblNewAccName);
         this.gBox.Controls.Add(this.lblNewPw);
         this.gBox.Controls.Add(this.lblInitDeposit);
         this.gBox.Controls.Add(this.btCreate);
         this.gBox.Controls.Add(this.initDepositTxtBox);
         this.gBox.Controls.Add(this.accNameTxtBox);
         this.gBox.Controls.Add(this.pwTxtBox);
         this.gBox.Location = new System.Drawing.Point(32, 118);
         this.gBox.Name = "gBox";
         this.gBox.Size = new System.Drawing.Size(254, 182);
         this.gBox.TabIndex = 9;
         this.gBox.TabStop = false;
         // 
         // rateTxtBox
         // 
         this.rateTxtBox.Location = new System.Drawing.Point(128, 124);
         this.rateTxtBox.Name = "rateTxtBox";
         this.rateTxtBox.Size = new System.Drawing.Size(100, 20);
         this.rateTxtBox.TabIndex = 10;
         // 
         // lblInterest
         // 
         this.lblInterest.AutoSize = true;
         this.lblInterest.Location = new System.Drawing.Point(16, 124);
         this.lblInterest.Name = "lblInterest";
         this.lblInterest.Size = new System.Drawing.Size(0, 13);
         this.lblInterest.TabIndex = 9;
         // 
         // btCancel
         // 
         this.btCancel.Location = new System.Drawing.Point(47, 150);
         this.btCancel.Name = "btCancel";
         this.btCancel.Size = new System.Drawing.Size(75, 23);
         this.btCancel.TabIndex = 11;
         this.btCancel.Text = "Cancel";
         this.btCancel.UseVisualStyleBackColor = true;
         this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
         // 
         // AstralisAccountCreator
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(316, 301);
         this.Controls.Add(this.gBox);
         this.Controls.Add(this.pBoxLogo);
         this.Cursor = System.Windows.Forms.Cursors.Arrow;
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Name = "AstralisAccountCreator";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Astralis Account Creation";
         this.Load += new System.EventHandler(this.AstralisAccountCreator_Load);
         ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).EndInit();
         this.gBox.ResumeLayout(false);
         this.gBox.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Label lblNewAccName;
      private System.Windows.Forms.Label lblNewPw;
      private System.Windows.Forms.Button btCreate;
      private System.Windows.Forms.TextBox accNameTxtBox;
      private System.Windows.Forms.TextBox pwTxtBox;
      private System.Windows.Forms.TextBox initDepositTxtBox;
      private System.Windows.Forms.Label lblInitDeposit;
      private System.Windows.Forms.PictureBox pBoxLogo;
      private System.Windows.Forms.ComboBox cBoxType;
      private System.Windows.Forms.GroupBox gBox;
      private System.Windows.Forms.Label lblInterest;
      private System.Windows.Forms.TextBox rateTxtBox;
      private System.Windows.Forms.Button btCancel;
   }
}