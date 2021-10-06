using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CD_Dealership
{
	public partial class NewPassword : Form
	{
		public NewPassword()
		{
			InitializeComponent();
		}
		public string getPass{get; set;}
		private void button2_Click(object sender, EventArgs e)
		{
			MessageBox.Show("You are about to exit!!");
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			/*if (newpasTxt.PasswordChar == '\0')
			{
				showPass.BringToFront();
				passwordTxt.PasswordChar = '*';
			}*/
			if (newpasTxt.Text == confirmTxt.Text)
			{
				getPass = newpasTxt.Text;
			}
			else { MessageBox.Show("Please Provide passwords that match"); }
		}

		private void showBttn_Click(object sender, EventArgs e)
		{
			/*if (newpasTxt.PasswordChar == '*')
			{
				hideBttn.BringToFront();
				newpasTxt.PasswordChar = '\0';
			}*/
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox2.Checked)
			{
				confirmTxt.PasswordChar = '\0';
			}
			else { confirmTxt.PasswordChar = '*'; }
		}

		private void NewPassword_Load(object sender, EventArgs e)
		{

		}
	}
}
