namespace p5Bank
{
   partial class Astralis
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
         this.lblUserID = new System.Windows.Forms.Label();
         this.lblPass = new System.Windows.Forms.Label();
         this.userIDTextBox = new System.Windows.Forms.TextBox();
         this.passTxtBox = new System.Windows.Forms.TextBox();
         this.btLogOn = new System.Windows.Forms.Button();
         this.btSignUp = new System.Windows.Forms.Button();
         this.pBoxLogo = new System.Windows.Forms.PictureBox();
         this.gBox = new System.Windows.Forms.GroupBox();
         this.btExit = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).BeginInit();
         this.gBox.SuspendLayout();
         this.SuspendLayout();
         // 
         // lblUserID
         // 
         this.lblUserID.AutoSize = true;
         this.lblUserID.Location = new System.Drawing.Point(52, 40);
         this.lblUserID.Name = "lblUserID";
         this.lblUserID.Size = new System.Drawing.Size(43, 13);
         this.lblUserID.TabIndex = 0;
         this.lblUserID.Text = "UserID:";
         // 
         // lblPass
         // 
         this.lblPass.AutoSize = true;
         this.lblPass.Location = new System.Drawing.Point(39, 66);
         this.lblPass.Name = "lblPass";
         this.lblPass.Size = new System.Drawing.Size(56, 13);
         this.lblPass.TabIndex = 1;
         this.lblPass.Text = "Password:";
         // 
         // userIDTextBox
         // 
         this.userIDTextBox.Location = new System.Drawing.Point(101, 37);
         this.userIDTextBox.Name = "userIDTextBox";
         this.userIDTextBox.Size = new System.Drawing.Size(100, 20);
         this.userIDTextBox.TabIndex = 2;
         // 
         // passTxtBox
         // 
         this.passTxtBox.Location = new System.Drawing.Point(101, 63);
         this.passTxtBox.Name = "passTxtBox";
         this.passTxtBox.Size = new System.Drawing.Size(100, 20);
         this.passTxtBox.TabIndex = 3;
         // 
         // btLogOn
         // 
         this.btLogOn.Location = new System.Drawing.Point(111, 89);
         this.btLogOn.Name = "btLogOn";
         this.btLogOn.Size = new System.Drawing.Size(75, 23);
         this.btLogOn.TabIndex = 4;
         this.btLogOn.Text = "Log On";
         this.btLogOn.UseVisualStyleBackColor = true;
         this.btLogOn.Click += new System.EventHandler(this.btLogOn_Click);
         // 
         // btSignUp
         // 
         this.btSignUp.Location = new System.Drawing.Point(111, 118);
         this.btSignUp.Name = "btSignUp";
         this.btSignUp.Size = new System.Drawing.Size(75, 23);
         this.btSignUp.TabIndex = 5;
         this.btSignUp.Text = "Sign Up";
         this.btSignUp.UseVisualStyleBackColor = true;
         this.btSignUp.Click += new System.EventHandler(this.btSignUp_Click);
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
         // gBox
         // 
         this.gBox.Controls.Add(this.btExit);
         this.gBox.Controls.Add(this.userIDTextBox);
         this.gBox.Controls.Add(this.lblUserID);
         this.gBox.Controls.Add(this.lblPass);
         this.gBox.Controls.Add(this.btSignUp);
         this.gBox.Controls.Add(this.passTxtBox);
         this.gBox.Controls.Add(this.btLogOn);
         this.gBox.Location = new System.Drawing.Point(32, 118);
         this.gBox.Name = "gBox";
         this.gBox.Size = new System.Drawing.Size(254, 182);
         this.gBox.TabIndex = 8;
         this.gBox.TabStop = false;
         // 
         // btExit
         // 
         this.btExit.Location = new System.Drawing.Point(111, 148);
         this.btExit.Name = "btExit";
         this.btExit.Size = new System.Drawing.Size(75, 23);
         this.btExit.TabIndex = 6;
         this.btExit.Text = "Exit";
         this.btExit.UseVisualStyleBackColor = true;
         this.btExit.Click += new System.EventHandler(this.btExit_Click);
         // 
         // Astralis
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(316, 301);
         this.Controls.Add(this.gBox);
         this.Controls.Add(this.pBoxLogo);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Name = "Astralis";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Astralis Bank by Arturo Tenorio";
         ((System.ComponentModel.ISupportInitialize)(this.pBoxLogo)).EndInit();
         this.gBox.ResumeLayout(false);
         this.gBox.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Label lblUserID;
      private System.Windows.Forms.Label lblPass;
      private System.Windows.Forms.TextBox userIDTextBox;
      private System.Windows.Forms.TextBox passTxtBox;
      private System.Windows.Forms.Button btLogOn;
      private System.Windows.Forms.Button btSignUp;
      private System.Windows.Forms.PictureBox pBoxLogo;
      private System.Windows.Forms.GroupBox gBox;
      private System.Windows.Forms.Button btExit;
   }
}

