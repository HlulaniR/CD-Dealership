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
		
		
		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void carNameTxt_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
