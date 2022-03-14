using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktikumWeek4
{
	public partial class FormTampilan : Form
	{

		public FormTampilan()
		{
			InitializeComponent();
		}

		public FormTampilan(string value)
		{
			InitializeComponent();
			textBox_ViewNama.Text = value;
		}

		public string value { get; set; }

		private void FormTampilan_Load(object sender, EventArgs e)
		{
			textBox_ViewNama.Text = value;
		}
		private void btn_Back_Click(object sender, EventArgs e)
		{
			FormData f1 = new FormData();
			f1.Show();
			this.Hide();
		}

		private void textBox_ViewNama_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void btn_Next_Click(object sender, EventArgs e)
		{
			
		}
	}
}
