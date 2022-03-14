
namespace PraktikumWeek4
{
	partial class FormTampilan
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
			this.btn_Prev = new System.Windows.Forms.Button();
			this.btn_Back = new System.Windows.Forms.Button();
			this.textBox_ViewTelp = new System.Windows.Forms.TextBox();
			this.textBox_ViewAlamat = new System.Windows.Forms.TextBox();
			this.textBox_ViewNama = new System.Windows.Forms.TextBox();
			this.labelTelp = new System.Windows.Forms.Label();
			this.labelAlamat = new System.Windows.Forms.Label();
			this.labelNama = new System.Windows.Forms.Label();
			this.btn_Next = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_Prev
			// 
			this.btn_Prev.Location = new System.Drawing.Point(133, 186);
			this.btn_Prev.Name = "btn_Prev";
			this.btn_Prev.Size = new System.Drawing.Size(104, 32);
			this.btn_Prev.TabIndex = 15;
			this.btn_Prev.Text = "Prev Data";
			this.btn_Prev.UseVisualStyleBackColor = true;
			// 
			// btn_Back
			// 
			this.btn_Back.Location = new System.Drawing.Point(27, 186);
			this.btn_Back.Name = "btn_Back";
			this.btn_Back.Size = new System.Drawing.Size(88, 32);
			this.btn_Back.TabIndex = 14;
			this.btn_Back.Text = "Kembali";
			this.btn_Back.UseVisualStyleBackColor = true;
			this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
			// 
			// textBox_ViewTelp
			// 
			this.textBox_ViewTelp.Location = new System.Drawing.Point(85, 126);
			this.textBox_ViewTelp.Name = "textBox_ViewTelp";
			this.textBox_ViewTelp.ReadOnly = true;
			this.textBox_ViewTelp.Size = new System.Drawing.Size(152, 22);
			this.textBox_ViewTelp.TabIndex = 13;
			// 
			// textBox_ViewAlamat
			// 
			this.textBox_ViewAlamat.Location = new System.Drawing.Point(85, 80);
			this.textBox_ViewAlamat.Name = "textBox_ViewAlamat";
			this.textBox_ViewAlamat.ReadOnly = true;
			this.textBox_ViewAlamat.Size = new System.Drawing.Size(393, 22);
			this.textBox_ViewAlamat.TabIndex = 12;
			// 
			// textBox_ViewNama
			// 
			this.textBox_ViewNama.Location = new System.Drawing.Point(85, 28);
			this.textBox_ViewNama.Name = "textBox_ViewNama";
			this.textBox_ViewNama.ReadOnly = true;
			this.textBox_ViewNama.Size = new System.Drawing.Size(271, 22);
			this.textBox_ViewNama.TabIndex = 11;
			this.textBox_ViewNama.TextChanged += new System.EventHandler(this.textBox_ViewNama_TextChanged);
			// 
			// labelTelp
			// 
			this.labelTelp.AutoSize = true;
			this.labelTelp.Location = new System.Drawing.Point(24, 126);
			this.labelTelp.Name = "labelTelp";
			this.labelTelp.Size = new System.Drawing.Size(40, 17);
			this.labelTelp.TabIndex = 10;
			this.labelTelp.Text = "Telp:";
			// 
			// labelAlamat
			// 
			this.labelAlamat.AutoSize = true;
			this.labelAlamat.Location = new System.Drawing.Point(24, 80);
			this.labelAlamat.Name = "labelAlamat";
			this.labelAlamat.Size = new System.Drawing.Size(55, 17);
			this.labelAlamat.TabIndex = 9;
			this.labelAlamat.Text = "Alamat:";
			// 
			// labelNama
			// 
			this.labelNama.AutoSize = true;
			this.labelNama.Location = new System.Drawing.Point(24, 31);
			this.labelNama.Name = "labelNama";
			this.labelNama.Size = new System.Drawing.Size(49, 17);
			this.labelNama.TabIndex = 8;
			this.labelNama.Text = "Nama:";
			// 
			// btn_Next
			// 
			this.btn_Next.Location = new System.Drawing.Point(258, 186);
			this.btn_Next.Name = "btn_Next";
			this.btn_Next.Size = new System.Drawing.Size(98, 32);
			this.btn_Next.TabIndex = 16;
			this.btn_Next.Text = "Next Data";
			this.btn_Next.UseVisualStyleBackColor = true;
			this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
			// 
			// FormTampilan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(572, 248);
			this.Controls.Add(this.btn_Next);
			this.Controls.Add(this.btn_Prev);
			this.Controls.Add(this.btn_Back);
			this.Controls.Add(this.textBox_ViewTelp);
			this.Controls.Add(this.textBox_ViewAlamat);
			this.Controls.Add(this.textBox_ViewNama);
			this.Controls.Add(this.labelTelp);
			this.Controls.Add(this.labelAlamat);
			this.Controls.Add(this.labelNama);
			this.Name = "FormTampilan";
			this.Text = "                              Form Tampilan Data";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_Prev;
		private System.Windows.Forms.Button btn_Back;
		private System.Windows.Forms.TextBox textBox_ViewTelp;
		private System.Windows.Forms.TextBox textBox_ViewAlamat;
		private System.Windows.Forms.TextBox textBox_ViewNama;
		private System.Windows.Forms.Label labelTelp;
		private System.Windows.Forms.Label labelAlamat;
		private System.Windows.Forms.Label labelNama;
		private System.Windows.Forms.Button btn_Next;
	}
}