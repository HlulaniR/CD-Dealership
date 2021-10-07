
namespace CD_Dealership
{
	partial class Sales
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.carNameTxt = new System.Windows.Forms.TextBox();
			this.carModelTxt = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.vinTxt = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.Payment = new System.Windows.Forms.Label();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.vinIDTxt = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Controls.Add(this.Payment);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.vinTxt);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.carModelTxt);
			this.groupBox1.Controls.Add(this.carNameTxt);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(27, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(245, 206);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Add Vehicle";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Car Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(18, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Car Model:";
			// 
			// carNameTxt
			// 
			this.carNameTxt.Location = new System.Drawing.Point(100, 53);
			this.carNameTxt.Name = "carNameTxt";
			this.carNameTxt.Size = new System.Drawing.Size(129, 22);
			this.carNameTxt.TabIndex = 2;
			this.carNameTxt.TextChanged += new System.EventHandler(this.carNameTxt_TextChanged);
			// 
			// carModelTxt
			// 
			this.carModelTxt.Location = new System.Drawing.Point(100, 80);
			this.carModelTxt.Name = "carModelTxt";
			this.carModelTxt.Size = new System.Drawing.Size(129, 22);
			this.carModelTxt.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 29);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 17);
			this.label3.TabIndex = 3;
			this.label3.Text = "VIN Number:";
			// 
			// vinTxt
			// 
			this.vinTxt.Location = new System.Drawing.Point(100, 26);
			this.vinTxt.Name = "vinTxt";
			this.vinTxt.Size = new System.Drawing.Size(129, 22);
			this.vinTxt.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(86, 164);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 38);
			this.button1.TabIndex = 5;
			this.button1.Text = "Add";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Payment
			// 
			this.Payment.AutoSize = true;
			this.Payment.ForeColor = System.Drawing.Color.Red;
			this.Payment.Location = new System.Drawing.Point(83, 105);
			this.Payment.Name = "Payment";
			this.Payment.Size = new System.Drawing.Size(63, 17);
			this.Payment.TabIndex = 6;
			this.Payment.Text = "Payment";
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(53, 125);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(57, 21);
			this.radioButton1.TabIndex = 7;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Paid";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(126, 125);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(83, 21);
			this.radioButton2.TabIndex = 8;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Not Paid";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button2);
			this.groupBox2.Controls.Add(this.vinIDTxt);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Location = new System.Drawing.Point(298, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(251, 204);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Delete SO";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(21, 29);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 17);
			this.label4.TabIndex = 0;
			this.label4.Text = "VIN ID:";
			// 
			// vinIDTxt
			// 
			this.vinIDTxt.Location = new System.Drawing.Point(78, 26);
			this.vinIDTxt.Name = "vinIDTxt";
			this.vinIDTxt.Size = new System.Drawing.Size(146, 22);
			this.vinIDTxt.TabIndex = 1;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(78, 68);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 34);
			this.button2.TabIndex = 2;
			this.button2.Text = "Delete";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// Sales
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(960, 540);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Sales";
			this.Text = "Sales";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox vinTxt;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox carModelTxt;
		private System.Windows.Forms.TextBox carNameTxt;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Label Payment;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox vinIDTxt;
		private System.Windows.Forms.Label label4;
	}
}