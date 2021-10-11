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
	public partial class Sales : Form
	{
		public Sales()
		{
			InitializeComponent();
		}
		private DataSet ds;
		private SqlDataAdapter adp;
		private SqlConnection con;
		private SqlDataReader dRead;
		private SqlCommand com;

		SignUp SU;
		Human_Resource HR;

		private string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nhlul\Downloads\CMPG223_Acer-Logstics-master\Information Management System(Acer Logistics)\ManagementDB.mdf;Integrated Security=True";

		public void addSO(bool status, string querry, int carVin, int OrderID, float quantity)
		{
			con.Open();
			com = new SqlCommand(querry, con);

			com.Parameters.AddWithValue("Quantity", quantity);
			com.Parameters.AddWithValue("Status", status);
			com.Parameters.AddWithValue("Vehicle Vin", carVin);
			com.Parameters.AddWithValue("Order", OrderID);
			com.ExecuteNonQuery();
			con.Close();
			MessageBox.Show("Vehicle Order Added");
		}
		public int addOrder()
		{
			try
			{
				SU = new SignUp();
				con = new SqlConnection(conStr);

				con.Open();
				DateTime date = DateTime.Today;//addd this for the order was placed

				com = new SqlCommand("INSERT INTO Order VALUES(@Date)", con);
				com.Parameters.AddWithValue("Date", date);
				com.ExecuteNonQuery();
				con.Close();
				int id = (SU).getID("SELECT * FROM Order", date.ToString());
				return id;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return -1;
			}
		}
		public void readAll()
		{
			con = new SqlConnection(conStr);
			con.Open();

			//open the database
			                                        
			adp = new SqlDataAdapter();
			ds = new DataSet();
			com = new SqlCommand("SELECT * FROM Sales_Order", con);

			adp.SelectCommand = com;
			adp.Fill(ds, "Data");

			dataView.DataSource = ds;
			dataView.DataMember = "Data";
			con.Close();
		}
		public void readVehicle(string readCar)
		{
			con = new SqlConnection(conStr);
			con.Open();

			comboBox1.Items.Clear();
			com = new SqlCommand(readCar, con);
			dRead = com.ExecuteReader();

			while (dRead.Read())
			{
				comboBox1.Items.Add(dRead.GetValue(0) + " " + dRead.GetValue(1));
			}
			con.Close();

		}


		private void button1_Click(object sender, EventArgs e)
		{
			string[] car = comboBox1.Text.Split(' ');
			int id = (new SignUp()).getID("SELECT * FROM Car", car[0] );
			//add to the Sale_order database
			string SOquerry = "INSERT INTO Sale_Order VALUES(@Quantity, @Status, @CarVin, @Order)";
			bool status;


			if (paidRB.Checked)
			{
				status = true;
			}
			else
			{ 
				status = false;
			}
				
			
			
			//the error here???????debug
			addSO(SOquerry, float.Parse(qtyTxt.Text), status, id, addOrder());
			readAll();
		}

		private void carNameTxt_TextChanged(object sender, EventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			string readCar = "SELECT CarName, Description FROM Car";
			readVehicle(readCar);
		}

		private void Sales_Load(object sender, EventArgs e)
		{
			readAll();
			HR = new Human_Resource();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			HR.deletedata("DELETE FROM Sales_Order WHERE SalesID = '" +  vinIDTxt.Text);
			readAll();
		}

		private void groupBox3_Enter(object sender, EventArgs e)
		{

		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			//update the cars that in stock
			string updateQuerry = "UPDATE Sales_Order SET + " + columnComboBox.Text + "'WHERE SalesID ='" + float.Parse(txtIdUp.Text) + "";
			HR.update(updateQuerry);
			readAll();
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}
	}
}
