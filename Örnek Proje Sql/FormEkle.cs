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
    public partial class FormEkle : Form
    {
        
        private readonly Action gridViewYenile;
        public FormEkle(Action _gridViewYenile)
        {
            InitializeComponent();
            gridViewYenile = _gridViewYenile;
        }
        SqlConnection baglanti = new SqlConnection("Data Source=UMUTPC\\SQLEXPRESS;Initial Catalog=ik_database;Integrated Security=True");
        private bool TexboxKontrol()
        {
            foreach(Control c in this.Controls)
            {
                if(c is TextBox)
                {
                    if(((TextBox)c).Text == String.Empty)
                    {
                        if(!((TextBox)c).ReadOnly)
                        return false;
                    }
                }
            }
            return true;
        }
        private void buttonEkle_Click(object sender, EventArgs e)
        {
            try
            { 
                baglanti.Open();
                SqlCommand kayitEkle = new SqlCommand("INSERT INTO calisanlar VALUES(@tc, @adi, @soyadi, @departmanId, @pozisyonId, @girisTarihi, @isTel, @cepTel, @dogumGunu, @subeId, @ayrildiMi, @linkedin, @web, @kariyer, @eposta)",baglanti);

                kayitEkle.Parameters.AddWithValue("@tc", textBox_tc.Text);
                kayitEkle.Parameters.AddWithValue("@adi", textBox_adi.Text);
                kayitEkle.Parameters.AddWithValue("@soyadi", textBox_soyadi.Text);

                string sorgu = "";  int id;
                SqlCommand idArama;
                sorgu = "Select id from departmanlar where adi='" + comboBox_departman.Text + "'";
                idArama = new SqlCommand(sorgu, baglanti);
                id = (int)idArama.ExecuteScalar();
                kayitEkle.Parameters.AddWithValue("@departmanId", id);

                sorgu = "Select id from pozisyonlar where adi='" + comboBox_pozisyon.Text + "'";
                idArama = new SqlCommand(sorgu, baglanti);
                id = (int)idArama.ExecuteScalar();
                kayitEkle.Parameters.AddWithValue("@pozisyonId", id);

                sorgu = "Select id from subeler where adi='" + comboBox_subeler.Text + "'";
                idArama = new SqlCommand(sorgu, baglanti);
                id = (int)idArama.ExecuteScalar();
                kayitEkle.Parameters.AddWithValue("@subeId", id);

                kayitEkle.Parameters.Add("@girisTarihi", SqlDbType.Date).Value = dateTimePicker_giris_tarihi.Value.Date;
                kayitEkle.Parameters.AddWithValue("@isTel", textBox_is_tel.Text);
                kayitEkle.Parameters.AddWithValue("@cepTel", textBox_cep_tel.Text);
                kayitEkle.Parameters.Add("@dogumGunu", SqlDbType.Date).Value = dateTimePicker_dogum_gunu.Value.Date;

                bool check;
                if (checkBox_isten_ayrildi_mi.Checked) check = true;
                else check = false;
                kayitEkle.Parameters.Add("@ayrildiMi", SqlDbType.Bit).Value = check;

                if(checkBoxLinkedin.Checked)  kayitEkle.Parameters.AddWithValue("@linkedin", textBox_linkedin.Text);
                else kayitEkle.Parameters.AddWithValue("@linkedin", "");

                if(checkBoxWeb.Checked)    kayitEkle.Parameters.AddWithValue("@web",textBox_web.Text);
                else kayitEkle.Parameters.AddWithValue("@web", "");

                if(checkBoxKariyer.Checked)    kayitEkle.Parameters.AddWithValue("@kariyer",textBox_kariyernet.Text);
                else kayitEkle.Parameters.AddWithValue("@kariyer", "");

                kayitEkle.Parameters.AddWithValue("@eposta",textBox_eposta.Text);
                if (TexboxKontrol() == false)
                {
                    MessageBox.Show("Lütfen Boş Alan Bırakmayınız", "", MessageBoxButtons.OK);
                }
                else
                {
                    kayitEkle.ExecuteNonQuery();
                    MessageBox.Show("Yeni Çalışan Başarıyla Eklendi", "", MessageBoxButtons.OK);
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

        }

        private void FormEkle_Load(object sender, EventArgs e)
        {

            SqlCommand bilgiGetir;
            baglanti.Open();

            string sorgu = "select adi from departmanlar";
            bilgiGetir = new SqlCommand(sorgu, baglanti);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(bilgiGetir);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox_departman.Items.Add(dr.Field<string>(0));
            }
            comboBox_departman.SelectedIndex = 0;

            sorgu = "select adi from pozisyonlar";
            bilgiGetir = new SqlCommand(sorgu, baglanti);
            dt = new DataTable();
            da = new SqlDataAdapter(bilgiGetir);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox_pozisyon.Items.Add(dr.Field<string>(0));
            }
            comboBox_pozisyon.SelectedIndex = 0;

            sorgu = "select adi from subeler";
            bilgiGetir = new SqlCommand(sorgu, baglanti);
            dt = new DataTable();
            da = new SqlDataAdapter(bilgiGetir);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox_subeler.Items.Add(dr.Field<string>(0));
            }
            comboBox_subeler.SelectedIndex = 0;

            baglanti.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox_linkedin.Text = null;
            textBox_linkedin.ReadOnly = !textBox_linkedin.ReadOnly;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox_kariyernet.Text = null;
            textBox_kariyernet.ReadOnly = !textBox_kariyernet.ReadOnly;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            textBox_web.Text = null;
            textBox_web.ReadOnly = !textBox_web.ReadOnly;
        }

        private void FormEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            gridViewYenile();
        }
        
    }
}
