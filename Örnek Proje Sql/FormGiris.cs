using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Örnek_Proje_Sql
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }
        private void buttonCalisanlar_Click(object sender, EventArgs e)
        {
            FormCalisanBilgileri form2 = new FormCalisanBilgileri();
            form2.Show();
            //this.Visible = false;
            this.Hide();
        }

        private void FormGiris_Load(object sender, EventArgs e)
        {
            label_tarih.Text = DateTime.Now.ToLongDateString();
            label_saat.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_saat.Text = DateTime.Now.ToLongTimeString();
        }

        private void FormGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonDepartmanlar_Click(object sender, EventArgs e)
        {
            FormDepartmanlar formDepartmanlar = new FormDepartmanlar(this);
            formDepartmanlar.Show();
            this.Hide();
        }

        private void buttonPozisyonlar_Click(object sender, EventArgs e)
        {
            FormPozisyonlar formPozisyonlar = new FormPozisyonlar(this);
            formPozisyonlar.Show();
            this.Hide();
        }

        private void buttonSubeler_Click(object sender, EventArgs e)
        {
            FormSubeler formSubeler = new FormSubeler(this);
            formSubeler.Show();
            this.Hide();
        }

        private void buttonIzinler_Click(object sender, EventArgs e)
        {
            FormIzinler formIzinler = new FormIzinler(this);
            formIzinler.Show();
            this.Hide();
        }
    }
}
