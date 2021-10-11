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
			userLbl.Visible = false;
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
					//CD_Dealership Cd = new CD_Dealership();
					string[] temp = getUser(readAEmployee, SA.getID("SELECT * FROM Login", usernameTxt.Text)).Split(',');

					if (temp[2] == "Manager")
					{
						//CD. .text = "Your are logged in as " + temp[0] + " " + temp[1]; //update
						/*CD.userLbl.Text = HR.*/userLbl.Text = "Your are Logged in as " + temp[0] + " " + temp[1];
						CD.ShowDialog();
						this.Close();
					}
					else if (temp[2] == "HR")
					{
						userLbl.Text = "You are Logged in as " +  temp[0] + " " + temp[1];
						//HR.userL
						HR.ShowDialog();
						this.Close();
					}
					else if (temp[2] == "Admin")
					{
						/*userLbl.Text = HR.*/userLbl.Text = "You are Logged in as " + temp[0] + " " + temp[1];
						CD.ShowDialog();
						this.Close();
					}
					else if (temp[2] == "Sales Manager")
					{
						(new Sales()).ShowDialog();
					}
				}
				else 
				{
					if(usernameTxt.Text == "Employee" || usernameTxt.Text == "employee" && passwordTxt.Text =="0000")
					{
						//insert a graph to show the stats on our business

						(new Results()).ShowDialog();

					}
					else 
					{
						forgotpassLbl.Visible = true;
						if (passwordTxt.Text == string.Empty)
						{
							label4.Visible = true;
						}
						errorProvider1.SetError(passwordTxt, "The password provided is Invalid");
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
