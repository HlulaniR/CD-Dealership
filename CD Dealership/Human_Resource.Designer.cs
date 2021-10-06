
namespace CD_Dealership
{
	partial class Human_Resource
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
			this.employeeGB = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.femaleBttn = new System.Windows.Forms.RadioButton();
			this.maleBttn = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.emailTxt = new System.Windows.Forms.TextBox();
			this.addressTxt = new System.Windows.Forms.TextBox();
			this.phoneNumberTxt = new System.Windows.Forms.TextBox();
			this.surnameTxt = new System.Windows.Forms.TextBox();
			this.nameTxt = new System.Windows.Forms.TextBox();
			this.surnameLbl = new System.Windows.Forms.Label();
			this.nameLbl = new System.Windows.Forms.Label();
			this.dataView = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.button2 = new System.Windows.Forms.Button();
			this.newValueTxt = new System.Windows.Forms.TextBox();
			this.updateIDTxt = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.sortcombo = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.searchCombo = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.valsearchTxt = new System.Windows.Forms.TextBox();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.employeeGB.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// employeeGB
			// 
			this.employeeGB.Controls.Add(this.button1);
			this.employeeGB.Controls.Add(this.label5);
			this.employeeGB.Controls.Add(this.comboBox1);
			this.employeeGB.Controls.Add(this.label4);
			this.employeeGB.Controls.Add(this.label3);
			this.employeeGB.Controls.Add(this.label2);
			this.employeeGB.Controls.Add(this.femaleBttn);
			this.employeeGB.Controls.Add(this.maleBttn);
			this.employeeGB.Controls.Add(this.label1);
			this.employeeGB.Controls.Add(this.emailTxt);
			this.employeeGB.Controls.Add(this.addressTxt);
			this.employeeGB.Controls.Add(this.phoneNumberTxt);
			this.employeeGB.Controls.Add(this.surnameTxt);
			this.employeeGB.Controls.Add(this.nameTxt);
			this.employeeGB.Controls.Add(this.surnameLbl);
			this.employeeGB.Controls.Add(this.nameLbl);
			this.employeeGB.Location = new System.Drawing.Point(12, 27);
			this.employeeGB.Name = "employeeGB";
			this.employeeGB.Size = new System.Drawing.Size(338, 315);
			this.employeeGB.TabIndex = 0;
			this.employeeGB.TabStop = false;
			this.employeeGB.Text = "Add Employee";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(238, 269);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(85, 29);
			this.button1.TabIndex = 10;
			this.button1.Text = "Save";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(67, 242);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(62, 17);
			this.label5.TabIndex = 9;
			this.label5.Text = "Position:";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Sales Manager",
            "Employee",
            "HR"});
			this.comboBox1.Location = new System.Drawing.Point(167, 239);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(156, 24);
			this.comboBox1.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(67, 214);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 17);
			this.label4.TabIndex = 7;
			this.label4.Text = "Address:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(17, 183);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(114, 17);
			this.label3.TabIndex = 6;
			this.label3.Text = "Contact Number:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(85, 152);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "Email:";
			// 
			// femaleBttn
			// 
			this.femaleBttn.AutoSize = true;
			this.femaleBttn.Location = new System.Drawing.Point(191, 124);
			this.femaleBttn.Name = "femaleBttn";
			this.femaleBttn.Size = new System.Drawing.Size(75, 21);
			this.femaleBttn.TabIndex = 4;
			this.femaleBttn.TabStop = true;
			this.femaleBttn.Text = "Female";
			this.femaleBttn.UseVisualStyleBackColor = true;
			// 
			// maleBttn
			// 
			this.maleBttn.AutoSize = true;
			this.maleBttn.Location = new System.Drawing.Point(73, 124);
			this.maleBttn.Name = "maleBttn";
			this.maleBttn.Size = new System.Drawing.Size(59, 21);
			this.maleBttn.TabIndex = 4;
			this.maleBttn.TabStop = true;
			this.maleBttn.Text = "Male";
			this.maleBttn.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(94, 104);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(146, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "Please Select Gender";
			// 
			// emailTxt
			// 
			this.emailTxt.Location = new System.Drawing.Point(167, 152);
			this.emailTxt.Name = "emailTxt";
			this.emailTxt.Size = new System.Drawing.Size(156, 22);
			this.emailTxt.TabIndex = 2;
			// 
			// addressTxt
			// 
			this.addressTxt.Location = new System.Drawing.Point(167, 211);
			this.addressTxt.Name = "addressTxt";
			this.addressTxt.Size = new System.Drawing.Size(156, 22);
			this.addressTxt.TabIndex = 2;
			// 
			// phoneNumberTxt
			// 
			this.phoneNumberTxt.Location = new System.Drawing.Point(167, 183);
			this.phoneNumberTxt.Name = "phoneNumberTxt";
			this.phoneNumberTxt.Size = new System.Drawing.Size(156, 22);
			this.phoneNumberTxt.TabIndex = 2;
			// 
			// surnameTxt
			// 
			this.surnameTxt.Location = new System.Drawing.Point(167, 68);
			this.surnameTxt.Name = "surnameTxt";
			this.surnameTxt.Size = new System.Drawing.Size(156, 22);
			this.surnameTxt.TabIndex = 2;
			// 
			// nameTxt
			// 
			this.nameTxt.Location = new System.Drawing.Point(167, 39);
			this.nameTxt.Name = "nameTxt";
			this.nameTxt.Size = new System.Drawing.Size(156, 22);
			this.nameTxt.TabIndex = 2;
			// 
			// surnameLbl
			// 
			this.surnameLbl.AutoSize = true;
			this.surnameLbl.Location = new System.Drawing.Point(62, 71);
			this.surnameLbl.Name = "surnameLbl";
			this.surnameLbl.Size = new System.Drawing.Size(69, 17);
			this.surnameLbl.TabIndex = 1;
			this.surnameLbl.Text = "Surname:";
			// 
			// nameLbl
			// 
			this.nameLbl.AutoSize = true;
			this.nameLbl.Location = new System.Drawing.Point(82, 42);
			this.nameLbl.Name = "nameLbl";
			this.nameLbl.Size = new System.Drawing.Size(49, 17);
			this.nameLbl.TabIndex = 0;
			this.nameLbl.Text = "Name:";
			// 
			// dataView
			// 
			this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataView.Location = new System.Drawing.Point(12, 348);
			this.dataView.Name = "dataView";
			this.dataView.RowHeadersWidth = 51;
			this.dataView.RowTemplate.Height = 24;
			this.dataView.Size = new System.Drawing.Size(898, 233);
			this.dataView.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.comboBox2);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.newValueTxt);
			this.groupBox1.Controls.Add(this.updateIDTxt);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Location = new System.Drawing.Point(375, 27);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(286, 174);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Update User";
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
            "Firstname",
            "LastName",
            "Gender",
            "Email",
            "Phone_No",
            "Address",
            "Position"});
			this.comboBox2.Location = new System.Drawing.Point(139, 67);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(137, 24);
			this.comboBox2.TabIndex = 3;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(108, 124);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(104, 44);
			this.button2.TabIndex = 3;
			this.button2.Text = "Update and Save";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// newValueTxt
			// 
			this.newValueTxt.Location = new System.Drawing.Point(139, 99);
			this.newValueTxt.Name = "newValueTxt";
			this.newValueTxt.Size = new System.Drawing.Size(137, 22);
			this.newValueTxt.TabIndex = 3;
			// 
			// updateIDTxt
			// 
			this.updateIDTxt.Location = new System.Drawing.Point(139, 39);
			this.updateIDTxt.Name = "updateIDTxt";
			this.updateIDTxt.Size = new System.Drawing.Size(137, 22);
			this.updateIDTxt.TabIndex = 3;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(56, 102);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(77, 17);
			this.label7.TabIndex = 0;
			this.label7.Text = "New value:";
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(42, 42);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(91, 17);
			this.label6.TabIndex = 0;
			this.label6.Text = "Employee ID:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(10, 74);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(123, 17);
			this.label8.TabIndex = 3;
			this.label8.Text = "Column to update:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button3);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Location = new System.Drawing.Point(685, 27);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(225, 174);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Remove user";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.valsearchTxt);
			this.groupBox3.Controls.Add(this.label12);
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Controls.Add(this.searchCombo);
			this.groupBox3.Controls.Add(this.sortcombo);
			this.groupBox3.Location = new System.Drawing.Point(375, 225);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(535, 117);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Sorting";
			this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(6, 42);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(59, 17);
			this.label9.TabIndex = 0;
			this.label9.Text = "User ID:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(99, 39);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(120, 22);
			this.textBox1.TabIndex = 1;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(68, 85);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 34);
			this.button3.TabIndex = 2;
			this.button3.Text = "Delete";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// sortcombo
			// 
			this.sortcombo.FormattingEnabled = true;
			this.sortcombo.Items.AddRange(new object[] {
            "UserID",
            "Firstname",
            "LastName"});
			this.sortcombo.Location = new System.Drawing.Point(108, 21);
			this.sortcombo.Name = "sortcombo";
			this.sortcombo.Size = new System.Drawing.Size(137, 24);
			this.sortcombo.TabIndex = 0;
			this.sortcombo.SelectedIndexChanged += new System.EventHandler(this.sortcombo_SelectedIndexChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(44, 24);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(58, 17);
			this.label10.TabIndex = 3;
			this.label10.Text = "Sort By:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(25, 54);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(77, 17);
			this.label11.TabIndex = 4;
			this.label11.Text = "Search By:";
			// 
			// searchCombo
			// 
			this.searchCombo.FormattingEnabled = true;
			this.searchCombo.Items.AddRange(new object[] {
            "UserID",
            "Firstname ",
            "LastName",
            "Email",
            "Phone No"});
			this.searchCombo.Location = new System.Drawing.Point(108, 54);
			this.searchCombo.Name = "searchCombo";
			this.searchCombo.Size = new System.Drawing.Size(137, 24);
			this.searchCombo.TabIndex = 0;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(256, 27);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(147, 17);
			this.label12.TabIndex = 5;
			this.label12.Text = "Enter value to search:";
			// 
			// valsearchTxt
			// 
			this.valsearchTxt.Location = new System.Drawing.Point(409, 24);
			this.valsearchTxt.Name = "valsearchTxt";
			this.valsearchTxt.Size = new System.Drawing.Size(120, 22);
			this.valsearchTxt.TabIndex = 6;
			this.valsearchTxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(851, 7);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(59, 17);
			this.linkLabel1.TabIndex = 5;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Log Out";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// Human_Resource
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(922, 606);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataView);
			this.Controls.Add(this.employeeGB);
			this.Name = "Human_Resource";
			this.Text = "Human_Resource";
			this.Load += new System.EventHandler(this.Human_Resource_Load);
			this.employeeGB.ResumeLayout(false);
			this.employeeGB.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox employeeGB;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton femaleBttn;
		private System.Windows.Forms.RadioButton maleBttn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox emailTxt;
		private System.Windows.Forms.TextBox addressTxt;
		private System.Windows.Forms.TextBox phoneNumberTxt;
		private System.Windows.Forms.TextBox surnameTxt;
		private System.Windows.Forms.TextBox nameTxt;
		private System.Windows.Forms.Label surnameLbl;
		private System.Windows.Forms.Label nameLbl;
		private System.Windows.Forms.DataGridView dataView;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox updateIDTxt;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox newValueTxt;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox valsearchTxt;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox searchCombo;
		private System.Windows.Forms.ComboBox sortcombo;
		private System.Windows.Forms.LinkLabel linkLabel1;
	}
}