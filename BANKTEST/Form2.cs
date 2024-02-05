using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANKTEST
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		SqlConnection connection = new SqlConnection(@"Data Source=msyc;Initial Catalog=DbBankTest;Integrated Security=True");


		public string hesap;

		private void Form2_Load(object sender, EventArgs e)
		{
			LblHesapNo.Text = hesap;
			connection.Open();
			SqlCommand komut = new SqlCommand("Select * From TBLKISILER where HESAPNO=@p1",connection);

			komut.Parameters.AddWithValue("@p1", hesap);

			SqlDataReader dr = komut.ExecuteReader();

			while(dr.Read())
			{
				LblAdSoyad.Text = dr[1] + " " + dr[2];
				LblTelefon.Text = dr[3].ToString();
				LblTC.Text= dr[4].ToString();
			}
			connection.Close();

		}

		private void BtnGonder_Click(object sender, EventArgs e)
		{
			//Gönderilen hesabın para artışı
			connection.Open();
			SqlCommand command = new SqlCommand("update TBLHESAP set BAKIYE =BAKIYE+@p1 where HESAPNO=@p2",connection);

			command.Parameters.AddWithValue("@p1", decimal.Parse(TxtTutar.Text));
			command.Parameters.AddWithValue("@p2", MskHesapNo.Text);

			command.ExecuteNonQuery();
			connection.Close();
			


			// Gönderen hesabın para azalışı

			connection.Open();
			SqlCommand command2 = new SqlCommand("update TBLHESAP set BAKIYE =BAKIYE-@k1 where HESAPNO=@k2",connection);
			command2.Parameters.AddWithValue("@k1", decimal.Parse(TxtTutar.Text));
			command2.Parameters.AddWithValue("@k2", hesap);
			command2.ExecuteNonQuery();

			connection.Close();
			MessageBox.Show("İşlem Gerçekleşti");



		}
	}
}
