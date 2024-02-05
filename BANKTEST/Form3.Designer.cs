namespace BANKTEST
{
	partial class Form3
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.MskTC = new System.Windows.Forms.MaskedTextBox();
			this.TxtSoyad = new System.Windows.Forms.TextBox();
			this.TxtAd = new System.Windows.Forms.TextBox();
			this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
			this.MskHesapno = new System.Windows.Forms.MaskedTextBox();
			this.TxtSifre = new System.Windows.Forms.TextBox();
			this.BtnKaydet = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(79, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "AD :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(36, 99);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "SOYAD :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 144);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(122, 25);
			this.label3.TabIndex = 2;
			this.label3.Text = "TC KİMLİK :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 192);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(115, 25);
			this.label4.TabIndex = 3;
			this.label4.Text = "TELEFON :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(4, 236);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(126, 25);
			this.label5.TabIndex = 4;
			this.label5.Text = "HESAP NO :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(50, 280);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 25);
			this.label6.TabIndex = 5;
			this.label6.Text = "ŞİFRE :";
			// 
			// MskTC
			// 
			this.MskTC.Location = new System.Drawing.Point(136, 144);
			this.MskTC.Mask = "00000000000";
			this.MskTC.Name = "MskTC";
			this.MskTC.Size = new System.Drawing.Size(146, 30);
			this.MskTC.TabIndex = 3;
			this.MskTC.ValidatingType = typeof(int);
			// 
			// TxtSoyad
			// 
			this.TxtSoyad.Location = new System.Drawing.Point(136, 99);
			this.TxtSoyad.Name = "TxtSoyad";
			this.TxtSoyad.Size = new System.Drawing.Size(146, 30);
			this.TxtSoyad.TabIndex = 2;
			// 
			// TxtAd
			// 
			this.TxtAd.Location = new System.Drawing.Point(136, 48);
			this.TxtAd.Name = "TxtAd";
			this.TxtAd.Size = new System.Drawing.Size(146, 30);
			this.TxtAd.TabIndex = 1;
			// 
			// MskTelefon
			// 
			this.MskTelefon.Location = new System.Drawing.Point(133, 192);
			this.MskTelefon.Mask = "(999) 000-0000";
			this.MskTelefon.Name = "MskTelefon";
			this.MskTelefon.Size = new System.Drawing.Size(149, 30);
			this.MskTelefon.TabIndex = 4;
			// 
			// MskHesapno
			// 
			this.MskHesapno.Enabled = false;
			this.MskHesapno.Location = new System.Drawing.Point(133, 236);
			this.MskHesapno.Mask = "000000";
			this.MskHesapno.Name = "MskHesapno";
			this.MskHesapno.Size = new System.Drawing.Size(146, 30);
			this.MskHesapno.TabIndex = 5;
			this.MskHesapno.ValidatingType = typeof(int);
			// 
			// TxtSifre
			// 
			this.TxtSifre.Location = new System.Drawing.Point(133, 277);
			this.TxtSifre.Name = "TxtSifre";
			this.TxtSifre.Size = new System.Drawing.Size(146, 30);
			this.TxtSifre.TabIndex = 6;
			// 
			// BtnKaydet
			// 
			this.BtnKaydet.Location = new System.Drawing.Point(136, 313);
			this.BtnKaydet.Name = "BtnKaydet";
			this.BtnKaydet.Size = new System.Drawing.Size(143, 40);
			this.BtnKaydet.TabIndex = 12;
			this.BtnKaydet.Text = "Kaydet";
			this.BtnKaydet.UseVisualStyleBackColor = true;
			this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(297, 236);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(51, 30);
			this.button2.TabIndex = 13;
			this.button2.Text = "...";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Olive;
			this.ClientSize = new System.Drawing.Size(814, 595);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.BtnKaydet);
			this.Controls.Add(this.TxtSifre);
			this.Controls.Add(this.MskHesapno);
			this.Controls.Add(this.MskTelefon);
			this.Controls.Add(this.TxtAd);
			this.Controls.Add(this.MskTC);
			this.Controls.Add(this.TxtSoyad);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form3";
			this.Text = "Form3";
			this.Load += new System.EventHandler(this.Form3_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.MaskedTextBox MskTC;
		private System.Windows.Forms.TextBox TxtSoyad;
		private System.Windows.Forms.TextBox TxtAd;
		private System.Windows.Forms.MaskedTextBox MskTelefon;
		private System.Windows.Forms.MaskedTextBox MskHesapno;
		private System.Windows.Forms.TextBox TxtSifre;
		private System.Windows.Forms.Button BtnKaydet;
		private System.Windows.Forms.Button button2;
	}
}