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
	public partial class Forget_Password : Form
	{
		public Forget_Password()
		{
			InitializeComponent();
		}

		private SqlConnection con;
		private SqlCommand comm;
		private SqlDataReader dRead;
		private string conStr = @" Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nhlul\Desktop\223 Project\CD Dealership\CD Dealership\CDManagementDB.mdf;Integrated Security=True";
		public int searchByUser(string querry, string searchFor)
		{
			int foundAt = -1;
			con = new SqlConnection(conStr);
			con.Open();
			comm = new SqlCommand(querry, con);
			while (dRead.Read())
			{
				if (dRead.GetValue(1).ToString() == searchFor)
					foundAt = int.Parse(dRead.GetValue(0).ToString());
			}


			return foundAt;
		}
		public string getNM { get; set; }

		private void button1_Click(object sender, EventArgs e)
		{
			getNM = textBox1.Text;
			this.Close();
		}

		private void Forget_Password_Load(object sender, EventArgs e)
		{

		}
	}
}
