﻿namespace BANKTEST
{
	partial class Form1
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
			this.TxtSifre = new System.Windows.Forms.TextBox();
			this.MskHesapNo = new System.Windows.Forms.MaskedTextBox();
			this.BtnGirisYap = new System.Windows.Forms.Button();
			this.LnkKayıtOl = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(30, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Hesap No :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(77, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = "Şifre :";
			// 
			// TxtSifre
			// 
			this.TxtSifre.Location = new System.Drawing.Point(146, 70);
			this.TxtSifre.Name = "TxtSifre";
			this.TxtSifre.Size = new System.Drawing.Size(146, 30);
			this.TxtSifre.TabIndex = 2;
			this.TxtSifre.UseSystemPasswordChar = true;
			// 
			// MskHesapNo
			// 
			this.MskHesapNo.Location = new System.Drawing.Point(146, 22);
			this.MskHesapNo.Mask = "000000";
			this.MskHesapNo.Name = "MskHesapNo";
			this.MskHesapNo.Size = new System.Drawing.Size(146, 30);
			this.MskHesapNo.TabIndex = 1;
			this.MskHesapNo.ValidatingType = typeof(int);
			// 
			// BtnGirisYap
			// 
			this.BtnGirisYap.Location = new System.Drawing.Point(146, 106);
			this.BtnGirisYap.Name = "BtnGirisYap";
			this.BtnGirisYap.Size = new System.Drawing.Size(146, 33);
			this.BtnGirisYap.TabIndex = 3;
			this.BtnGirisYap.Text = "Giriş Yap";
			this.BtnGirisYap.UseVisualStyleBackColor = true;
			this.BtnGirisYap.Click += new System.EventHandler(this.BtnGirisYap_Click);
			// 
			// LnkKayıtOl
			// 
			this.LnkKayıtOl.AutoSize = true;
			this.LnkKayıtOl.Location = new System.Drawing.Point(353, 75);
			this.LnkKayıtOl.Name = "LnkKayıtOl";
			this.LnkKayıtOl.Size = new System.Drawing.Size(81, 25);
			this.LnkKayıtOl.TabIndex = 4;
			this.LnkKayıtOl.TabStop = true;
			this.LnkKayıtOl.Text = "Kayıt Ol";
			this.LnkKayıtOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkKayıtOl_LinkClicked);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Olive;
			this.ClientSize = new System.Drawing.Size(593, 462);
			this.Controls.Add(this.LnkKayıtOl);
			this.Controls.Add(this.BtnGirisYap);
			this.Controls.Add(this.MskHesapNo);
			this.Controls.Add(this.TxtSifre);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TxtSifre;
		private System.Windows.Forms.MaskedTextBox MskHesapNo;
		private System.Windows.Forms.Button BtnGirisYap;
		private System.Windows.Forms.LinkLabel LnkKayıtOl;
	}
}

