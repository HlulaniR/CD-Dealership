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

namespace CD_Dealership
{
	public partial class CD_Dealership : Form
	{
		public CD_Dealership()
		{
			InitializeComponent();
		}

		private void tabPage1_Click(object sender, EventArgs e)
		{

		}
		Human_Resource HR;
		private SqlDataAdapter adp;
		private SqlConnection con;
		private DataSet ds;
		private SqlCommand comm;
		private SqlDataReader dRead;
		float totalSales = 0;
		float totalOrders = 0;
		string readSONotdelivered = "SELECT name,Date, Status,sell FROM Order, Car, Sale_Order WHERE Sale_Order.CarVin = Car.CarVin AND Sale_Order.OrderID= Order.OrderID";
		string readPONotDel = "SELECT FirstName, LastName, name, Date, Quantity, Received, sell FROM SupplyVehicle, Car, ";

		private string readDta = "SELECT * FROM Supplier";
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
		private void CD_Dealership_Load(object sender, EventArgs e)
		{

		}
		public void clear()
		{
			txtAddress.Text = string.Empty;
			txtEmail.Text = string.Empty;
			txtIdUp.Text = string.Empty;
			txtName.Text = string.Empty;
			txtSurname.Text = string.Empty;
			txtPN.Text = string.Empty;
			txtNewVal.Text = string.Empty;


		}
		public void addNew(string quiery, string FN, string LN, char Gender, string PN, string Email, string Address)
		{
			con.Open();
			comm = new SqlCommand(quiery, con);
			comm.Parameters.Add("FirstName", FN);
			comm.Parameters.Add("LastName", LN);
			comm.Parameters.Add("Gender", Gender);
			comm.Parameters.Add("Phone_No", PN);
			comm.Parameters.Add("Email", Email);
			comm.Parameters.Add("Address", Address);
			comm.ExecuteNonQuery();
			con.Close();
			MessageBox.Show("New supplier added");
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string addSupplier = "INSERT INTO Supplier VALUES(@FirstName,@LastName, @Gender, @Phone_No, @Email, @Address)";
			char gender = ' ';
			if (MRadioButton.Checked)
				gender = 'M';
			else if (FRadioButton.Checked)
				gender = 'F';
			addNew(addSupplier, txtName.Text, txtSurname.Text, gender, txtPN.Text, txtEmail.Text, txtAddress.Text);
			clear();
			readAll(readDta);
		}
		public void updatedata(string querry)
		{
			try
			{
				con = new SqlConnection(conStr);
				con.Open();
				comm = new SqlCommand(querry, con);
				comm.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Value is updated sucessfully");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				string updateSupplier = "UPDATE Supplier SET " + columnComboBox.Text + " = '" + txtNewVal.Text + "' WHERE Supplier_ID = '" + int.Parse(txtIdUp.Text) + "'";
				(new Human_Resource()).update(updateSupplier);
				clear();
				readAll(readDta);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			DialogResult delete = MessageBox.Show("You can't retrieve this information after deleting", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
			if (delete == DialogResult.OK)
			{
				(new Human_Resource()).deletedata("DELETE FROM Supplier WHERE Supplier_ID = '" + (textBox1.Text) + "'");
				MessageBox.Show(textBox1.Text + " Deleted");
				textBox1.Text = string.Empty;

				readAll(readDta);
			}
		}
		public double getQty(string querry, int id)
		{
			con = new SqlConnection(conStr);
			con.Open();
			comm = new SqlCommand(querry, con);
			SqlDataReader dr = comm.ExecuteReader();
			while (dr.Read())
			{
				if (int.Parse(dr.GetValue(0).ToString()) == id)
					return double.Parse(dr.GetValue(1).ToString());
			}
			return 0;
		}

		public void readPO()
		{
			con = new SqlConnection(conStr);
			con.Open();
			comm = new SqlCommand("");
			adp = new SqlDataAdapter();
			ds = new DataSet();

			adp.SelectCommand = comm;
			adp.Fill(ds, "data");

			dataGridView1.DataSource = ds;
			dataGridView1.DataMember = "data";

			con.Close();

		}
		public void searchID(string querry, int ID)
		{
			bool found = false;
			bool deli = false;
			con.Open();
			comm = new SqlCommand(querry, con);
			dRead = comm.ExecuteReader();
			while (dRead.Read())
			{
				if (int.Parse(dRead.GetValue(0).ToString()) == ID && dRead.GetValue(3).ToString() == "False")
				{
					int id = (new SignUp()).getID("SELECT *FROM  Car", dRead.GetValue(1).ToString());
					(new Human_Resource()).update("UPDATE Inventory SET Quantity = '" + (getQty("SELECT * FROM Inventory", id) + double.Parse(dRead.GetValue(2).ToString())).ToString() + "'WHERE CarID = '" + id.ToString() + "'");
					bool del = true;
					(new Human_Resource()).update("UPDATE SupplyVehicle SET Received = '"+ del + "' WHERE SupplyVehicleID = '" + dRead.GetValue(0).ToString() + "'");
					readPO();

				}

			}

		}

		private void btn_Click(object sender, EventArgs e)
		{
			string addInventory = "SELECT SupplierID, Name, Quantity, Received FROM SupplyVehicle, Car WHERE SupplyVehicle.CarVin =Car.CarVin";
			searchID(addInventory, int.Parse(txtID.Text));
		}

		private void button4_Click(object sender, EventArgs e)
		{
			DialogResult delete = MessageBox.Show("You wont be able you retrieve this information", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
			if (delete == DialogResult.OK)
			{

				(new Human_Resource()).deletedata("DELETE FROM SupplyVehicle WHERE SupplyVehicleID = '" + (textBox7.Text) + "'");
				MessageBox.Show(textBox7.Text + "Data is Succesfully  Deleted");
				textBox7.Text = string.Empty;
				readPO();
				
			}
		}

		private void saveAndCloseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Forget_Password FP = new Forget_Password();
			//the employee must go the forgot passwork to get a new password


		}
	}
}
