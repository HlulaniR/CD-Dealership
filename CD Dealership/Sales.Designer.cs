
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
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.txtNewVal = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.columnComboBox = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtIdUp = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
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
			this.groupBox1.Size = new System.Drawing.Size(245, 237);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Add Vehicle";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
			this.groupBox2.Location = new System.Drawing.Point(305, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(288, 118);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Delete SO";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(78, 61);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 34);
			this.button2.TabIndex = 2;
			this.button2.Text = "Delete";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
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
			this.dataView.Location = new System.Drawing.Point(27, 266);
			this.dataView.Name = "dataView";
			this.dataView.RowHeadersWidth = 51;
			this.dataView.RowTemplate.Height = 24;
			this.dataView.Size = new System.Drawing.Size(901, 245);
			this.dataView.TabIndex = 2;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.comboBox3);
			this.groupBox3.Controls.Add(this.comboBox2);
			this.groupBox3.Controls.Add(this.textBox1);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Location = new System.Drawing.Point(305, 135);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(288, 114);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Sort";
			this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.txtNewVal);
			this.groupBox4.Controls.Add(this.label2);
			this.groupBox4.Controls.Add(this.btnUpdate);
			this.groupBox4.Controls.Add(this.columnComboBox);
			this.groupBox4.Controls.Add(this.label6);
			this.groupBox4.Controls.Add(this.txtIdUp);
			this.groupBox4.Location = new System.Drawing.Point(634, 12);
			this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox4.Size = new System.Drawing.Size(267, 154);
			this.groupBox4.TabIndex = 13;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Update SO";
			// 
			// txtNewVal
			// 
			this.txtNewVal.Location = new System.Drawing.Point(107, 85);
			this.txtNewVal.Margin = new System.Windows.Forms.Padding(4);
			this.txtNewVal.Name = "txtNewVal";
			this.txtNewVal.Size = new System.Drawing.Size(152, 22);
			this.txtNewVal.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 88);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "New value:";
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(79, 115);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(124, 28);
			this.btnUpdate.TabIndex = 4;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// columnComboBox
			// 
			this.columnComboBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.columnComboBox.FormattingEnabled = true;
			this.columnComboBox.Items.AddRange(new object[] {
            "Quantity",
            "Status"});
			this.columnComboBox.Location = new System.Drawing.Point(107, 54);
			this.columnComboBox.Margin = new System.Windows.Forms.Padding(4);
			this.columnComboBox.Name = "columnComboBox";
			this.columnComboBox.Size = new System.Drawing.Size(152, 24);
			this.columnComboBox.TabIndex = 0;
			this.columnComboBox.Text = "Column to update";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(61, 29);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(25, 17);
			this.label6.TabIndex = 1;
			this.label6.Tag = "";
			this.label6.Text = "ID:";
			// 
			// txtIdUp
			// 
			this.txtIdUp.Location = new System.Drawing.Point(107, 29);
			this.txtIdUp.Margin = new System.Windows.Forms.Padding(4);
			this.txtIdUp.Name = "txtIdUp";
			this.txtIdUp.Size = new System.Drawing.Size(152, 22);
			this.txtIdUp.TabIndex = 2;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(61, 22);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(58, 17);
			this.label7.TabIndex = 0;
			this.label7.Text = "Sort By:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(42, 51);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(77, 17);
			this.label8.TabIndex = 1;
			this.label8.Text = "Search By:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(6, 80);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(113, 17);
			this.label9.TabIndex = 2;
			this.label9.Text = "Value to Search:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(125, 80);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(149, 22);
			this.textBox1.TabIndex = 3;
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(124, 48);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(150, 24);
			this.comboBox2.TabIndex = 4;
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(124, 18);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(150, 24);
			this.comboBox3.TabIndex = 5;
			// 
			// Sales
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(960, 540);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.dataView);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Sales";
			this.Text = "Sales";
			this.Load += new System.EventHandler(this.Sales_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
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
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox txtNewVal;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.ComboBox columnComboBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtIdUp;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
	}
}