namespace Örnek_Proje_Sql
{
    partial class FormGuncelle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.checkBox_isten_ayrildi_mi = new System.Windows.Forms.CheckBox();
            this.dateTimePicker_dogum_gunu = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_giris_tarihi = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_cep_tel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_is_tel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_soyadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_adi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_tc = new System.Windows.Forms.TextBox();
            this.comboBox_departman = new System.Windows.Forms.ComboBox();
            this.comboBox_pozisyon = new System.Windows.Forms.ComboBox();
            this.comboBox_subeler = new System.Windows.Forms.ComboBox();
            this.label_web = new System.Windows.Forms.Label();
            this.label_eposta = new System.Windows.Forms.Label();
            this.label_kariyernet = new System.Windows.Forms.Label();
            this.label_linkedin = new System.Windows.Forms.Label();
            this.textBox_eposta = new System.Windows.Forms.TextBox();
            this.textBox_kariyernet = new System.Windows.Forms.TextBox();
            this.textBox_linkedin = new System.Windows.Forms.TextBox();
            this.textBox_web = new System.Windows.Forms.TextBox();
            this.checkBoxWeb = new System.Windows.Forms.CheckBox();
            this.checkBoxKariyer = new System.Windows.Forms.CheckBox();
            this.checkBoxLinkedin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Location = new System.Drawing.Point(506, 277);
            this.buttonKaydet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(139, 49);
            this.buttonKaydet.TabIndex = 18;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // checkBox_isten_ayrildi_mi
            // 
            this.checkBox_isten_ayrildi_mi.AutoSize = true;
            this.checkBox_isten_ayrildi_mi.Location = new System.Drawing.Point(506, 89);
            this.checkBox_isten_ayrildi_mi.Name = "checkBox_isten_ayrildi_mi";
            this.checkBox_isten_ayrildi_mi.Size = new System.Drawing.Size(60, 24);
            this.checkBox_isten_ayrildi_mi.TabIndex = 10;
            this.checkBox_isten_ayrildi_mi.Text = "Evet";
            this.checkBox_isten_ayrildi_mi.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_dogum_gunu
            // 
            this.dateTimePicker_dogum_gunu.Location = new System.Drawing.Point(506, 11);
            this.dateTimePicker_dogum_gunu.Name = "dateTimePicker_dogum_gunu";
            this.dateTimePicker_dogum_gunu.Size = new System.Drawing.Size(211, 26);
            this.dateTimePicker_dogum_gunu.TabIndex = 8;
            this.dateTimePicker_dogum_gunu.ValueChanged += new System.EventHandler(this.dateTimePicker_dogum_gunu_ValueChanged);
            // 
            // dateTimePicker_giris_tarihi
            // 
            this.dateTimePicker_giris_tarihi.Location = new System.Drawing.Point(150, 204);
            this.dateTimePicker_giris_tarihi.Name = "dateTimePicker_giris_tarihi";
            this.dateTimePicker_giris_tarihi.Size = new System.Drawing.Size(213, 26);
            this.dateTimePicker_giris_tarihi.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(378, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 18);
            this.label11.TabIndex = 46;
            this.label11.Text = "İşten Ayrıldı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(379, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 18);
            this.label10.TabIndex = 44;
            this.label10.Text = "Şube";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(378, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 18);
            this.label9.TabIndex = 42;
            this.label9.Text = "Doğum Günü";
            // 
            // textBox_cep_tel
            // 
            this.textBox_cep_tel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_cep_tel.Location = new System.Drawing.Point(150, 278);
            this.textBox_cep_tel.Name = "textBox_cep_tel";
            this.textBox_cep_tel.Size = new System.Drawing.Size(211, 26);
            this.textBox_cep_tel.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(20, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 40;
            this.label8.Text = "Cep Tel";
            // 
            // textBox_is_tel
            // 
            this.textBox_is_tel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_is_tel.Location = new System.Drawing.Point(150, 241);
            this.textBox_is_tel.Name = "textBox_is_tel";
            this.textBox_is_tel.Size = new System.Drawing.Size(211, 26);
            this.textBox_is_tel.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(20, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 18);
            this.label7.TabIndex = 38;
            this.label7.Text = "İş tel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(20, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 18);
            this.label6.TabIndex = 36;
            this.label6.Text = "Giriş Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(20, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 34;
            this.label5.Text = "Pozisyon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(20, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 32;
            this.label4.Text = "Departman";
            // 
            // textBox_soyadi
            // 
            this.textBox_soyadi.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_soyadi.Location = new System.Drawing.Point(150, 89);
            this.textBox_soyadi.Name = "textBox_soyadi";
            this.textBox_soyadi.Size = new System.Drawing.Size(213, 26);
            this.textBox_soyadi.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(20, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "Soyadı";
            // 
            // textBox_adi
            // 
            this.textBox_adi.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_adi.Location = new System.Drawing.Point(150, 52);
            this.textBox_adi.Name = "textBox_adi";
            this.textBox_adi.Size = new System.Drawing.Size(213, 26);
            this.textBox_adi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(20, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tc";
            // 
            // textBox_tc
            // 
            this.textBox_tc.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_tc.Location = new System.Drawing.Point(150, 15);
            this.textBox_tc.MaxLength = 11;
            this.textBox_tc.Name = "textBox_tc";
            this.textBox_tc.ReadOnly = true;
            this.textBox_tc.Size = new System.Drawing.Size(213, 26);
            this.textBox_tc.TabIndex = 0;
            // 
            // comboBox_departman
            // 
            this.comboBox_departman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_departman.FormattingEnabled = true;
            this.comboBox_departman.ItemHeight = 20;
            this.comboBox_departman.Location = new System.Drawing.Point(150, 126);
            this.comboBox_departman.Name = "comboBox_departman";
            this.comboBox_departman.Size = new System.Drawing.Size(213, 28);
            this.comboBox_departman.TabIndex = 3;
            // 
            // comboBox_pozisyon
            // 
            this.comboBox_pozisyon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_pozisyon.FormattingEnabled = true;
            this.comboBox_pozisyon.ItemHeight = 20;
            this.comboBox_pozisyon.Location = new System.Drawing.Point(150, 165);
            this.comboBox_pozisyon.Name = "comboBox_pozisyon";
            this.comboBox_pozisyon.Size = new System.Drawing.Size(213, 28);
            this.comboBox_pozisyon.TabIndex = 4;
            // 
            // comboBox_subeler
            // 
            this.comboBox_subeler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_subeler.FormattingEnabled = true;
            this.comboBox_subeler.ItemHeight = 20;
            this.comboBox_subeler.Location = new System.Drawing.Point(506, 49);
            this.comboBox_subeler.Name = "comboBox_subeler";
            this.comboBox_subeler.Size = new System.Drawing.Size(213, 28);
            this.comboBox_subeler.TabIndex = 9;
            // 
            // label_web
            // 
            this.label_web.AutoSize = true;
            this.label_web.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_web.Location = new System.Drawing.Point(379, 245);
            this.label_web.Name = "label_web";
            this.label_web.Size = new System.Drawing.Size(90, 18);
            this.label_web.TabIndex = 52;
            this.label_web.Text = "Web Adresi";
            // 
            // label_eposta
            // 
            this.label_eposta.AutoSize = true;
            this.label_eposta.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_eposta.Location = new System.Drawing.Point(379, 131);
            this.label_eposta.Name = "label_eposta";
            this.label_eposta.Size = new System.Drawing.Size(64, 18);
            this.label_eposta.TabIndex = 53;
            this.label_eposta.Text = "E-Posta";
            // 
            // label_kariyernet
            // 
            this.label_kariyernet.AutoSize = true;
            this.label_kariyernet.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_kariyernet.Location = new System.Drawing.Point(379, 169);
            this.label_kariyernet.Name = "label_kariyernet";
            this.label_kariyernet.Size = new System.Drawing.Size(88, 18);
            this.label_kariyernet.TabIndex = 54;
            this.label_kariyernet.Text = "KariyerNet";
            // 
            // label_linkedin
            // 
            this.label_linkedin.AutoSize = true;
            this.label_linkedin.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_linkedin.Location = new System.Drawing.Point(379, 207);
            this.label_linkedin.Name = "label_linkedin";
            this.label_linkedin.Size = new System.Drawing.Size(73, 18);
            this.label_linkedin.TabIndex = 55;
            this.label_linkedin.Text = "LinkedIn";
            // 
            // textBox_eposta
            // 
            this.textBox_eposta.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_eposta.Location = new System.Drawing.Point(506, 126);
            this.textBox_eposta.Name = "textBox_eposta";
            this.textBox_eposta.Size = new System.Drawing.Size(211, 26);
            this.textBox_eposta.TabIndex = 11;
            // 
            // textBox_kariyernet
            // 
            this.textBox_kariyernet.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_kariyernet.Location = new System.Drawing.Point(506, 163);
            this.textBox_kariyernet.Name = "textBox_kariyernet";
            this.textBox_kariyernet.Size = new System.Drawing.Size(211, 26);
            this.textBox_kariyernet.TabIndex = 12;
            // 
            // textBox_linkedin
            // 
            this.textBox_linkedin.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_linkedin.Location = new System.Drawing.Point(506, 202);
            this.textBox_linkedin.Name = "textBox_linkedin";
            this.textBox_linkedin.Size = new System.Drawing.Size(211, 26);
            this.textBox_linkedin.TabIndex = 14;
            // 
            // textBox_web
            // 
            this.textBox_web.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_web.Location = new System.Drawing.Point(506, 239);
            this.textBox_web.Name = "textBox_web";
            this.textBox_web.Size = new System.Drawing.Size(211, 26);
            this.textBox_web.TabIndex = 16;
            // 
            // checkBoxWeb
            // 
            this.checkBoxWeb.AutoSize = true;
            this.checkBoxWeb.Location = new System.Drawing.Point(726, 241);
            this.checkBoxWeb.Name = "checkBoxWeb";
            this.checkBoxWeb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxWeb.Size = new System.Drawing.Size(56, 24);
            this.checkBoxWeb.TabIndex = 17;
            this.checkBoxWeb.Text = "Yok";
            this.checkBoxWeb.UseVisualStyleBackColor = true;
            this.checkBoxWeb.CheckedChanged += new System.EventHandler(this.checkBoxWeb_CheckedChanged);
            // 
            // checkBoxKariyer
            // 
            this.checkBoxKariyer.AutoSize = true;
            this.checkBoxKariyer.Location = new System.Drawing.Point(726, 164);
            this.checkBoxKariyer.Name = "checkBoxKariyer";
            this.checkBoxKariyer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxKariyer.Size = new System.Drawing.Size(56, 24);
            this.checkBoxKariyer.TabIndex = 13;
            this.checkBoxKariyer.Text = "Yok";
            this.checkBoxKariyer.UseVisualStyleBackColor = true;
            this.checkBoxKariyer.CheckedChanged += new System.EventHandler(this.checkBoxKariyer_CheckedChanged);
            // 
            // checkBoxLinkedin
            // 
            this.checkBoxLinkedin.AutoSize = true;
            this.checkBoxLinkedin.Location = new System.Drawing.Point(726, 201);
            this.checkBoxLinkedin.Name = "checkBoxLinkedin";
            this.checkBoxLinkedin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxLinkedin.Size = new System.Drawing.Size(56, 24);
            this.checkBoxLinkedin.TabIndex = 15;
            this.checkBoxLinkedin.Text = "Yok";
            this.checkBoxLinkedin.UseVisualStyleBackColor = true;
            this.checkBoxLinkedin.CheckedChanged += new System.EventHandler(this.checkBoxLinkedin_CheckedChanged);
            // 
            // FormGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(804, 346);
            this.Controls.Add(this.checkBoxWeb);
            this.Controls.Add(this.checkBoxKariyer);
            this.Controls.Add(this.checkBoxLinkedin);
            this.Controls.Add(this.label_web);
            this.Controls.Add(this.label_eposta);
            this.Controls.Add(this.label_kariyernet);
            this.Controls.Add(this.label_linkedin);
            this.Controls.Add(this.textBox_web);
            this.Controls.Add(this.textBox_eposta);
            this.Controls.Add(this.textBox_kariyernet);
            this.Controls.Add(this.textBox_linkedin);
            this.Controls.Add(this.comboBox_subeler);
            this.Controls.Add(this.comboBox_pozisyon);
            this.Controls.Add(this.comboBox_departman);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.checkBox_isten_ayrildi_mi);
            this.Controls.Add(this.dateTimePicker_dogum_gunu);
            this.Controls.Add(this.dateTimePicker_giris_tarihi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_cep_tel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_is_tel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_soyadi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_adi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_tc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(820, 385);
            this.MinimizeBox = false;
            this.Name = "FormGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilgi Güncelleme Ekranı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGuncelle_FormClosed);
            this.Load += new System.EventHandler(this.FormGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.CheckBox checkBox_isten_ayrildi_mi;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dogum_gunu;
        private System.Windows.Forms.DateTimePicker dateTimePicker_giris_tarihi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_cep_tel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_is_tel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_soyadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_adi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_tc;
        private System.Windows.Forms.ComboBox comboBox_departman;
        private System.Windows.Forms.ComboBox comboBox_pozisyon;
        private System.Windows.Forms.ComboBox comboBox_subeler;
        private System.Windows.Forms.Label label_web;
        private System.Windows.Forms.Label label_eposta;
        private System.Windows.Forms.Label label_kariyernet;
        private System.Windows.Forms.Label label_linkedin;
        private System.Windows.Forms.TextBox textBox_eposta;
        private System.Windows.Forms.TextBox textBox_kariyernet;
        private System.Windows.Forms.TextBox textBox_linkedin;
        private System.Windows.Forms.TextBox textBox_web;
        private System.Windows.Forms.CheckBox checkBoxWeb;
        private System.Windows.Forms.CheckBox checkBoxKariyer;
        private System.Windows.Forms.CheckBox checkBoxLinkedin;
    }
}