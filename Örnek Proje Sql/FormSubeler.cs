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
    public partial class FormSubeler : Form
    {
        FormGiris formGiris;
        public FormSubeler(FormGiris _formGiris)
        {
            InitializeComponent();
            formGiris = _formGiris;
            gridViewYenile();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=UMUTPC\\SQLEXPRESS;Initial Catalog=ik_database;Integrated Security=True");

        private void gridViewYenile()
        {
            baglanti.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from SubeCalisanSayisi", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        private void FormSubeler_FormClosing(object sender, FormClosingEventArgs e)
        {
            formGiris.Show();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "insert into subeler(adi) values('" + textBoxSubeAdi.Text + "')";
            SqlCommand departmanEkle = new SqlCommand(sorgu, baglanti);
            departmanEkle.ExecuteNonQuery();
            MessageBox.Show("Yeni şube eklendi");
            baglanti.Close();
            gridViewYenile();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string secilenSube = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            string sorgu = "Select count(tc) from calisanlar, subeler where subeler.id=(select id from subeler where adi = '" + secilenSube + "') and subeler.id = calisanlar.sube_id";
            SqlCommand sqlCommand = new SqlCommand(sorgu, baglanti);
            int calisansayisi = (int)sqlCommand.ExecuteScalar();
            if (calisansayisi != 0) MessageBox.Show("Bu şubede çalışan kişiler olduğu için sistemden bu şubeyi silemezsiniz!", "DİKKAT");
            else
            {
                sorgu = "delete from subeler where adi = '" + secilenSube + "'";
                sqlCommand = new SqlCommand(sorgu, baglanti);
                if ((MessageBox.Show("Seçili şubeyi silmek istediğinize emin misiniz?", "", MessageBoxButtons.YesNo) == DialogResult.Yes))
                {
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Şube silindi");
                }

            }
            baglanti.Close();
            gridViewYenile();
        }
    }
}
