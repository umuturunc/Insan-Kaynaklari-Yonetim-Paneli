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
    public partial class FormGuncelle : Form
    {
        private readonly Action gridViewYenile;
        public FormGuncelle(Action _gridViewYenile)
        {
            InitializeComponent();
            gridViewYenile = _gridViewYenile;
        }
        public string tc;
        public string[] strdizi=new string[11];
        public string tcAl
        {
            get { return tc; }
            set { tc = value; }
        }
        SqlConnection baglanti = new SqlConnection("Data Source=UMUTPC\\SQLEXPRESS;Initial Catalog=ik_database;Integrated Security=True");

        public void FormGuncelle_Load(object sender, EventArgs e)
        {
            textBox_tc.Text = tc;
            //SqlConnection baglanti = new SqlConnection("Data Source=UMUTPC\\SQLEXPRESS;Initial Catalog=ik_database;Integrated Security=True");
            string sorgu = "";
            SqlCommand bilgiGetir;
            baglanti.Open();

            sorgu = "select adi from departmanlar";
            bilgiGetir = new SqlCommand(sorgu, baglanti);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(bilgiGetir);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox_departman.Items.Add(dr.Field<string>(0));
            }

            sorgu = "Select departmanlar.adi from departmanlar, calisanlar where calisanlar.tc = " + tc + " and calisanlar.departman_id = departmanlar.id";
            bilgiGetir = new SqlCommand(sorgu, baglanti);
            comboBox_departman.Text = bilgiGetir.ExecuteScalar().ToString();

            sorgu = "select adi from pozisyonlar";
            bilgiGetir = new SqlCommand(sorgu, baglanti);
            dt = new DataTable();
            da = new SqlDataAdapter(bilgiGetir);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox_pozisyon.Items.Add(dr.Field<string>(0));
            }

            sorgu = "Select pozisyonlar.adi from pozisyonlar, calisanlar where calisanlar.tc=" + tc + " and calisanlar.pozisyon_id=pozisyonlar.id";
            bilgiGetir = new SqlCommand(sorgu, baglanti);
            comboBox_pozisyon.Text = bilgiGetir.ExecuteScalar().ToString();
            
            sorgu = "select adi from subeler";
            bilgiGetir = new SqlCommand(sorgu, baglanti);
            dt = new DataTable();
            da = new SqlDataAdapter(bilgiGetir);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox_subeler.Items.Add(dr.Field<string>(0));
            }

            sorgu = "Select subeler.adi from subeler, calisanlar where calisanlar.tc=" + tc + " and calisanlar.sube_id=subeler.id";
            bilgiGetir = new SqlCommand(sorgu, baglanti);
            comboBox_subeler.Text = bilgiGetir.ExecuteScalar().ToString();

            sorgu = "Select adi from calisanlar where calisanlar.tc=" + tc;
            bilgiGetir = new SqlCommand(sorgu, baglanti);
            textBox_adi.Text = bilgiGetir.ExecuteScalar().ToString();

            sorgu = "Select soyadi from calisanlar where calisanlar.tc=" + tc;
            bilgiGetir = new SqlCommand(sorgu, baglanti);
            textBox_soyadi.Text = bilgiGetir.ExecuteScalar().ToString();


            /*sorgu = "Select departmanlar.adi from departmanlar, calisanlar where calisanlar.tc=" + tc + " and calisanlar.departman_id=departmanlar.id";
            SqlCommand bilgiGetir = new SqlCommand(sorgu, baglanti);
            textBox_departman_id.Text = bilgiGetir.ExecuteScalar().ToString();*/

            /*sorgu = "Select pozisyonlar.adi from pozisyonlar, calisanlar where calisanlar.tc=" + tc + " and calisanlar.pozisyon_id=pozisyonlar.id";
            bilgiGetir = new SqlCommand(sorgu, baglanti);
            textBox_pozisyon_id.Text = bilgiGetir.ExecuteScalar().ToString();*/

            sorgu = "Select giris_tarihi from calisanlar where calisanlar.tc = " + tc;
            bilgiGetir = new SqlCommand(sorgu, baglanti);
            dateTimePicker_giris_tarihi.Text = bilgiGetir.ExecuteScalar().ToString();

            sorgu = "Select is_tel from calisanlar where calisanlar.tc = " + tc;
            bilgiGetir = new SqlCommand(sorgu, baglanti);
            textBox_is_tel.Text = bilgiGetir.ExecuteScalar().ToString();

            sorgu = "Select cep_tel from calisanlar where calisanlar.tc = " + tc;
            bilgiGetir = new SqlCommand(sorgu, baglanti);
            textBox_cep_tel.Text = bilgiGetir.ExecuteScalar().ToString();

            sorgu = "Select dogum_gunu from calisanlar where calisanlar.tc = " + tc;
            bilgiGetir = new SqlCommand(sorgu, baglanti);
            dateTimePicker_dogum_gunu.Text = bilgiGetir.ExecuteScalar().ToString();
            /*
            sorgu = "Select subeler.adi from subeler, calisanlar where calisanlar.tc = " + tc + " and calisanlar.sube_id=subeler.id";
            bilgiGetir = new SqlCommand(sorgu, baglanti);
            textBox_sube_id.Text = bilgiGetir.ExecuteScalar().ToString();*/

            sorgu = "Select isten_ayrildi_mi from calisanlar where calisanlar.tc = " + tc;
            bilgiGetir = new SqlCommand(sorgu, baglanti);
            checkBox_isten_ayrildi_mi.Checked = (bool)bilgiGetir.ExecuteScalar();

            sorgu = "Select linkedin from calisanlar where calisanlar.tc = " + tc;
            bilgiGetir = new SqlCommand(sorgu, baglanti);
            textBox_linkedin.Text = bilgiGetir.ExecuteScalar().ToString();

            sorgu = "Select web_adresi from calisanlar where calisanlar.tc = " + tc;
            bilgiGetir = new SqlCommand(sorgu, baglanti);
            textBox_web.Text = bilgiGetir.ExecuteScalar().ToString();

            sorgu = "Select kariyer_net from calisanlar where calisanlar.tc = " + tc;
            bilgiGetir = new SqlCommand(sorgu, baglanti);
            textBox_kariyernet.Text = bilgiGetir.ExecuteScalar().ToString();

            sorgu = "Select eposta from calisanlar where calisanlar.tc = " + tc;
            bilgiGetir = new SqlCommand(sorgu, baglanti);
            textBox_eposta.Text = bilgiGetir.ExecuteScalar().ToString();

            baglanti.Close();

        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand kayitGuncelle = new SqlCommand("UPDATE calisanlar SET adi=@p2, soyadi=@p3, departman_id=@p4, pozisyon_id=@p5, giris_tarihi=@p6, is_tel=@p7, cep_tel=@p8, dogum_gunu=@p9, sube_id=@p10, isten_ayrildi_mi=@p11, linkedin=@p12, web_adresi=@p13, kariyer_net=@p14, eposta=@p15 WHERE tc=@p1",baglanti);
                kayitGuncelle.Parameters.AddWithValue("@p1", textBox_tc.Text); //veri türlerine dikkat et!!!!
                kayitGuncelle.Parameters.AddWithValue("@p2", textBox_adi.Text);
                kayitGuncelle.Parameters.AddWithValue("@p3", textBox_soyadi.Text);

                string sorgu = "Select id from departmanlar where departmanlar.adi = '" + comboBox_departman.Text + "'";
                //SqlCommand idArama = new SqlCommand("Select id from departmanlar where departmanlar.adi = '@k1'", baglanti);
                // idArama.Parameters.AddWithValue("@k1", comboBox_departman.Text);
                //MessageBox.Show(sorgu);
                SqlCommand idArama = new SqlCommand(sorgu, baglanti);
                //MessageBox.Show(comboBox_departman.Text);
                //idArama.ExecuteNonQuery();
                //SqlDataReader dataReader = idArama.ExecuteReader();
                //dataReader.Read();
                /*if (dataReader.HasRows) MessageBox.Show("Satır var");
                else MessageBox.Show("Satır yok");*/
                //var deneme = idArama.ExecuteScalar();
                int id = (int)idArama.ExecuteScalar();
               // MessageBox.Show("id = " + id);
                kayitGuncelle.Parameters.AddWithValue("@p4", id);

                sorgu = "Select id from pozisyonlar where pozisyonlar.adi = '" + comboBox_pozisyon.Text + "'";
               // MessageBox.Show(sorgu);
                idArama = new SqlCommand(sorgu, baglanti);
                id = (int)idArama.ExecuteScalar();
               // MessageBox.Show("id = " + id);
                kayitGuncelle.Parameters.AddWithValue("@p5",id);

                kayitGuncelle.Parameters.Add("@p6", SqlDbType.Date).Value = dateTimePicker_giris_tarihi.Value.Date;
                //kayitGuncelle.Parameters.AddWithValue("@p6", dateTimePicker_giris_tarihi.Text);     //Program Patlarsa burayı kontrol et!!!!!!
                kayitGuncelle.Parameters.AddWithValue("@p7", textBox_is_tel.Text);
                kayitGuncelle.Parameters.AddWithValue("@p8", textBox_cep_tel.Text);
                kayitGuncelle.Parameters.Add("@p9", SqlDbType.Date).Value = dateTimePicker_dogum_gunu.Value.Date;
                //kayitGuncelle.Parameters.AddWithValue("@p9", dateTimePicker_dogum_gunu.Text);

                sorgu = "Select id from subeler where subeler.adi = '" + comboBox_subeler.Text + "'";
               // MessageBox.Show(sorgu);
                idArama = new SqlCommand(sorgu, baglanti);
                id = (int)idArama.ExecuteScalar();
               // MessageBox.Show("id = " + id);

                kayitGuncelle.Parameters.AddWithValue("@p10", id);
                bool check;
                if (checkBox_isten_ayrildi_mi.Checked) check = true;
                else check = false;
                kayitGuncelle.Parameters.Add("@p11", SqlDbType.Bit).Value = check;
                kayitGuncelle.Parameters.AddWithValue("@p12", textBox_linkedin.Text);
                kayitGuncelle.Parameters.AddWithValue("@p13", textBox_web.Text);
                kayitGuncelle.Parameters.AddWithValue("@p14", textBox_kariyernet.Text);
                kayitGuncelle.Parameters.AddWithValue("@p15", textBox_eposta.Text);
                kayitGuncelle.ExecuteNonQuery();    //parametreler üzerinde değişiklik yapmak için(güncelleme,silme,ekleme)
                MessageBox.Show("Kayıt Başarıyla Güncellendi!","",MessageBoxButtons.OK);
                
                this.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
            finally
            {
                baglanti.Close();
                gridViewYenile();
            }
        }

        private void FormGuncelle_FormClosed(object sender, FormClosedEventArgs e)
        {
            gridViewYenile();
        }

        private void checkBoxLinkedin_CheckedChanged(object sender, EventArgs e)
        {
            textBox_linkedin.Text = null;
            textBox_linkedin.ReadOnly = !textBox_linkedin.ReadOnly;
        }

        private void checkBoxKariyer_CheckedChanged(object sender, EventArgs e)
        {
            textBox_kariyernet.Text = null;
            textBox_kariyernet.ReadOnly = !textBox_kariyernet.ReadOnly;
        }

        private void checkBoxWeb_CheckedChanged(object sender, EventArgs e)
        {
            textBox_web.Text = null;
            textBox_web.ReadOnly = !textBox_web.ReadOnly;
        }

        private void dateTimePicker_dogum_gunu_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
