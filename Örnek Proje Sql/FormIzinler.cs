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
    public partial class FormIzinler : Form
    {
        FormGiris formGiris;
        public FormIzinler(FormGiris _formGiris)
        {
            InitializeComponent();
            gridViewYenile();
            formGiris = _formGiris;
        }
        public FormIzinler()
        {
            InitializeComponent();
            gridViewYenile();
            formGiris = null;
        }

        SqlConnection baglanti = new SqlConnection("Data Source=UMUTPC\\SQLEXPRESS;Initial Catalog=ik_database;Integrated Security=True");

        private void gridViewYenile()
        {
            baglanti.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from IzinListesi", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void FormIzinler_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sqlCommand = new SqlCommand("select Adı from CalisanListesi", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            da.Fill(dt);
            comboBox1.DataSource = dt;
            //comboBox1.DisplayMember = "";
            comboBox1.ValueMember = dt.Columns[0].ToString();
            baglanti.Close();
            dateTimePickerBitis.MinDate = dateTimePickerBaslangic.Value;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonEkle.Visible = true;
            buttonGuncelle.Visible = false;
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                //string sorgu = "insert into izinler(tc,baslangic,bitis,durum) values(select tc from"
                //SqlCommand sqlCommand = new SqlCommand()
                string adi = comboBox1.Text;
                DateTime baslangic = dateTimePickerBaslangic.Value.Date;
                DateTime bitis = dateTimePickerBitis.Value.Date;
                string aciklama = richTextBoxAciklama.Text;
                SqlCommand sqlCommand = new SqlCommand("select count(TC) from CalisanListesi where Adı like'" + adi +"'",baglanti);
                if ((int)sqlCommand.ExecuteScalar() == 0) MessageBox.Show("Girilen isimde bir çalışan bulunmuyor!");
                else
                {
                    sqlCommand = new SqlCommand("select TC from CalisanListesi where Adı like'" + adi + "'", baglanti);
                    long tc = (long)sqlCommand.ExecuteScalar();
                    MessageBox.Show("" + tc);
                    string sorgu = "Insert into izinler values(" + tc + "," + "@baslangic,@bitis" + ",0," + aciklama + ")";
                    sqlCommand = new SqlCommand("Insert into izinler values(" + tc + "," + "@baslangic , @bitis" + ",0,'" + aciklama + "')", baglanti);
                    sqlCommand.Parameters.Add("@baslangic", SqlDbType.Date).Value = baslangic;
                    sqlCommand.Parameters.Add("@bitis", SqlDbType.Date).Value = bitis;
                    if (sqlCommand.ExecuteNonQuery() > 1) MessageBox.Show("İzin talebi başarıyla eklendi!");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                baglanti.Close();
                gridViewYenile();
            }
            
        }

        private void FormIzinler_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(formGiris!=null)formGiris.Show();
        }

        private void dateTimePickerBaslangic_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerBitis.MinDate = dateTimePickerBaslangic.Value;
        }
        

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                

                int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                //dataGridView1.ClearSelection();
                if (currentMouseOverRow >= 0)
                {
                    m.MenuItems.Add(new MenuItem("İzini Sil"));
                    //m.MenuItems.Add(new MenuItem(string.Format("Do something to row {0}", currentMouseOverRow.ToString())));
                }

                m.Show(dataGridView1, new Point(e.X, e.Y));
            }

        }

        private void buttonIzinSil_Click(object sender, EventArgs e)
        {
            try
            {
                int satır = dataGridView1.SelectedCells[0].RowIndex;
                baglanti.Open();
                //MessageBox.Show(" " + dataGridView1.Rows[satır].Cells[0].Value.ToString()  + dataGridView1.Rows[satır].Cells[1].Value.ToString());
                //string sorgu = "delete from izinler where tc = (select TC from CalisanListesi where Adı = '" + dataGridView1.Rows[satır].Cells[0].Value.ToString() + " " + dataGridView1.Rows[satır].Cells[1].Value.ToString() + "') ";
                string sorgu = "exec sp_izinsil @ad='" + dataGridView1.Rows[satır].Cells["Adı"].Value.ToString()
                    + "', @soyad ='" + dataGridView1.Rows[satır].Cells["Soyadı"].Value.ToString()
                    + "', @baslangic=" + (DateTime)dataGridView1.Rows[satır].Cells["Başlangıç"].Value
                    + ", @bitis=" + (DateTime)dataGridView1.Rows[satır].Cells["Bitiş"].Value;
                SqlCommand sqlCommand = new SqlCommand(sorgu, baglanti);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                buttonGuncelle.Visible = true;
                int row = dataGridView1.SelectedCells[0].RowIndex;
                comboBox1.Text = string.Empty;
                comboBox1.SelectedText = dataGridView1.Rows[row].Cells["Adı"].Value.ToString() + " " + dataGridView1.Rows[row].Cells["Soyadı"].Value.ToString();
                //dateTimePickerBaslangic.Value = dataGridView1.Rows[row].Cells[2]
                dateTimePickerBaslangic.Value = (DateTime)dataGridView1.Rows[row].Cells["Başlangıç"].Value;
                dateTimePickerBitis.Value = (DateTime)dataGridView1.Rows[row].Cells["Bitiş"].Value;
                richTextBoxAciklama.Text = dataGridView1.Rows[row].Cells["Açıklama"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            buttonGuncelle.Visible = false;
            buttonEkle.Visible = true;
            comboBox1.Text = string.Empty;
            dateTimePickerBaslangic.Value = DateTime.Now;
            richTextBoxAciklama.Text = string.Empty;
            buttonEkle.Visible = true;
            buttonGuncelle.Visible = false;
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {

        }
    }
}
