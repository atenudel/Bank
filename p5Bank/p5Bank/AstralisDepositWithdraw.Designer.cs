namespace p5Bank
{
   partial class AstralisDepositWithdraw
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
         this.pBoxLogo = new System.Windows.Forms.PictureBox();
         this.lblDeposit = new System.Windows.Forms.Label();
         this.lblWithdraw = new System.Windows.Forms.Label();
         this.btConfirm = new System.Windows.Forms.Button();
         this.txtBoxDeposit = new System.Windows.Forms.TextBox();
         this.txtBoxWithdraw = new System.Windows.Forms.TextBox();
         this.gBox = new System.Windows.Forms.GroupBox();
         this.lblBalance = new System.Windows.Forms.Label();
         this.lblName = new System.Windows.Forms.Label();
         this.btLogOut = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).BeginInit();
         this.gBox.SuspendLayout();
         this.SuspendLayout();
         // 
         // pBoxLogo
         // 
         this.pBoxLogo.Image = global::p5Bank.Properties.Resources.logo;
         this.pBoxLogo.Location = new System.Drawing.Point(32, 12);
         this.pBoxLogo.Name = "pBoxLogo";
         this.pBoxLogo.Size = new System.Drawing.Size(254, 100);
         this.pBoxLogo.TabIndex = 0;
         this.pBoxLogo.TabStop = false;
         // 
         // lblDeposit
         // 
         this.lblDeposit.AutoSize = true;
         this.lblDeposit.Location = new System.Drawing.Point(36, 63);
         this.lblDeposit.Name = "lblDeposit";
         this.lblDeposit.Size = new System.Drawing.Size(85, 13);
         this.lblDeposit.TabIndex = 1;
         this.lblDeposit.Text = "Deposit Amount:";
         // 
         // lblWithdraw
         // 
         this.lblWithdraw.AutoSize = true;
         this.lblWithdraw.Location = new System.Drawing.Point(19, 88);
         this.lblWithdraw.Name = "lblWithdraw";
         this.lblWithdraw.Size = new System.Drawing.Size(102, 13);
         this.lblWithdraw.TabIndex = 2;
         this.lblWithdraw.Text = "Withdrawal Amount:";
         // 
         // btConfirm
         // 
         this.btConfirm.Location = new System.Drawing.Point(88, 121);
         this.btConfirm.Name = "btConfirm";
         this.btConfirm.Size = new System.Drawing.Size(75, 23);
         this.btConfirm.TabIndex = 3;
         this.btConfirm.Text = "Confirm";
         this.btConfirm.UseVisualStyleBackColor = true;
         this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
         // 
         // txtBoxDeposit
         // 
         this.txtBoxDeposit.Location = new System.Drawing.Point(129, 60);
         this.txtBoxDeposit.Name = "txtBoxDeposit";
         this.txtBoxDeposit.Size = new System.Drawing.Size(100, 20);
         this.txtBoxDeposit.TabIndex = 4;
         // 
         // txtBoxWithdraw
         // 
         this.txtBoxWithdraw.Location = new System.Drawing.Point(129, 88);
         this.txtBoxWithdraw.Name = "txtBoxWithdraw";
         this.txtBoxWithdraw.Size = new System.Drawing.Size(100, 20);
         this.txtBoxWithdraw.TabIndex = 5;
         // 
         // gBox
         // 
         this.gBox.Controls.Add(this.btLogOut);
         this.gBox.Controls.Add(this.lblBalance);
         this.gBox.Controls.Add(this.lblName);
         this.gBox.Controls.Add(this.lblDeposit);
         this.gBox.Controls.Add(this.txtBoxWithdraw);
         this.gBox.Controls.Add(this.lblWithdraw);
         this.gBox.Controls.Add(this.txtBoxDeposit);
         this.gBox.Controls.Add(this.btConfirm);
         this.gBox.Location = new System.Drawing.Point(32, 118);
         this.gBox.Name = "gBox";
         this.gBox.Size = new System.Drawing.Size(254, 182);
         this.gBox.TabIndex = 6;
         this.gBox.TabStop = false;
         // 
         // lblBalance
         // 
         this.lblBalance.Location = new System.Drawing.Point(36, 41);
         this.lblBalance.Name = "lblBalance";
         this.lblBalance.Size = new System.Drawing.Size(190, 13);
         this.lblBalance.TabIndex = 7;
         this.lblBalance.Text = "Current Balance:";
         // 
         // lblName
         // 
         this.lblName.AutoSize = true;
         this.lblName.Location = new System.Drawing.Point(57, 18);
         this.lblName.Name = "lblName";
         this.lblName.Size = new System.Drawing.Size(0, 13);
         this.lblName.TabIndex = 6;
         // 
         // btLogOut
         // 
         this.btLogOut.Location = new System.Drawing.Point(88, 150);
         this.btLogOut.Name = "btLogOut";
         this.btLogOut.Size = new System.Drawing.Size(75, 23);
         this.btLogOut.TabIndex = 8;
         this.btLogOut.Text = "Log Out";
         this.btLogOut.UseVisualStyleBackColor = true;
         this.btLogOut.Click += new System.EventHandler(this.btLogOut_Click);
         // 
         // AstralisDepositWithdraw
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(316, 301);
         this.Controls.Add(this.gBox);
         this.Controls.Add(this.pBoxLogo);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Name = "AstralisDepositWithdraw";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Astralis Deposit and Withdraw";
         ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).EndInit();
         this.gBox.ResumeLayout(false);
         this.gBox.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.PictureBox pBoxLogo;
      private System.Windows.Forms.Label lblDeposit;
      private System.Windows.Forms.Label lblWithdraw;
      private System.Windows.Forms.Button btConfirm;
      private System.Windows.Forms.TextBox txtBoxDeposit;
      private System.Windows.Forms.TextBox txtBoxWithdraw;
      private System.Windows.Forms.GroupBox gBox;
      private System.Windows.Forms.Label lblName;
      private System.Windows.Forms.Label lblBalance;
      private System.Windows.Forms.Button btLogOut;
   }
}