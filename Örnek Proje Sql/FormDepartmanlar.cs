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
    public partial class FormDepartmanlar : Form
    {
        FormGiris formGiris;
        public FormDepartmanlar(FormGiris _formGiris)
        {
            InitializeComponent();
            formGiris = _formGiris;
        }
        SqlConnection baglanti = new SqlConnection("Data Source=UMUTPC\\SQLEXPRESS;Initial Catalog=ik_database;Integrated Security=True");

        private void gridViewYenile()
        {
            baglanti.Open();
            SqlCommand sqlCommand = new SqlCommand("Select * from DepartmanCalisanSayisi", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            /*
            SqlCommand sqlcommand = new SqlCommand("Select count(id) from departmanlar", baglanti), sqlcommand2;
            int departmansayisi = (int)sqlcommand.ExecuteScalar();
            SqlDataAdapter da = new SqlDataAdapter("Select adi as 'Departman Adı' from departmanlar", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            string sorgu;
            ds.Tables[0].Columns.Add("Çalışan \nSayısı", typeof(Int32));
            for (int i = 0; i < departmansayisi; i++)
            {

                sorgu = "select count(tc) from calisanlar where departman_id=(select id from departmanlar where adi='" + ds.Tables[0].Rows[i][0] + "')";
                sqlcommand2 = new SqlCommand(sorgu, baglanti);
                if(sqlcommand2.ExecuteScalar()!=null)
                ds.Tables[0].Rows[i][1] = (int)sqlcommand2.ExecuteScalar();
            }
            //da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            */
            baglanti.Close();
        }

        private void FormDepartmanlar_Load(object sender, EventArgs e)
        {
            gridViewYenile();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "insert into departmanlar(adi) values('" + textBoxDepartmanAdi.Text + "')";
            SqlCommand departmanEkle = new SqlCommand(sorgu, baglanti);
            departmanEkle.ExecuteNonQuery();
            MessageBox.Show("Yeni departman eklendi");
            baglanti.Close();
            gridViewYenile();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            
            baglanti.Open();
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string secilenDepartman = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            //MessageBox.Show("seşilen cell " +secilenDepartman);
            string sorgu = "Select count(tc) from calisanlar, departmanlar where departmanlar.id=(select id from departmanlar where adi = '" + secilenDepartman + "') and departmanlar.id = calisanlar.departman_id";
            SqlCommand sqlCommand = new SqlCommand(sorgu, baglanti);
            int calisansayisi = (int)sqlCommand.ExecuteScalar();
            //MessageBox.Show("çalışan sayısı " + calisansayisi);
            if (calisansayisi != 0) MessageBox.Show("Bu departmanda çalışan kişiler olduğu için sistemden bu departmanı silemezsiniz!","DİKKAT");
            else
            {
                sorgu = "delete from departmanlar where adi = '" + secilenDepartman + "'";
                sqlCommand = new SqlCommand(sorgu, baglanti);
                if(MessageBox.Show("Seçili departmanı silmek istediğinize emin misiniz?","",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Departman silindi");
                }

            }
            baglanti.Close();
            gridViewYenile();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormDepartmanlar_FormClosing(object sender, FormClosingEventArgs e)
        {
            formGiris.Show();
        }
    }
}
