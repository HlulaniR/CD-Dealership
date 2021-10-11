
namespace CD_Dealership
{
	partial class Client
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
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.SortcomboBox = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnDelete = new System.Windows.Forms.Button();
			this.deleteTxt = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.newValTxt = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.columnComboBox = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtIdUp = new System.Windows.Forms.TextBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.addressTxt = new System.Windows.Forms.TextBox();
			this.txtPN = new System.Windows.Forms.TextBox();
			this.emailTxt = new System.Windows.Forms.TextBox();
			this.surnameTxt = new System.Windows.Forms.TextBox();
			this.nameTxt = new System.Windows.Forms.TextBox();
			this.FRadioButton = new System.Windows.Forms.RadioButton();
			this.MRadioButton = new System.Windows.Forms.RadioButton();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.lblFN = new System.Windows.Forms.Label();
			this.dataView = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox2
			// 
			this.textBox2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.textBox2.Location = new System.Drawing.Point(128, 86);
			this.textBox2.Margin = new System.Windows.Forms.Padding(4);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(151, 22);
			this.textBox2.TabIndex = 32;
			this.textBox2.Text = "Enter value to search";
			// 
			// comboBox2
			// 
			this.comboBox2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
            "Id",
            "FirstName ",
            "LastName",
            "Email",
            "Phone_No",
            "Address"});
			this.comboBox2.Location = new System.Drawing.Point(128, 54);
			this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(151, 24);
			this.comboBox2.TabIndex = 31;
			// 
			// SortcomboBox
			// 
			this.SortcomboBox.BackColor = System.Drawing.SystemColors.Window;
			this.SortcomboBox.ForeColor = System.Drawing.SystemColors.ButtonShadow;
			this.SortcomboBox.FormattingEnabled = true;
			this.SortcomboBox.Items.AddRange(new object[] {
            "FirstName",
            "LastName"});
			this.SortcomboBox.Location = new System.Drawing.Point(127, 22);
			this.SortcomboBox.Margin = new System.Windows.Forms.Padding(4);
			this.SortcomboBox.Name = "SortcomboBox";
			this.SortcomboBox.Size = new System.Drawing.Size(152, 24);
			this.SortcomboBox.TabIndex = 30;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnDelete);
			this.groupBox1.Controls.Add(this.deleteTxt);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(578, 57);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(267, 182);
			this.groupBox1.TabIndex = 29;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Delete Supplier";
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(81, 85);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(100, 28);
			this.btnDelete.TabIndex = 2;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// deleteTxt
			// 
			this.deleteTxt.Location = new System.Drawing.Point(81, 38);
			this.deleteTxt.Margin = new System.Windows.Forms.Padding(4);
			this.deleteTxt.Name = "deleteTxt";
			this.deleteTxt.Size = new System.Drawing.Size(132, 22);
			this.deleteTxt.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(45, 47);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(25, 17);
			this.label3.TabIndex = 0;
			this.label3.Text = "ID:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.newValTxt);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.btnUpdate);
			this.groupBox2.Controls.Add(this.columnComboBox);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.txtIdUp);
			this.groupBox2.Location = new System.Drawing.Point(302, 56);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox2.Size = new System.Drawing.Size(267, 183);
			this.groupBox2.TabIndex = 28;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Update Supplier";
			// 
			// newValTxt
			// 
			this.newValTxt.Location = new System.Drawing.Point(105, 100);
			this.newValTxt.Margin = new System.Windows.Forms.Padding(4);
			this.newValTxt.Name = "newValTxt";
			this.newValTxt.Size = new System.Drawing.Size(152, 22);
			this.newValTxt.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(5, 108);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "New value:";
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(62, 136);
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
            "Firstname",
            "Lastname",
            "gender",
            "Email",
            "Phone_Number",
            "Address"});
			this.columnComboBox.Location = new System.Drawing.Point(105, 66);
			this.columnComboBox.Margin = new System.Windows.Forms.Padding(4);
			this.columnComboBox.Name = "columnComboBox";
			this.columnComboBox.Size = new System.Drawing.Size(152, 24);
			this.columnComboBox.TabIndex = 0;
			this.columnComboBox.Text = "Column to update";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(59, 43);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(25, 17);
			this.label4.TabIndex = 1;
			this.label4.Tag = "";
			this.label4.Text = "ID:";
			// 
			// txtIdUp
			// 
			this.txtIdUp.Location = new System.Drawing.Point(105, 34);
			this.txtIdUp.Margin = new System.Windows.Forms.Padding(4);
			this.txtIdUp.Name = "txtIdUp";
			this.txtIdUp.Size = new System.Drawing.Size(152, 22);
			this.txtIdUp.TabIndex = 2;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.btnAdd);
			this.groupBox4.Controls.Add(this.addressTxt);
			this.groupBox4.Controls.Add(this.txtPN);
			this.groupBox4.Controls.Add(this.emailTxt);
			this.groupBox4.Controls.Add(this.surnameTxt);
			this.groupBox4.Controls.Add(this.nameTxt);
			this.groupBox4.Controls.Add(this.FRadioButton);
			this.groupBox4.Controls.Add(this.MRadioButton);
			this.groupBox4.Controls.Add(this.label7);
			this.groupBox4.Controls.Add(this.label6);
			this.groupBox4.Controls.Add(this.label5);
			this.groupBox4.Controls.Add(this.label8);
			this.groupBox4.Controls.Add(this.lblFN);
			this.groupBox4.Location = new System.Drawing.Point(27, 57);
			this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox4.Size = new System.Drawing.Size(267, 304);
			this.groupBox4.TabIndex = 27;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Add Supplier";
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(86, 233);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(100, 28);
			this.btnAdd.TabIndex = 12;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// addressTxt
			// 
			this.addressTxt.Location = new System.Drawing.Point(125, 187);
			this.addressTxt.Margin = new System.Windows.Forms.Padding(4);
			this.addressTxt.Name = "addressTxt";
			this.addressTxt.Size = new System.Drawing.Size(132, 22);
			this.addressTxt.TabIndex = 11;
			// 
			// txtPN
			// 
			this.txtPN.Location = new System.Drawing.Point(125, 155);
			this.txtPN.Margin = new System.Windows.Forms.Padding(4);
			this.txtPN.Name = "txtPN";
			this.txtPN.Size = new System.Drawing.Size(132, 22);
			this.txtPN.TabIndex = 10;
			// 
			// emailTxt
			// 
			this.emailTxt.Location = new System.Drawing.Point(125, 126);
			this.emailTxt.Margin = new System.Windows.Forms.Padding(4);
			this.emailTxt.Name = "emailTxt";
			this.emailTxt.Size = new System.Drawing.Size(132, 22);
			this.emailTxt.TabIndex = 9;
			// 
			// surnameTxt
			// 
			this.surnameTxt.Location = new System.Drawing.Point(125, 55);
			this.surnameTxt.Margin = new System.Windows.Forms.Padding(4);
			this.surnameTxt.Name = "surnameTxt";
			this.surnameTxt.Size = new System.Drawing.Size(132, 22);
			this.surnameTxt.TabIndex = 8;
			// 
			// nameTxt
			// 
			this.nameTxt.Location = new System.Drawing.Point(125, 23);
			this.nameTxt.Margin = new System.Windows.Forms.Padding(4);
			this.nameTxt.Name = "nameTxt";
			this.nameTxt.Size = new System.Drawing.Size(132, 22);
			this.nameTxt.TabIndex = 7;
			// 
			// FRadioButton
			// 
			this.FRadioButton.AutoSize = true;
			this.FRadioButton.Location = new System.Drawing.Point(145, 98);
			this.FRadioButton.Margin = new System.Windows.Forms.Padding(4);
			this.FRadioButton.Name = "FRadioButton";
			this.FRadioButton.Size = new System.Drawing.Size(75, 21);
			this.FRadioButton.TabIndex = 6;
			this.FRadioButton.TabStop = true;
			this.FRadioButton.Text = "Female";
			this.FRadioButton.UseVisualStyleBackColor = true;
			// 
			// MRadioButton
			// 
			this.MRadioButton.AutoSize = true;
			this.MRadioButton.Location = new System.Drawing.Point(33, 98);
			this.MRadioButton.Margin = new System.Windows.Forms.Padding(4);
			this.MRadioButton.Name = "MRadioButton";
			this.MRadioButton.Size = new System.Drawing.Size(59, 21);
			this.MRadioButton.TabIndex = 5;
			this.MRadioButton.TabStop = true;
			this.MRadioButton.Text = "Male\r\n";
			this.MRadioButton.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(47, 196);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(64, 17);
			this.label7.TabIndex = 4;
			this.label7.Text = "Address:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(8, 165);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(107, 17);
			this.label6.TabIndex = 3;
			this.label6.Text = "Phone Number:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(69, 135);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(46, 17);
			this.label5.TabIndex = 2;
			this.label5.Text = "Email:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(47, 65);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(69, 17);
			this.label8.TabIndex = 1;
			this.label8.Text = "Surname:";
			// 
			// lblFN
			// 
			this.lblFN.AutoSize = true;
			this.lblFN.Location = new System.Drawing.Point(65, 33);
			this.lblFN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblFN.Name = "lblFN";
			this.lblFN.Size = new System.Drawing.Size(49, 17);
			this.lblFN.TabIndex = 0;
			this.lblFN.Text = "Name:";
			// 
			// dataView
			// 
			this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataView.Location = new System.Drawing.Point(27, 368);
			this.dataView.Margin = new System.Windows.Forms.Padding(4);
			this.dataView.Name = "dataView";
			this.dataView.RowHeadersWidth = 51;
			this.dataView.Size = new System.Drawing.Size(818, 274);
			this.dataView.TabIndex = 26;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label1.Location = new System.Drawing.Point(343, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 29);
			this.label1.TabIndex = 33;
			this.label1.Text = "Clients";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.SortcomboBox);
			this.groupBox3.Controls.Add(this.comboBox2);
			this.groupBox3.Controls.Add(this.textBox2);
			this.groupBox3.Location = new System.Drawing.Point(301, 246);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(543, 115);
			this.groupBox3.TabIndex = 34;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Sorting";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(60, 25);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(58, 17);
			this.label9.TabIndex = 33;
			this.label9.Text = "Sort By:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(44, 57);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(77, 17);
			this.label10.TabIndex = 34;
			this.label10.Text = "Search By:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(8, 89);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(113, 17);
			this.label11.TabIndex = 35;
			this.label11.Text = "Value to Search:";
			// 
			// Client
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(868, 654);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.dataView);
			this.Name = "Client";
			this.Text = "Client";
			this.Load += new System.EventHandler(this.Client_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox SortcomboBox;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.TextBox deleteTxt;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox newValTxt;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.ComboBox columnComboBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtIdUp;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.TextBox addressTxt;
		private System.Windows.Forms.TextBox txtPN;
		private System.Windows.Forms.TextBox emailTxt;
		private System.Windows.Forms.TextBox surnameTxt;
		private System.Windows.Forms.TextBox nameTxt;
		private System.Windows.Forms.RadioButton FRadioButton;
		private System.Windows.Forms.RadioButton MRadioButton;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lblFN;
		private System.Windows.Forms.DataGridView dataView;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
	}
}