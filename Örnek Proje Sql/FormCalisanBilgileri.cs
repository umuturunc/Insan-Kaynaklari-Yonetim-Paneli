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
    public partial class FormCalisanBilgileri : Form
    {
        
        public FormCalisanBilgileri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=UMUTPC\\SQLEXPRESS;Initial Catalog=ik_database;Integrated Security=True");

        public void gridViewYenile()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select adi as Adı,soyadi as Soyadı,tc as TC from calisanlar", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gridViewYenile();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*try
            {
            baglanti.Open();
                bool check;
            SqlCommand kayitEkle = new SqlCommand("insert into calisanlar(tc, adi, soyadi, departman_id, pozisyon_id, giris_tarihi, is_tel, cep_tel, dogum_gunu, sube_id, isten_ayrildi_mi) values (@c1,@c2,@c3,@c4,@c5,@c6,@c7,@c8,@c9,@c10,@c11)",baglanti);
            kayitEkle.Parameters.AddWithValue("@c1", textBox_tc.Text); //veri türlerine dikkat et!!!!
            kayitEkle.Parameters.AddWithValue("@c2", textBox_adi.Text);
            kayitEkle.Parameters.AddWithValue("@c3", textBox_soyadi.Text);
            kayitEkle.Parameters.AddWithValue("@c4", textBox_departman_id.Text);
            kayitEkle.Parameters.AddWithValue("@c5", textBox_pozisyon_id.Text);
            kayitEkle.Parameters.Add("@c6", SqlDbType.Date).Value = dateTimePicker_giris_tarihi.Value.Date;
            //kayitEkle.Parameters.AddWithValue("@c6", dateTimePicker_giris_tarihi.Text);     //Program Patlarsa burayı kontrol et!!!!!!
            kayitEkle.Parameters.AddWithValue("@c7", textBox_is_tel.Text);
            kayitEkle.Parameters.AddWithValue("@c8", textBox_cep_tel.Text);
            kayitEkle.Parameters.Add("@c9", SqlDbType.Date).Value = dateTimePicker_dogum_gunu.Value.Date;
            //kayitEkle.Parameters.AddWithValue("@c9", dateTimePicker_dogum_gunu.Text);
            kayitEkle.Parameters.AddWithValue("@c10", textBox_sube_id.Text);
                if (checkBox_isten_ayrildi_mi.Checked) check = true;
                else check = false;
                kayitEkle.Parameters.Add("@c11", SqlDbType.Bit ).Value = check;
                //kayitEkle.Parameters.AddWithValue("@c11", check);
                kayitEkle.ExecuteNonQuery();    //parametreler üzerinde değişiklik yapmak için(güncelleme,silme,ekleme)
                gridViewYenile();
                MessageBox.Show("Kayıt Başarıyla Eklendi!");
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
            finally
            {
            baglanti.Close();
            }*/
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    TextBox temp = (TextBox)c;
                    temp.Clear();
                    
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*if (textBox_tc.Text == string.Empty || textBox_tc.Text.Length!=11)
            {
                MessageBox.Show("Lütfen Geçerli Bir TC Numarası Giriniz!");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    SqlCommand kayitSil = new SqlCommand("DELETE FROM calisanlar WHERE tc=@tc", baglanti);
                    kayitSil.Parameters.AddWithValue("@tc", textBox_tc.Text);
                    kayitSil.ExecuteNonQuery();
                    gridViewYenile();
                    MessageBox.Show("Kayıt Başarıyla Silindi");
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }
                finally
                {
                    baglanti.Close();
                }
            }*/

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            gridViewYenile();
        }

        private void yenile()
        {
            baglanti.Open();

            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string secilentc = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            string sorgu;
            if (!string.IsNullOrEmpty(secilentc))
            {


                sorgu = "Select departmanlar.adi from departmanlar, calisanlar where calisanlar.tc=" + secilentc + " and calisanlar.departman_id=departmanlar.id";
                SqlCommand bilgiGetir = new SqlCommand(sorgu, baglanti);
                textBox_departman_id.Text = bilgiGetir.ExecuteScalar().ToString();

                sorgu = "Select pozisyonlar.adi from pozisyonlar, calisanlar where calisanlar.tc=" + secilentc + " and calisanlar.pozisyon_id=pozisyonlar.id";
                bilgiGetir = new SqlCommand(sorgu, baglanti);
                textBox_pozisyon_id.Text = bilgiGetir.ExecuteScalar().ToString();

                sorgu = "Select giris_tarihi from calisanlar where calisanlar.tc = " + secilentc;
                bilgiGetir = new SqlCommand(sorgu, baglanti);
                dateTimePicker_giris_tarihi.Text = bilgiGetir.ExecuteScalar().ToString();

                sorgu = "Select is_tel from calisanlar where calisanlar.tc = " + secilentc;
                bilgiGetir = new SqlCommand(sorgu, baglanti);
                textBox_is_tel.Text = bilgiGetir.ExecuteScalar().ToString();

                sorgu = "Select cep_tel from calisanlar where calisanlar.tc = " + secilentc;
                bilgiGetir = new SqlCommand(sorgu, baglanti);
                textBox_cep_tel.Text = bilgiGetir.ExecuteScalar().ToString();

                sorgu = "Select dogum_gunu from calisanlar where calisanlar.tc = " + secilentc;
                bilgiGetir = new SqlCommand(sorgu, baglanti);
                dateTimePicker_dogum_gunu.Text = bilgiGetir.ExecuteScalar().ToString();

                sorgu = "Select subeler.adi from subeler, calisanlar where calisanlar.tc = " + secilentc + " and calisanlar.sube_id=subeler.id";
                bilgiGetir = new SqlCommand(sorgu, baglanti);
                textBox_sube_id.Text = bilgiGetir.ExecuteScalar().ToString();

                sorgu = "Select isten_ayrildi_mi from calisanlar where calisanlar.tc = " + secilentc;
                bilgiGetir = new SqlCommand(sorgu, baglanti);
                checkBox_isten_ayrildi_mi.Checked = (bool)bilgiGetir.ExecuteScalar();

                sorgu = "Select linkedin from calisanlar where calisanlar.tc = " + secilentc;
                bilgiGetir = new SqlCommand(sorgu, baglanti);
                textBox_linkedin.Text = bilgiGetir.ExecuteScalar().ToString();

                sorgu = "Select web_adresi from calisanlar where calisanlar.tc = " + secilentc;
                bilgiGetir = new SqlCommand(sorgu, baglanti);
                linkLabel_web.Text = bilgiGetir.ExecuteScalar().ToString();

                sorgu = "Select kariyer_net from calisanlar where calisanlar.tc = " + secilentc;
                bilgiGetir = new SqlCommand(sorgu, baglanti);
                textBox_kariyernet.Text = bilgiGetir.ExecuteScalar().ToString();

                sorgu = "Select eposta from calisanlar where calisanlar.tc = " + secilentc;
                bilgiGetir = new SqlCommand(sorgu, baglanti);
                textBox_eposta.Text = bilgiGetir.ExecuteScalar().ToString();
            }
            baglanti.Close();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            yenile();

            //dataGridView in son satırına tıklanırda program patlıyor!!!!
                /*textBox_tc.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
                textBox_adi.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
                textBox_soyadi.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
                textBox_departman_id.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
                textBox_pozisyon_id.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
                dateTimePicker_giris_tarihi.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
                textBox_is_tel.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
                textBox_cep_tel.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
                dateTimePicker_dogum_gunu.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
                textBox_sube_id.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
                checkBox_isten_ayrildi_mi.Checked = (bool)dataGridView1.Rows[secilen].Cells[10].Value;*/
            
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string secilentc = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            FormGuncelle formGuncelle = new FormGuncelle(this.gridViewYenile);
            formGuncelle.tc = secilentc;
            formGuncelle.Show();
            /*try
            {
                baglanti.Open();
                SqlCommand kayitGuncelle = new SqlCommand("UPDATE calisanlar SET tc=@p1, adi=@p2, soyadi=@p3, departman_id=@p4, pozisyon_id=@p5, giris_tarihi=@p6, is_tel=@p7, cep_tel=@p8, dogum_gunu=@p9, sube_id=@p10, isten_ayrildi_mi=@p11 WHERE tc=@p1",baglanti);
                kayitGuncelle.Parameters.AddWithValue("@p1", textBox_tc.Text); //veri türlerine dikkat et!!!!
                kayitGuncelle.Parameters.AddWithValue("@p2", textBox_adi.Text);
                kayitGuncelle.Parameters.AddWithValue("@p3", textBox_soyadi.Text);
                kayitGuncelle.Parameters.AddWithValue("@p4", textBox_departman_id.Text);
                kayitGuncelle.Parameters.AddWithValue("@p5", textBox_pozisyon_id.Text);
                kayitGuncelle.Parameters.Add("@p6", SqlDbType.Date).Value = dateTimePicker_giris_tarihi.Value.Date;
                //kayitGuncelle.Parameters.AddWithValue("@p6", dateTimePicker_giris_tarihi.Text);     //Program Patlarsa burayı kontrol et!!!!!!
                kayitGuncelle.Parameters.AddWithValue("@p7", textBox_is_tel.Text);
                kayitGuncelle.Parameters.AddWithValue("@p8", textBox_cep_tel.Text);
                kayitGuncelle.Parameters.Add("@p9", SqlDbType.Date).Value = dateTimePicker_dogum_gunu.Value.Date;
                //kayitGuncelle.Parameters.AddWithValue("@p9", dateTimePicker_dogum_gunu.Text);
                kayitGuncelle.Parameters.AddWithValue("@p10", textBox_sube_id.Text);
                bool check;
                if (checkBox_isten_ayrildi_mi.Checked) check = true;
                else check = false;
                kayitGuncelle.Parameters.Add("@p11", SqlDbType.Bit).Value = check;
                kayitGuncelle.ExecuteNonQuery();    //parametreler üzerinde değişiklik yapmak için(güncelleme,silme,ekleme)
                gridViewYenile();
                MessageBox.Show("Kayıt Başarıyla Güncellendi!");
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
            finally
            {
                baglanti.Close();
            }*/
        }
        
        
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormGiris formGiris = new FormGiris();
            formGiris.Show();
        }
        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel_web.Text);
        }

        private void button_ekle_Click(object sender, EventArgs e)
        {
            FormEkle formEkle = new FormEkle(gridViewYenile);
            formEkle.Show();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string secilentc = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            SqlCommand adiGetir = new SqlCommand("SELECT adi FROM calisanlar WHERE tc=" + secilentc, baglanti);
            string adi = adiGetir.ExecuteScalar().ToString();
            SqlCommand soyadiGetir = new SqlCommand("SELECT soyadi FROM calisanlar WHERE tc=" + secilentc, baglanti);
            string soyadi = soyadiGetir.ExecuteScalar().ToString();
            if (MessageBox.Show(adi+" "+soyadi+ " adlı çalışana ait bütün verileri silmek istediğinize emin misiniz?","Dikkat", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                SqlCommand sil = new SqlCommand("DELETE FROM calisanlar WHERE tc=@tc", baglanti);
                sil.Parameters.AddWithValue("@tc", secilentc);
                sil.ExecuteNonQuery();
            }
            baglanti.Close();
            gridViewYenile();
            //this.Close();
        }
        
        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            yenile();
        }
    }
}
