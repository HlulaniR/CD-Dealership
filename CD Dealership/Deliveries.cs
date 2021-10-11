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
	public partial class Deliveries : Form
	{
		public Deliveries()
		{
			InitializeComponent();
		}
		private SqlDataAdapter adp;
		private SqlConnection con;
		private DataSet ds;
		private SqlCommand comm;
		private SqlDataReader dRead;
		string orders = "SELECT SalesID, CarName, Description, Quantity, Date, Status FROM Sales_Order, Car, Order WHERE Sales_Order.CarVin=Car.CarVin AND Sales_Order.OrderID=Order.OrderID"; 
		public string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nhlul\Desktop\223 Project\CD Dealership\CD Dealership\CDManagementDB.mdf;Integrated Security=True ";

		public void readDeli(string quiery)
		{
			con.Open();
			comm = new SqlCommand(quiery, con);
			adp = new SqlDataAdapter();
			ds = new DataSet();

			adp.SelectCommand = comm;
			adp.Fill(ds, "DAT");

			dataGridView1.DataSource = ds;
			dataGridView1.DataMember = "DAT";

			con.Close();
		}
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
		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void Deliveries_Load(object sender, EventArgs e)
		{
			readAll(orders);
			readDeli("SELECT SalesID, name, Description, Quantity, Date, Status FROM Order, Sales_Order, Vehicle, Sales WHERE Sales.SalesID=Sales_Order.SalesID AND Sales_Order.CarVin=CarVin AND Sales_Order.OrderID=Order.OrderID");
		}
	}
}
