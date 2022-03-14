
namespace PraktikumWeek4
{
	partial class FormData
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.labelNama = new System.Windows.Forms.Label();
			this.labelAlamat = new System.Windows.Forms.Label();
			this.labelTelp = new System.Windows.Forms.Label();
			this.textBox_InputNama = new System.Windows.Forms.TextBox();
			this.textBox_InputAlamat = new System.Windows.Forms.TextBox();
			this.textBox_NoTelp = new System.Windows.Forms.TextBox();
			this.btn_save = new System.Windows.Forms.Button();
			this.btn_listdata = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelNama
			// 
			this.labelNama.AutoSize = true;
			this.labelNama.Location = new System.Drawing.Point(20, 31);
			this.labelNama.Name = "labelNama";
			this.labelNama.Size = new System.Drawing.Size(49, 17);
			this.labelNama.TabIndex = 0;
			this.labelNama.Text = "Nama:";
			// 
			// labelAlamat
			// 
			this.labelAlamat.AutoSize = true;
			this.labelAlamat.Location = new System.Drawing.Point(20, 80);
			this.labelAlamat.Name = "labelAlamat";
			this.labelAlamat.Size = new System.Drawing.Size(55, 17);
			this.labelAlamat.TabIndex = 1;
			this.labelAlamat.Text = "Alamat:";
			// 
			// labelTelp
			// 
			this.labelTelp.AutoSize = true;
			this.labelTelp.Location = new System.Drawing.Point(20, 126);
			this.labelTelp.Name = "labelTelp";
			this.labelTelp.Size = new System.Drawing.Size(40, 17);
			this.labelTelp.TabIndex = 2;
			this.labelTelp.Text = "Telp:";
			// 
			// textBox_InputNama
			// 
			this.textBox_InputNama.Location = new System.Drawing.Point(81, 28);
			this.textBox_InputNama.Name = "textBox_InputNama";
			this.textBox_InputNama.Size = new System.Drawing.Size(325, 22);
			this.textBox_InputNama.TabIndex = 3;
			// 
			// textBox_InputAlamat
			// 
			this.textBox_InputAlamat.Location = new System.Drawing.Point(81, 80);
			this.textBox_InputAlamat.Name = "textBox_InputAlamat";
			this.textBox_InputAlamat.Size = new System.Drawing.Size(417, 22);
			this.textBox_InputAlamat.TabIndex = 4;
			// 
			// textBox_NoTelp
			// 
			this.textBox_NoTelp.Location = new System.Drawing.Point(81, 126);
			this.textBox_NoTelp.Name = "textBox_NoTelp";
			this.textBox_NoTelp.Size = new System.Drawing.Size(156, 22);
			this.textBox_NoTelp.TabIndex = 5;
			// 
			// btn_save
			// 
			this.btn_save.Location = new System.Drawing.Point(23, 186);
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(88, 32);
			this.btn_save.TabIndex = 6;
			this.btn_save.Text = "Simpan";
			this.btn_save.UseVisualStyleBackColor = true;
			this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
			// 
			// btn_listdata
			// 
			this.btn_listdata.Location = new System.Drawing.Point(127, 186);
			this.btn_listdata.Name = "btn_listdata";
			this.btn_listdata.Size = new System.Drawing.Size(110, 32);
			this.btn_listdata.TabIndex = 7;
			this.btn_listdata.Text = "Lihat Data";
			this.btn_listdata.UseVisualStyleBackColor = true;
			this.btn_listdata.Click += new System.EventHandler(this.btn_listdata_Click);
			// 
			// FormData
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(542, 253);
			this.Controls.Add(this.btn_listdata);
			this.Controls.Add(this.btn_save);
			this.Controls.Add(this.textBox_NoTelp);
			this.Controls.Add(this.textBox_InputAlamat);
			this.Controls.Add(this.textBox_InputNama);
			this.Controls.Add(this.labelTelp);
			this.Controls.Add(this.labelAlamat);
			this.Controls.Add(this.labelNama);
			this.Name = "FormData";
			this.Text = "                              Form Penambahan Data";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelNama;
		private System.Windows.Forms.Label labelAlamat;
		private System.Windows.Forms.Label labelTelp;
		private System.Windows.Forms.TextBox textBox_InputNama;
		private System.Windows.Forms.TextBox textBox_InputAlamat;
		private System.Windows.Forms.TextBox textBox_NoTelp;
		private System.Windows.Forms.Button btn_save;
		private System.Windows.Forms.Button btn_listdata;
	}
}

