
namespace CD_Dealership
{
	partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.forgotpassLbl = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.showPass = new System.Windows.Forms.Button();
            this.hideBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(147, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "User name:";
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(128, 70);
            this.usernameTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(132, 20);
            this.usernameTxt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(75, 210);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Please Enter your login credentials to login";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(128, 107);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(132, 20);
            this.passwordTxt.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 154);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Sign In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // forgotpassLbl
            // 
            this.forgotpassLbl.AutoSize = true;
            this.forgotpassLbl.Location = new System.Drawing.Point(272, 144);
            this.forgotpassLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.forgotpassLbl.Name = "forgotpassLbl";
            this.forgotpassLbl.Size = new System.Drawing.Size(92, 13);
            this.forgotpassLbl.TabIndex = 8;
            this.forgotpassLbl.Text = "Forgot Password?";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(203, 154);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 38);
            this.button2.TabIndex = 9;
            this.button2.Text = "Sign Up";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // showPass
            // 
            this.showPass.Location = new System.Drawing.Point(264, 105);
            this.showPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(87, 24);
            this.showPass.TabIndex = 10;
            this.showPass.Text = "Show Password";
            this.showPass.UseVisualStyleBackColor = true;
            this.showPass.Click += new System.EventHandler(this.showPass_Click);
            // 
            // hideBttn
            // 
            this.hideBttn.Location = new System.Drawing.Point(264, 104);
            this.hideBttn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hideBttn.Name = "hideBttn";
            this.hideBttn.Size = new System.Drawing.Size(87, 25);
            this.hideBttn.TabIndex = 10;
            this.hideBttn.Text = "Hide Password";
            this.hideBttn.UseVisualStyleBackColor = true;
            this.hideBttn.Click += new System.EventHandler(this.button4_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(385, 255);
            this.Controls.Add(this.showPass);
            this.Controls.Add(this.hideBttn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.forgotpassLbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox usernameTxt;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox passwordTxt;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label forgotpassLbl;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button showPass;
		private System.Windows.Forms.Button hideBttn;
	}
}

