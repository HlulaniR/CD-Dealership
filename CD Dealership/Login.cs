using System;
using System.CodeDom.Compiler;
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
		private SqlConnection con;
		private SqlCommand comm;
		private SqlDataReader dRead;
		private int UserID;

		string readAll = "SELECT * FROM Login";
		string readAEmployee = "SELECT * FROM Employees";

		string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nhlul\Desktop\223 Project\CD Dealership\CD Dealership\CDManagementDB.mdf;Integrated Security=True";
		private void Form1_Load(object sender, EventArgs e)
		{

		}
		public bool authenticate(string userName, string password, ref int user)
		{
			bool results = false;
			con = new SqlConnection(conStr);

			con.Open();
			comm = new SqlCommand(readAll, con);
			dRead = comm.ExecuteReader();

			while (dRead.Read())
			{
				if (dRead.GetValue(1).ToString() == userName && dRead.GetValue(2).ToString() == password)
				{
					results = true;
					user = int.Parse(dRead.GetValue(0).ToString());
				}
			}

			if (!results)
			{
				forgotpassLbl.Visible = true;
			}
			con.Close();

			return results;
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
			SignUp s1 = new SignUp();
			s1.Show();
		}

		public string getUser(string querry, int id)
		{
			string detail = null;
			con.Open();
			dRead = (new SqlCommand(querry, con)).ExecuteReader();


			//while(read())
			while (dRead.Read())
			{
				//if(id.ToString()==dRead.GetValue(8).ToString())
				if (dRead.GetValue(8).ToString() == id.ToString())
				{
					//detail += dRead.GetValue(1).ToString() ;
					detail += dRead.GetValue(1).ToString() + "," + dRead.GetValue(2).ToString() + "," + dRead.GetValue(7).ToString();

				}
			}
			return detail;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try 
			{
				CD_Dealership CD = new CD_Dealership(); // create a form for Cd dealership
				SignUp SA = new SignUp();
				Human_Resource HR = new Human_Resource();

				if (authenticate(usernameTxt.Text, passwordTxt.Text, ref UserID))
				{
					//CD_Dealership CD = new CD_Dealership();
					string[] temp = getUser(readAEmployee, SA.getID("SELECT * FROM Login", usernameTxt.Text)).Split(',');

					if (temp[2] == "Manager")
					{
						//CD. .text = "Your are logged in as " + temp[0] + " " + temp[1]; //update
						CD.ShowDialog();
						this.Close();
					}
					else if (temp[2] == "HR")
					{

						HR.ShowDialog();
						this.Close();
					}
					else if (temp[2] == "Admin")
					{
						
						CD.ShowDialog();
						this.Close();
					}
					else if (temp[2] == "Sales Manager")
					{
						(new Sales()).ShowDialog();
					}
				}


			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void forgotpassLbl_Click(object sender, EventArgs e)
		{
			Quiz forgotPassword = new Quiz();
			forgotPassword.ShowDialog();
		}
	}
}
