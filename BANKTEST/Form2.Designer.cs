﻿namespace BANKTEST
{
	partial class Form2
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
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.MskHesapNo = new System.Windows.Forms.MaskedTextBox();
			this.TxtTutar = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.BtnGonder = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(70, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ad Soyad :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(62, 100);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(133, 29);
			this.label2.TabIndex = 1;
			this.label2.Text = "Hesap No :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(84, 142);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(108, 29);
			this.label3.TabIndex = 2;
			this.label3.Text = "Telefon :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(62, 184);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(130, 29);
			this.label4.TabIndex = 3;
			this.label4.Text = "TC Kimlik :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(204, 51);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 29);
			this.label5.TabIndex = 4;
			this.label5.Text = "Null";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(204, 100);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 29);
			this.label6.TabIndex = 5;
			this.label6.Text = "Null";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(204, 142);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(56, 29);
			this.label7.TabIndex = 6;
			this.label7.Text = "Null";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(204, 184);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(56, 29);
			this.label8.TabIndex = 7;
			this.label8.Text = "Null";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.BtnGonder);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.TxtTutar);
			this.groupBox1.Controls.Add(this.MskHesapNo);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Location = new System.Drawing.Point(67, 246);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(468, 331);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Havale";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(17, 53);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(133, 29);
			this.label9.TabIndex = 9;
			this.label9.Text = "Hesap No :";
			// 
			// MskHesapNo
			// 
			this.MskHesapNo.Location = new System.Drawing.Point(156, 50);
			this.MskHesapNo.Mask = "000000";
			this.MskHesapNo.Name = "MskHesapNo";
			this.MskHesapNo.Size = new System.Drawing.Size(148, 34);
			this.MskHesapNo.TabIndex = 1;
			this.MskHesapNo.ValidatingType = typeof(int);
			// 
			// TxtTutar
			// 
			this.TxtTutar.Location = new System.Drawing.Point(156, 100);
			this.TxtTutar.Name = "TxtTutar";
			this.TxtTutar.Size = new System.Drawing.Size(148, 34);
			this.TxtTutar.TabIndex = 2;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(69, 100);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(81, 29);
			this.label10.TabIndex = 12;
			this.label10.Text = "Tutar :";
			// 
			// BtnGonder
			// 
			this.BtnGonder.Location = new System.Drawing.Point(156, 143);
			this.BtnGonder.Name = "BtnGonder";
			this.BtnGonder.Size = new System.Drawing.Size(148, 43);
			this.BtnGonder.TabIndex = 13;
			this.BtnGonder.Text = "Gönder";
			this.BtnGonder.UseVisualStyleBackColor = true;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Olive;
			this.ClientSize = new System.Drawing.Size(711, 649);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.Name = "Form2";
			this.Text = "Form2";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
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
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.MaskedTextBox MskHesapNo;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button BtnGonder;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox TxtTutar;
	}
}