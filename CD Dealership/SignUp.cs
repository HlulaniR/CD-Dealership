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
using System.Drawing.Drawing2D;
using System.Xml;
using System.Configuration;

namespace CD_Dealership
{
	public partial class SignUp : Form
	{
		public SignUp()
		{
			InitializeComponent();
		}
		private SqlConnection con;
		private SqlCommand comm;
		private SqlDataReader dRead;
		private string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nhlul\Desktop\223 Project\CD Dealership\CD Dealership\CDManagementDB.mdf;Integrated Security=True ";
		//private RecoverQuiz question;
		private string recoveryQuiz;
		private string recoveryAnswer;
		private int counter;
		private string userFirstName = null;


		public bool validateID(string userInput)
		{
			bool validity = false;
			con = new SqlConnection(conStr);
			con.Open();

			string readALL = "SELECT * FROM Employees";

			comm = new SqlCommand(readALL, con);
			dRead = comm.ExecuteReader();

			while (dRead.Read())
			{
				if (dRead.GetValue(0).ToString() == userInput)
				{
					validity = true;     // set to true if the ID is in the database
					userFirstName = dRead.GetValue(1).ToString();
					if (dRead.GetValue(8).ToString() != "-1")
					{
						errorProvider1.SetError(userIDTxt, "This Account already exist for this ID, please provide alternative details");
						validity = false;    //set to false if the user already have an account
					}
				}
				counter++;
			}

			con.Close();
			return validity;

		}

		public bool validateUserInput(string userName, string password, string user_confirm)
		{
			int userID;
			bool quiz = false;
				if (int.TryParse(userIDTxt.Text, out userID))
				{
					if (userName != string.Empty)
					{
					string userName =userNm ;
						if (userName != string.Empty && user_confirm != string.Empty)
						{ 
							if(validateID(userIDTxt.Text))
							{
							
							}
						}
				
					}

				}
		}
		public int getID(string querry, string user)
		{
			int counter = 0;

			con = new SqlConnection(conStr);
			con.Open();

			comm = new SqlCommand(querry, con);
			dRead = comm.ExecuteReader();

			while (dRead.Read())
			{
				if (dRead.GetValue(1).ToString() == user)
					counter = int.Parse(dRead.GetValue(0).ToString());
			}
			con.Close();
			return counter
		}

		public int createUser(string readLogin, string querry,string password, string userName)
		{
			con.Open();

			comm = new SqlCommand(querry, con);

			comm.Parameters.AddWithValue("Username", usernameTxt.Text);
			comm.Parameters.AddWithValue("Password", passwordTxt.Text);
			comm.Parameters.AddWithValue("Question", recoveryQuiz);
			comm.Parameters.AddWithValue("Answer", recoveryAnswer);

			comm.ExecuteNonQuery();

			con.Close();

			return getID(readLogin, usernameTxt.Text);
		}


		private void button1_Click(object sender, EventArgs e)
		{
			
			this.Close();
			
			
		}

		private void Form2_Load(object sender, EventArgs e)
		{

		}



		private void button2_Click(object sender, EventArgs e)
		{

			try
			{
				Human_Resource HR = new Human_Resource();
				string userName = usernameTxt.Text;
				string lastName = lastnameTxt.Text;
				string confirm = confirmPassTxt.Text;
				string password = passwordTxt.Text;
				

				//create database to save the usernames and passwords

				string writeLoginTable = "INSERT INTO Login VALUES(@Username, @Password, @Recovery_Question, @Answer)"; //write into the database
				string readLogintable = "SELECT * FROM Login";

				//validate the password

				if (validateUserInput(userName, password, confirm))
				{
					int x = createUser(writeLoginTable, readLogintable, userName, password);
					string updateQueiry = "UPDATE Employees SET UserID = '" + x.ToString() + "' WHERE Id = '" + int.Parse(txtId.Text) + "'";
					HR.updatedata(updateQueiry);
					MessageBox.Show("User Name is Successfully created and saved!");
					this.Close();
				}

			}

			catch (Exception ex)
			{ 
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
			}
			
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void confirmPassTxt_TextChanged(object sender, EventArgs e)
		{

		}

		private void passwordTxt_TextChanged(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void lastnameTxt_TextChanged(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void firstnameTxt_TextChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
