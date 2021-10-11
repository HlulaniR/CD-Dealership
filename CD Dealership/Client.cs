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
	public partial class Client : Form
	{
		public Client()
		{
			InitializeComponent();
		}
		private SqlConnection con;
		private DataSet ds;
		private SqlDataAdapter adp;
		private SqlCommand comm;
		CD_Dealership CD;
		private string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nhlul\Desktop\223 Project\CD Dealership\CD Dealership\CDManagementDB.mdf;Integrated Security=True";


		private void btnAdd_Click(object sender, EventArgs e)
		{
			con.Open();
			comm = new SqlCommand("INSERT INTO Client VALUES(@Firstname, @Lastname, @Phone_Number, @Email, @Address)", con);

			comm.Parameters.AddWithValue("Firstname", txtName.Text);
			comm.Parameters.AddWithValue("Lastname", txtSurname.Text);
			comm.Parameters.AddWithValue("Phone_Number", txtPN.Text);
			comm.Parameters.AddWithValue("Email", txtEmail.Text);
			comm.Parameters.AddWithValue("Address", txtAddress.Text);
			comm.ExecuteNonQuery();
			con.Close();
			readAll("SELECT * FROM Client");
		}
	}
}
