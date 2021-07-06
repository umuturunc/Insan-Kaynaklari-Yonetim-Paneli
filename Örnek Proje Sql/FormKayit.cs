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
    public partial class FormKayit : Form
    {
        FormLogin formLogin;
        public FormKayit(FormLogin _formLogin)
        {
            InitializeComponent();
            formLogin = _formLogin;
        }
        SqlConnection baglanti = new SqlConnection("Data Source=UMUTPC\\SQLEXPRESS;Initial Catalog=ik_database;Integrated Security=True");
        private void buttonKayit_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            bool hata = false;
            string sorgu = "select * from login where kullanici_adi='" + textBoxKullaniciAdi.Text + "'";
            SqlCommand giris = new SqlCommand(sorgu, baglanti);
            if (giris.ExecuteScalar() != null)      //kullanıcı adı sistemde zaten kayıtlıysa
            {
                MessageBox.Show("Bu kullanıcı adı kullanılmakdır. Lütfen başka bir kullanıcı adı giriniz.");
                hata = true;
            }
            else if (textBoxSifre.Text != textBoxSifre2.Text)
            {
                MessageBox.Show("Girilen şifreler eşleşmiyor!");
                hata = true;
            }
            else
            {
                foreach (Control c in this.Controls)    //textboxlar boş bırakılamaz
                {
                    if (c.GetType() == typeof(TextBox))
                    {
                        if (((TextBox)c).Text == "")
                        {
                            MessageBox.Show("Lütfen boş alan bırakmayınız");
                            hata = true;
                            break;
                        }
                    }
                }
            }
            if(hata==false)
            {
                sorgu = "insert into login values('" + textBoxKullaniciAdi.Text + "','" + textBoxSifre.Text + "')";
                giris = new SqlCommand(sorgu, baglanti);
                giris.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarılı!");
                this.Close();
                formLogin.Show();
            }
            baglanti.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            formLogin.Show();
            this.Close();
        }

        private void textBoxSifre2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                buttonKayit_Click(sender, e);
            }
        }
    }
}
