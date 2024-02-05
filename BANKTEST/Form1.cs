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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		SqlConnection connection = new SqlConnection(@"Data Source=msyc;Initial Catalog=DbBankTest;Integrated Security=True");

		private void LnkKayıtOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Form3 frm3 = new Form3();

			frm3.Show();
		}



		private void BtnGirisYap_Click(object sender, EventArgs e)
		{
			connection.Open();
			SqlCommand command = new SqlCommand("Select * From TBLKISILER where HESAPNO=@p1 and SIFRE=@p2", connection);
			command.Parameters.AddWithValue("@p1", MskHesapNo.Text);
			command.Parameters.AddWithValue("@p2", TxtSifre.Text);

			SqlDataReader dr =command.ExecuteReader();

			if(dr.Read())
			{
				Form2 frm2 = new Form2();
				frm2.hesap = MskHesapNo.Text;
				frm2.Show();
			}
			else
			{
				MessageBox.Show("Hatalı Bilgi");
			}
			connection.Close();

		

			
		}
	}
}
