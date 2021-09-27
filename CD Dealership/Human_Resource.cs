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
	}
}
