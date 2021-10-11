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
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Security.Permissions;

namespace CD_Dealership
{
	public partial class Human_Resource : Form
	{
		public Human_Resource()
		{
			InitializeComponent();
		}
		private SqlConnection con;
		private SqlCommand comm;
		private DataSet ds;
		private SqlDataAdapter adp;
		private string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nhlul\Desktop\223 Project\CD Dealership\CD Dealership\CDManagementDB.mdf;Integrated Security = True"; //open our database
		private const string readEmployees = "SELECt UserID, Email, Firstname, LastName, Gender, Phone_No, Position, Address  FROM Employees"; //read from our employee datatbase


		private void Human_Resource_Load(object sender, EventArgs e)
		{
			readAll(readEmployees);
		}
		public bool validateInput(string input)
		{
			if (input == string.Empty)
				return false;
			else
				return true;

		}
		public void deletedata(string deleteQuerry)
		{
			con = new SqlConnection(conStr);
			con.Open();
			comm = new SqlCommand(deleteQuerry, con);
			comm.ExecuteNonQuery();
			con.Close();
		}
		public void update(string querry)
		{
			try
			{
				con = new SqlConnection(conStr);
				con.Open();
				comm = new SqlCommand(querry, con);
				comm.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Value is updated");

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		public void addEmployee(string querry, string userNm, string userLn, char gender, string email, int Pin, string Address, string position)
		{
			con = new SqlConnection(conStr);
			con.Open();
			comm = new SqlCommand(querry, con);
			comm.Parameters.AddWithValue("Firstname", userNm);
			comm.Parameters.AddWithValue("LastName", userLn);
			comm.Parameters.AddWithValue("gender", gender);
			comm.Parameters.AddWithValue("Email", email);
			comm.Parameters.AddWithValue("Phone_Number", Pin);
			comm.Parameters.AddWithValue("Address", Address);
			comm.Parameters.AddWithValue("Position", position);
			comm.Parameters.AddWithValue("UserID", "-1");
			comm.ExecuteNonQuery();
			con.Close();

		}
		public void readAll(string querry)
		{
			try
			{
				con = new SqlConnection(conStr);
				con.Open();
				comm = new SqlCommand(querry, con);
				adp = new SqlDataAdapter();
				ds = new DataSet();

				adp.SelectCommand = comm;
				adp.Fill(ds, "data");

				dataView.DataSource = ds;
				dataView.DataMember = "data";

				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int no;
			char gender;

			if (validateInput(nameTxt.Text))
			{
				if (validateInput(surnameTxt.Text))
				{
					if (maleBttn.Checked || femaleBttn.Checked)
					{
						if (maleBttn.Checked)
						{
							gender = 'M';
						}
						else
						{
							gender = 'F';
						}
						if (validateInput(emailTxt.Text))
						{
							if (int.TryParse(phoneNumberTxt.Text, out no))
							{
								if (validateInput(comboBox1.Text))
								{
									string save = "INSERT INTO Employees VALUES(@UserID, @FirstName, @LastName, @Gender, @Email, @Phone_No, @Address, @Position, )"; ;
									addEmployee(save, nameTxt.Text, surnameTxt.Text, gender, emailTxt.Text, int.Parse(phoneNumberTxt.Text), addressTxt.Text, comboBox1.Text);
									MessageBox.Show("Employee is successfully added");
									(new CD_Dealership()).clear();
									readAll(readEmployees);
								}
							}
						}
					}
					else { MessageBox.Show("Please Select Gender"); }
				}
			}

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			string updateQuerry = "UPDATE Employees SET " + comboBox2.Text + " = '" + newValueTxt.Text + "' WHERE UserID = '" + int.Parse(updateIDTxt.Text) + "'";
			update(updateQuerry);
			(new CD_Dealership()).clear();
			//this.Clear();
			readAll(readEmployees);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			DialogResult delete = MessageBox.Show("You are about to delete this User ", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
			if (delete == DialogResult.OK)
			{
				string del = "DELETE FROM Employees WHERE UserID = '" + textBox1.Text + "'";
				deletedata(del);
				MessageBox.Show(textBox1.Text + "User is Successfully Deleted");
				textBox1.Text = string.Empty;
				readAll(readEmployees);
			}
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			if(valsearchTxt.Text != string.Empty)
			{
				readAll("SELECT UserID,FirstName,LastName,Gender,Email,Phone_No,Address,Position FROM Employees WHERE 'searchCombo.Text' LIKE 'valsearchTxt.Text%' OR FirstName = '" + valsearchTxt.Text + "'");
			}
		}

		private void sortcombo_SelectedIndexChanged(object sender, EventArgs e)
		{
			readAll("SELECT UserID,FirstName,LastName,Gender,Email,Phone_No,Address,Position FROM Employees ORDER BY 'sortcombo.Text'");
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.Close();
		}

		private void groupBox3_Enter(object sender, EventArgs e)
		{

		}
	}
}
