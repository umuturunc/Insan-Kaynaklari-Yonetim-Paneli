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

namespace Örnek_Proje_Sql
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=UMUTPC\\SQLEXPRESS;Initial Catalog=ik_database;Integrated Security=True");
        private void buttonGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "select * from login where kullanici_adi='" + textBoxKullaniciAdi.Text + "' and sifre='" + textBoxSifre.Text +"'";
            SqlCommand giris = new SqlCommand(sorgu, baglanti);
            if (giris.ExecuteScalar() != null)
            {
                FormGiris formGiris = new FormGiris();
                formGiris.Show();
                //this.Visible = false;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı veya eksik bilgi girdiniz!\nLütfen tekrar deneyin.");
            }
            baglanti.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelKayit_Click(object sender, EventArgs e)
        {
            FormKayit formKayit = new FormKayit(this);
            formKayit.Show();
            this.Hide();
        }

        private void textBoxSifre_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                buttonGiris_Click(sender, e);
            }
        }
    }
}
