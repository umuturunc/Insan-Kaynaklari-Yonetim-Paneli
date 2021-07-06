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
    public partial class FormPozisyonlar : Form
    {
        FormGiris formGiris;
        public FormPozisyonlar(FormGiris _formGiris)
        {
            InitializeComponent();
            formGiris = _formGiris;
            gridViewYenile();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=UMUTPC\\SQLEXPRESS;Initial Catalog=ik_database;Integrated Security=True");

        private void gridViewYenile()
        {
            baglanti.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from PozisyonCalisanSayisi", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "insert into pozisyonlar(adi) values('" + textBoxPozisyonAdi.Text + "')";
            SqlCommand departmanEkle = new SqlCommand(sorgu, baglanti);
            departmanEkle.ExecuteNonQuery();
            MessageBox.Show("Yeni pozisyon eklendi");
            baglanti.Close();
            gridViewYenile();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string secilenPozisyon = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            //MessageBox.Show("seşilen cell " +secilenDepartman);
            string sorgu = "Select count(tc) from calisanlar, pozisyonlar where pozisyonlar.id=(select id from pozisyonlar where adi = '" + secilenPozisyon + "') and pozisyonlar.id = calisanlar.pozisyon_id";
            SqlCommand sqlCommand = new SqlCommand(sorgu, baglanti);
            int calisansayisi = (int)sqlCommand.ExecuteScalar();
            //MessageBox.Show("çalışan sayısı " + calisansayisi);
            if (calisansayisi != 0) MessageBox.Show("Bu pozisyonda çalışan kişiler olduğu için sistemden bu pozisyonu silemezsiniz!", "DİKKAT");
            else
            {
                sorgu = "delete from pozisyonlar where adi = '" + secilenPozisyon + "'";
                sqlCommand = new SqlCommand(sorgu, baglanti);
                if ((MessageBox.Show("Seçili pozisyonu silmek istediğinize emin misiniz?","",MessageBoxButtons.YesNo)==DialogResult.Yes))
                {
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Pozisyon silindi");
                }

            }
            baglanti.Close();
            gridViewYenile();
        }

        private void FormPozisyonlar_FormClosing(object sender, FormClosingEventArgs e)
        {
            formGiris.Show();
        }
        
    }
}
