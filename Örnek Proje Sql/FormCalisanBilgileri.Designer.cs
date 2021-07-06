namespace Örnek_Proje_Sql
{
    partial class FormCalisanBilgileri
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel_web = new System.Windows.Forms.LinkLabel();
            this.checkBox_isten_ayrildi_mi = new System.Windows.Forms.CheckBox();
            this.dateTimePicker_dogum_gunu = new System.Windows.Forms.DateTimePicker();
            this.label_web = new System.Windows.Forms.Label();
            this.label_eposta = new System.Windows.Forms.Label();
            this.label_kariyernet = new System.Windows.Forms.Label();
            this.label_linkedin = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_sube_id = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_cep_tel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_eposta = new System.Windows.Forms.TextBox();
            this.textBox_kariyernet = new System.Windows.Forms.TextBox();
            this.textBox_linkedin = new System.Windows.Forms.TextBox();
            this.textBox_is_tel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_departman_id = new System.Windows.Forms.TextBox();
            this.dateTimePicker_giris_tarihi = new System.Windows.Forms.DateTimePicker();
            this.textBox_pozisyon_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_ekle = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightPink;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 26);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(547, 352);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyUp);
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Location = new System.Drawing.Point(235, 422);
            this.buttonGuncelle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(139, 49);
            this.buttonGuncelle.TabIndex = 0;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.linkLabel_web);
            this.groupBox1.Controls.Add(this.checkBox_isten_ayrildi_mi);
            this.groupBox1.Controls.Add(this.buttonGuncelle);
            this.groupBox1.Controls.Add(this.dateTimePicker_dogum_gunu);
            this.groupBox1.Controls.Add(this.label_web);
            this.groupBox1.Controls.Add(this.label_eposta);
            this.groupBox1.Controls.Add(this.label_kariyernet);
            this.groupBox1.Controls.Add(this.label_linkedin);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBox_sube_id);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox_cep_tel);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox_eposta);
            this.groupBox1.Controls.Add(this.textBox_kariyernet);
            this.groupBox1.Controls.Add(this.textBox_linkedin);
            this.groupBox1.Controls.Add(this.textBox_is_tel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_departman_id);
            this.groupBox1.Controls.Add(this.dateTimePicker_giris_tarihi);
            this.groupBox1.Controls.Add(this.textBox_pozisyon_id);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(582, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 479);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ayrıntılar";
            // 
            // linkLabel_web
            // 
            this.linkLabel_web.AutoSize = true;
            this.linkLabel_web.Location = new System.Drawing.Point(136, 390);
            this.linkLabel_web.Name = "linkLabel_web";
            this.linkLabel_web.Size = new System.Drawing.Size(0, 20);
            this.linkLabel_web.TabIndex = 48;
            this.linkLabel_web.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // checkBox_isten_ayrildi_mi
            // 
            this.checkBox_isten_ayrildi_mi.AutoSize = true;
            this.checkBox_isten_ayrildi_mi.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkBox_isten_ayrildi_mi.Enabled = false;
            this.checkBox_isten_ayrildi_mi.Location = new System.Drawing.Point(140, 259);
            this.checkBox_isten_ayrildi_mi.Name = "checkBox_isten_ayrildi_mi";
            this.checkBox_isten_ayrildi_mi.Size = new System.Drawing.Size(60, 24);
            this.checkBox_isten_ayrildi_mi.TabIndex = 47;
            this.checkBox_isten_ayrildi_mi.TabStop = false;
            this.checkBox_isten_ayrildi_mi.Text = "Evet";
            this.checkBox_isten_ayrildi_mi.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_dogum_gunu
            // 
            this.dateTimePicker_dogum_gunu.Enabled = false;
            this.dateTimePicker_dogum_gunu.Location = new System.Drawing.Point(140, 195);
            this.dateTimePicker_dogum_gunu.Name = "dateTimePicker_dogum_gunu";
            this.dateTimePicker_dogum_gunu.Size = new System.Drawing.Size(211, 26);
            this.dateTimePicker_dogum_gunu.TabIndex = 43;
            this.dateTimePicker_dogum_gunu.TabStop = false;
            // 
            // label_web
            // 
            this.label_web.AutoSize = true;
            this.label_web.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_web.Location = new System.Drawing.Point(13, 390);
            this.label_web.Name = "label_web";
            this.label_web.Size = new System.Drawing.Size(90, 18);
            this.label_web.TabIndex = 46;
            this.label_web.Text = "Web Adresi";
            // 
            // label_eposta
            // 
            this.label_eposta.AutoSize = true;
            this.label_eposta.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_eposta.Location = new System.Drawing.Point(12, 358);
            this.label_eposta.Name = "label_eposta";
            this.label_eposta.Size = new System.Drawing.Size(64, 18);
            this.label_eposta.TabIndex = 46;
            this.label_eposta.Text = "E-Posta";
            // 
            // label_kariyernet
            // 
            this.label_kariyernet.AutoSize = true;
            this.label_kariyernet.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_kariyernet.Location = new System.Drawing.Point(13, 326);
            this.label_kariyernet.Name = "label_kariyernet";
            this.label_kariyernet.Size = new System.Drawing.Size(88, 18);
            this.label_kariyernet.TabIndex = 46;
            this.label_kariyernet.Text = "KariyerNet";
            // 
            // label_linkedin
            // 
            this.label_linkedin.AutoSize = true;
            this.label_linkedin.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_linkedin.Location = new System.Drawing.Point(12, 294);
            this.label_linkedin.Name = "label_linkedin";
            this.label_linkedin.Size = new System.Drawing.Size(73, 18);
            this.label_linkedin.TabIndex = 46;
            this.label_linkedin.Text = "LinkedIn";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(12, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 18);
            this.label11.TabIndex = 46;
            this.label11.Text = "İşten Ayrıldı";
            // 
            // textBox_sube_id
            // 
            this.textBox_sube_id.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sube_id.Location = new System.Drawing.Point(140, 227);
            this.textBox_sube_id.Name = "textBox_sube_id";
            this.textBox_sube_id.ReadOnly = true;
            this.textBox_sube_id.Size = new System.Drawing.Size(211, 26);
            this.textBox_sube_id.TabIndex = 45;
            this.textBox_sube_id.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(13, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 18);
            this.label10.TabIndex = 44;
            this.label10.Text = "Şube";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(12, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 18);
            this.label9.TabIndex = 42;
            this.label9.Text = "Doğum Günü";
            // 
            // textBox_cep_tel
            // 
            this.textBox_cep_tel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_cep_tel.Location = new System.Drawing.Point(140, 163);
            this.textBox_cep_tel.Name = "textBox_cep_tel";
            this.textBox_cep_tel.ReadOnly = true;
            this.textBox_cep_tel.Size = new System.Drawing.Size(211, 26);
            this.textBox_cep_tel.TabIndex = 41;
            this.textBox_cep_tel.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(13, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 18);
            this.label8.TabIndex = 40;
            this.label8.Text = "Cep Telefonu";
            // 
            // textBox_eposta
            // 
            this.textBox_eposta.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_eposta.Location = new System.Drawing.Point(140, 353);
            this.textBox_eposta.Name = "textBox_eposta";
            this.textBox_eposta.ReadOnly = true;
            this.textBox_eposta.Size = new System.Drawing.Size(211, 26);
            this.textBox_eposta.TabIndex = 39;
            this.textBox_eposta.TabStop = false;
            // 
            // textBox_kariyernet
            // 
            this.textBox_kariyernet.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_kariyernet.Location = new System.Drawing.Point(140, 321);
            this.textBox_kariyernet.Name = "textBox_kariyernet";
            this.textBox_kariyernet.ReadOnly = true;
            this.textBox_kariyernet.Size = new System.Drawing.Size(211, 26);
            this.textBox_kariyernet.TabIndex = 39;
            this.textBox_kariyernet.TabStop = false;
            // 
            // textBox_linkedin
            // 
            this.textBox_linkedin.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_linkedin.Location = new System.Drawing.Point(140, 289);
            this.textBox_linkedin.Name = "textBox_linkedin";
            this.textBox_linkedin.ReadOnly = true;
            this.textBox_linkedin.Size = new System.Drawing.Size(211, 26);
            this.textBox_linkedin.TabIndex = 39;
            this.textBox_linkedin.TabStop = false;
            // 
            // textBox_is_tel
            // 
            this.textBox_is_tel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_is_tel.Location = new System.Drawing.Point(140, 131);
            this.textBox_is_tel.Name = "textBox_is_tel";
            this.textBox_is_tel.ReadOnly = true;
            this.textBox_is_tel.Size = new System.Drawing.Size(211, 26);
            this.textBox_is_tel.TabIndex = 39;
            this.textBox_is_tel.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(13, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 18);
            this.label7.TabIndex = 38;
            this.label7.Text = "İş Telefonu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(13, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 34;
            this.label5.Text = "Pozisyon";
            // 
            // textBox_departman_id
            // 
            this.textBox_departman_id.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_departman_id.Location = new System.Drawing.Point(140, 35);
            this.textBox_departman_id.Name = "textBox_departman_id";
            this.textBox_departman_id.ReadOnly = true;
            this.textBox_departman_id.Size = new System.Drawing.Size(213, 26);
            this.textBox_departman_id.TabIndex = 33;
            this.textBox_departman_id.TabStop = false;
            // 
            // dateTimePicker_giris_tarihi
            // 
            this.dateTimePicker_giris_tarihi.Enabled = false;
            this.dateTimePicker_giris_tarihi.Location = new System.Drawing.Point(140, 99);
            this.dateTimePicker_giris_tarihi.Name = "dateTimePicker_giris_tarihi";
            this.dateTimePicker_giris_tarihi.Size = new System.Drawing.Size(213, 26);
            this.dateTimePicker_giris_tarihi.TabIndex = 37;
            this.dateTimePicker_giris_tarihi.TabStop = false;
            // 
            // textBox_pozisyon_id
            // 
            this.textBox_pozisyon_id.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_pozisyon_id.Location = new System.Drawing.Point(140, 67);
            this.textBox_pozisyon_id.Name = "textBox_pozisyon_id";
            this.textBox_pozisyon_id.ReadOnly = true;
            this.textBox_pozisyon_id.Size = new System.Drawing.Size(213, 26);
            this.textBox_pozisyon_id.TabIndex = 35;
            this.textBox_pozisyon_id.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(13, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 32;
            this.label4.Text = "Departman";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(13, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 18);
            this.label6.TabIndex = 36;
            this.label6.Text = "Giriş Tarihi";
            // 
            // button_ekle
            // 
            this.button_ekle.Location = new System.Drawing.Point(221, 417);
            this.button_ekle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_ekle.Name = "button_ekle";
            this.button_ekle.Size = new System.Drawing.Size(152, 49);
            this.button_ekle.TabIndex = 3;
            this.button_ekle.Text = "Yeni Çalışan Ekle";
            this.button_ekle.UseVisualStyleBackColor = true;
            this.button_ekle.Click += new System.EventHandler(this.button_ekle_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(13, 417);
            this.buttonSil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(152, 49);
            this.buttonSil.TabIndex = 2;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // FormCalisanBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(989, 511);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.button_ekle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1005, 550);
            this.Name = "FormCalisanBilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çalışan Bilgileri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_departman_id;
        private System.Windows.Forms.DateTimePicker dateTimePicker_giris_tarihi;
        private System.Windows.Forms.TextBox textBox_pozisyon_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox_isten_ayrildi_mi;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dogum_gunu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_sube_id;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_cep_tel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_is_tel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_web;
        private System.Windows.Forms.Label label_eposta;
        private System.Windows.Forms.Label label_kariyernet;
        private System.Windows.Forms.Label label_linkedin;
        private System.Windows.Forms.TextBox textBox_eposta;
        private System.Windows.Forms.TextBox textBox_kariyernet;
        private System.Windows.Forms.TextBox textBox_linkedin;
        private System.Windows.Forms.LinkLabel linkLabel_web;
        private System.Windows.Forms.Button button_ekle;
        private System.Windows.Forms.Button buttonSil;
    }
}