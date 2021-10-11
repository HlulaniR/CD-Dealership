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
	public partial class Results : Form
	{
		public Results()
		{
			InitializeComponent();
		}
		public string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nhlul\Desktop\223 Project\CD Dealership\CD Dealership\CDManagementDB.mdf;Integrated Security=True";
		private void Results_Load(object sender, EventArgs e)
		{
			string readSONotdelivered = "SELECT Name, Date, Quantity, Status, sell FROM Order, Car, Sales_Order WHERE Sales_Order.CarVin = Car.CarVin AND Sales_Order.OrderID = Order.OrderID";
			SqlConnection con = new SqlConnection(conStr);
			con.Open();
			SqlCommand com = new SqlCommand(readSONotdelivered, con);
			SqlDataReader dRead = com.ExecuteReader();
			/*while (dRead.Read())
			{
				this.chart1.Series["Sales"].Points.AddXY(dRead.GetValue(1).ToString(), float.Parse(dRead.GetValue(2).ToString()) * float.Parse(dRead.GetValue(4).ToString()));
			}*/
		}
	}
}
