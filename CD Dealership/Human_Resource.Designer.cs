
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
			this.nameLbl = new System.Windows.Forms.Label();
			this.surnameLbl = new System.Windows.Forms.Label();
			this.nameTxt = new System.Windows.Forms.TextBox();
			this.surnameTxt = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.maleBttn = new System.Windows.Forms.RadioButton();
			this.femaleBttn = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.phoneNumberTxt = new System.Windows.Forms.TextBox();
			this.emailTxt = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.addressTxt = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.dataView = new System.Windows.Forms.DataGridView();
			this.employeeGB.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
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
			this.employeeGB.Location = new System.Drawing.Point(39, 49);
			this.employeeGB.Name = "employeeGB";
			this.employeeGB.Size = new System.Drawing.Size(350, 315);
			this.employeeGB.TabIndex = 0;
			this.employeeGB.TabStop = false;
			this.employeeGB.Text = "Add Employee";
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
			// surnameLbl
			// 
			this.surnameLbl.AutoSize = true;
			this.surnameLbl.Location = new System.Drawing.Point(62, 71);
			this.surnameLbl.Name = "surnameLbl";
			this.surnameLbl.Size = new System.Drawing.Size(69, 17);
			this.surnameLbl.TabIndex = 1;
			this.surnameLbl.Text = "Surname:";
			// 
			// nameTxt
			// 
			this.nameTxt.Location = new System.Drawing.Point(167, 39);
			this.nameTxt.Name = "nameTxt";
			this.nameTxt.Size = new System.Drawing.Size(156, 22);
			this.nameTxt.TabIndex = 2;
			// 
			// surnameTxt
			// 
			this.surnameTxt.Location = new System.Drawing.Point(167, 68);
			this.surnameTxt.Name = "surnameTxt";
			this.surnameTxt.Size = new System.Drawing.Size(156, 22);
			this.surnameTxt.TabIndex = 2;
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
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(85, 152);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "Email:";
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
			// phoneNumberTxt
			// 
			this.phoneNumberTxt.Location = new System.Drawing.Point(167, 183);
			this.phoneNumberTxt.Name = "phoneNumberTxt";
			this.phoneNumberTxt.Size = new System.Drawing.Size(156, 22);
			this.phoneNumberTxt.TabIndex = 2;
			// 
			// emailTxt
			// 
			this.emailTxt.Location = new System.Drawing.Point(167, 152);
			this.emailTxt.Name = "emailTxt";
			this.emailTxt.Size = new System.Drawing.Size(156, 22);
			this.emailTxt.TabIndex = 2;
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
			// addressTxt
			// 
			this.addressTxt.Location = new System.Drawing.Point(167, 211);
			this.addressTxt.Name = "addressTxt";
			this.addressTxt.Size = new System.Drawing.Size(156, 22);
			this.addressTxt.TabIndex = 2;
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
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(67, 242);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(62, 17);
			this.label5.TabIndex = 9;
			this.label5.Text = "Position:";
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
			// dataView
			// 
			this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataView.Location = new System.Drawing.Point(39, 370);
			this.dataView.Name = "dataView";
			this.dataView.RowHeadersWidth = 51;
			this.dataView.RowTemplate.Height = 24;
			this.dataView.Size = new System.Drawing.Size(802, 206);
			this.dataView.TabIndex = 1;
			// 
			// Human_Resource
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(877, 576);
			this.Controls.Add(this.dataView);
			this.Controls.Add(this.employeeGB);
			this.Name = "Human_Resource";
			this.Text = "Human_Resource";
			this.Load += new System.EventHandler(this.Human_Resource_Load);
			this.employeeGB.ResumeLayout(false);
			this.employeeGB.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
			this.ResumeLayout(false);

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
	}
}