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

		}
		public bool validateInput(string input)
		{
			if (input == string.Empty)
				return false;
			else
				return true;

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
										string save = "INSERT INTO Employees VALUES(@UserID, @FirstName, @LastName, @Gender, @Email, @Phone_No, @Address, @Position, )";;
										addEmployee(save,nameTxt.Text, surnameTxt.Text, gender, emailTxt.Text, int.Parse(phoneNumberTxt.Text),addressTxt.Text,comboBox1.Text );
										MessageBox.Show("Employee is successfully added");
									readAll(readEmployees);
									}
								}
							}
					}
				}
			}

		}
	}
}
