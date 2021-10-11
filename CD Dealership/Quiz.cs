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
	public partial class Quiz : Form
	{
		public Quiz()
		{
			InitializeComponent();
		}
		string[] temp;
		private SqlConnection con;
		private SqlCommand comm;
		private SqlDataReader dr;

		
		private string userNM;

		private string conStr = @" Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nhlul\Desktop\223 Project\CD Dealership\CD Dealership\CDManagementDB.mdf;Integrated Security=True";

		private void Quiz_Load(object sender, EventArgs e)
		{
			//open up the forget form
			Forget_Password FP = new Forget_Password();
			FP.ShowDialog();

			if (searchUser(FP.getNM))
			{
				lblQuestion.Text = temp[1];
			}

			else
			{ MessageBox.Show("Username not found. Try Again"); }


		}


		public bool searchUser(string user)
		{
			bool found = false;
			con = new SqlConnection(conStr);
			con.Open();
			comm = new SqlCommand("SELECT * FROM Login", con);
			dr = comm.ExecuteReader();
			

			while (dr.Read())
			{
				if (dr.GetValue(1).ToString() == user)
				{
					temp = (dr.GetValue(0).ToString() + "," + dr.GetValue(3).ToString() + "," + dr.GetValue(4).ToString()).Split(',');
					found = true;
				}
			
			}

				return found;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (temp[2] == quizAnswer.Text)
			{
				Human_Resource HR = new Human_Resource();
				NewPassword np = new NewPassword();

				np.ShowDialog();
				MessageBox.Show(np.getPass);

				string updateQuerry = "Update Login SET Password = '" + np.getPass + "'WHERE UserID = ' " + int.Parse(temp[0] + "'");

				HR.update(updateQuerry);
				MessageBox.Show("Password is successfully created!");

				this.Close();
			}
			else 
			{
				errorProvider1.SetError(quizAnswer,"Please provide the correct answer!");
			}
		}
	}
}
