using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CD_Dealership
{
	public partial class RecoveryQuiz : Form
	{
		public RecoveryQuiz()
		{
			InitializeComponent();
		}

		private void RecoveryQuiz_Load(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		public bool QuizCreated { get; set; }

		public string getQuiz { get; set; }

		public string getAnswer { get; set; }

		private void button2_Click(object sender, EventArgs e)
		{
			if(comboBox1.SelectedIndex != 1 || comboBox1.Text != string.Empty)
			{
				if(textBox1.Text != string.Empty)
				{
					QuizCreated = true;
					getQuiz = comboBox1.Text;
					getAnswer = textBox1.Text;
					this.Close();
				}

			}
		}
	}
}
