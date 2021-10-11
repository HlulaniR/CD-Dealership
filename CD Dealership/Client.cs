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


		public void readAll(string querry)
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
		private void btnAdd_Click(object sender, EventArgs e)
		{
			con.Open();
			comm = new SqlCommand("INSERT INTO Client VALUES(@FirstName, @LastName, @Phone_No, @Email, @Address)", con);

			comm.Parameters.AddWithValue("FirstName", nameTxt.Text);
			comm.Parameters.AddWithValue("LastName", surnameTxt.Text);
			comm.Parameters.AddWithValue("Phone_No", txtPN.Text);
			comm.Parameters.AddWithValue("Email", emailTxt.Text);
			comm.Parameters.AddWithValue("Address", addressTxt.Text);
			comm.ExecuteNonQuery();
			con.Close();
			readAll("SELECT * FROM Client");
		}

		private void Client_Load(object sender, EventArgs e)
		{
			readAll("SELECT * FROM Client");
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string updateSupplier = "UPDATE Client SET " + columnComboBox.Text + " = '" + newValTxt.Text + "' WHERE ClientID = '" + int.Parse(txtIdUp.Text) + "'";
			(new Human_Resource()).update(updateSupplier);
			readAll("SELECT * FROM Client");
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			DialogResult delete = MessageBox.Show("This data won't be retrieved if you delete it", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
			if (delete == DialogResult.OK)
			{
				(new Human_Resource()).deletedata("DELETE FROM Client WHERE ClientID = '" + (deleteTxt.Text) + "'");
				MessageBox.Show(deleteTxt.Text + " Successfully Deleted");
				//clear contents in textbox
				deleteTxt.Text = string.Empty;

				readAll("SELECT * FROM Client");
			}
		}
	}
}
