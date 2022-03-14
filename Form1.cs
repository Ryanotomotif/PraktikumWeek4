using System;
using System.Collections;
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
	public partial class FormData : Form
	{
		string[,] DataList = new string[10, 3];

		public FormData()
		{
			InitializeComponent();
		}
		
		private void btn_save_Click(object sender, EventArgs e)
		{
			
			for (int i = 0; i < 10; i++)
			{
					DataList[i, 0] = textBox_InputNama.Text;
					DataList[i, 1] = textBox_InputAlamat.Text;
					DataList[i, 2] = textBox_NoTelp.Text;
			}

		}

		private void btn_listdata_Click(object sender, EventArgs e)
		{

			this.Hide();
			FormTampilan frm = new FormTampilan(textBox_InputNama.Text);
			frm.value = textBox_InputNama.Text;
			frm.ShowDialog();
			
		}
	}
}
