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
using System.Security.Cryptography;

namespace BANKTEST
{
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}

		SqlConnection connection = new SqlConnection(@"Data Source=msyc;Initial Catalog=DbBankTest;Integrated Security=True");

		void temizle()
		{
			TxtAd.Text = "";
			TxtSoyad.Text = "";
			MskTC.Text = "";
			MskTelefon.Text = "";
			MskHesapno.Text = "";
			TxtSifre.Text = "";
		}

		private void BtnKaydet_Click(object sender, EventArgs e)
		{
			connection.Open();
			SqlCommand komut = new SqlCommand("insert into TBLKISILER (AD, SOYAD,TC,TELEFON,HESAPNO,SIFRE) values (@P1,@P2,@P3,@P4,@P5,@P6)",	connection);

			komut.Parameters.AddWithValue("@P1", TxtAd.Text);
			komut.Parameters.AddWithValue("@P2", TxtSoyad.Text);
			komut.Parameters.AddWithValue("@P3", MskTC.Text);
			komut.Parameters.AddWithValue("@P4", MskTelefon.Text);
			komut.Parameters.AddWithValue("@P5", MskHesapno.Text);
			komut.Parameters.AddWithValue("@P6", TxtSifre.Text);

			komut.ExecuteNonQuery();
			connection.Close();
			MessageBox.Show("Hesap Eklendi");
			temizle();
			

			  
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Random random = new Random();

			int randomHesapNo = random.Next(0, 1000000);
			MskHesapno.Text = randomHesapNo.ToString("D6");
		}
	}
}
