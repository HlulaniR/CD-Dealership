
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
			this.notPaidRB = new System.Windows.Forms.RadioButton();
			this.paidRB = new System.Windows.Forms.RadioButton();
			this.Payment = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.vinTxt = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.carNameTxt = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.vinIDTxt = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.qtyTxt = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.dataView = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.notPaidRB);
			this.groupBox1.Controls.Add(this.paidRB);
			this.groupBox1.Controls.Add(this.Payment);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.qtyTxt);
			this.groupBox1.Controls.Add(this.vinTxt);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.carNameTxt);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(27, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(245, 260);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Add Vehicle";
			// 
			// notPaidRB
			// 
			this.notPaidRB.AutoSize = true;
			this.notPaidRB.Location = new System.Drawing.Point(125, 157);
			this.notPaidRB.Name = "notPaidRB";
			this.notPaidRB.Size = new System.Drawing.Size(83, 21);
			this.notPaidRB.TabIndex = 8;
			this.notPaidRB.TabStop = true;
			this.notPaidRB.Text = "Not Paid";
			this.notPaidRB.UseVisualStyleBackColor = true;
			// 
			// paidRB
			// 
			this.paidRB.AutoSize = true;
			this.paidRB.Location = new System.Drawing.Point(52, 157);
			this.paidRB.Name = "paidRB";
			this.paidRB.Size = new System.Drawing.Size(57, 21);
			this.paidRB.TabIndex = 7;
			this.paidRB.TabStop = true;
			this.paidRB.Text = "Paid";
			this.paidRB.UseVisualStyleBackColor = true;
			// 
			// Payment
			// 
			this.Payment.AutoSize = true;
			this.Payment.ForeColor = System.Drawing.Color.Red;
			this.Payment.Location = new System.Drawing.Point(82, 137);
			this.Payment.Name = "Payment";
			this.Payment.Size = new System.Drawing.Size(63, 17);
			this.Payment.TabIndex = 6;
			this.Payment.Text = "Payment";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(85, 184);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 38);
			this.button1.TabIndex = 5;
			this.button1.Text = "Add";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// vinTxt
			// 
			this.vinTxt.Location = new System.Drawing.Point(99, 58);
			this.vinTxt.Name = "vinTxt";
			this.vinTxt.Size = new System.Drawing.Size(129, 22);
			this.vinTxt.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(5, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 17);
			this.label3.TabIndex = 3;
			this.label3.Text = "VIN Number:";
			// 
			// carNameTxt
			// 
			this.carNameTxt.Location = new System.Drawing.Point(99, 85);
			this.carNameTxt.Name = "carNameTxt";
			this.carNameTxt.Size = new System.Drawing.Size(129, 22);
			this.carNameTxt.TabIndex = 2;
			this.carNameTxt.TextChanged += new System.EventHandler(this.carNameTxt_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 88);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Car Name:";
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
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(78, 68);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 34);
			this.button2.TabIndex = 2;
			this.button2.Text = "Delete";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// vinIDTxt
			// 
			this.vinIDTxt.Location = new System.Drawing.Point(78, 26);
			this.vinIDTxt.Name = "vinIDTxt";
			this.vinIDTxt.Size = new System.Drawing.Size(146, 22);
			this.vinIDTxt.TabIndex = 1;
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
			// qtyTxt
			// 
			this.qtyTxt.Location = new System.Drawing.Point(99, 29);
			this.qtyTxt.Name = "qtyTxt";
			this.qtyTxt.Size = new System.Drawing.Size(129, 22);
			this.qtyTxt.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(17, 34);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(65, 17);
			this.label5.TabIndex = 9;
			this.label5.Text = "Quantity:";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(20, 113);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(207, 24);
			this.comboBox1.TabIndex = 10;
			this.comboBox1.Text = "Please Select the car brand";
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// dataView
			// 
			this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataView.Location = new System.Drawing.Point(27, 313);
			this.dataView.Name = "dataView";
			this.dataView.RowHeadersWidth = 51;
			this.dataView.RowTemplate.Height = 24;
			this.dataView.Size = new System.Drawing.Size(901, 200);
			this.dataView.TabIndex = 2;
			// 
			// Sales
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(960, 540);
			this.Controls.Add(this.dataView);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Sales";
			this.Text = "Sales";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox vinTxt;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox carNameTxt;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton notPaidRB;
		private System.Windows.Forms.RadioButton paidRB;
		private System.Windows.Forms.Label Payment;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox vinIDTxt;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox qtyTxt;
		private System.Windows.Forms.DataGridView dataView;
	}
}