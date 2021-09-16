using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CD_Dealership
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void showPass_Click(object sender, EventArgs e)
		{
			if (passwordTxt.PasswordChar == '*')
			{
				hideBttn.BringToFront();
				passwordTxt.PasswordChar = '\0';
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (passwordTxt.PasswordChar == '\0')
			{
				showPass.BringToFront();
				passwordTxt.PasswordChar = '*';
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form2 s1 = new Form2();
			s1.Show();
		}
	}
}
