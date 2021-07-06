namespace Örnek_Proje_Sql
{
    partial class FormIzinler
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePickerBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBitis = new System.Windows.Forms.DateTimePicker();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.richTextBoxAciklama = new System.Windows.Forms.RichTextBox();
            this.labelAdi = new System.Windows.Forms.Label();
            this.labelBaslangic = new System.Windows.Forms.Label();
            this.labelBitis = new System.Windows.Forms.Label();
            this.buttonIzinSil = new System.Windows.Forms.Button();
            this.buttonIzınDuzenle = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.buttonTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(26, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 157);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(761, 192);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // dateTimePickerBaslangic
            // 
            this.dateTimePickerBaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerBaslangic.Location = new System.Drawing.Point(219, 31);
            this.dateTimePickerBaslangic.Name = "dateTimePickerBaslangic";
            this.dateTimePickerBaslangic.Size = new System.Drawing.Size(192, 23);
            this.dateTimePickerBaslangic.TabIndex = 1;
            this.dateTimePickerBaslangic.ValueChanged += new System.EventHandler(this.dateTimePickerBaslangic_ValueChanged);
            // 
            // dateTimePickerBitis
            // 
            this.dateTimePickerBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerBitis.Location = new System.Drawing.Point(417, 31);
            this.dateTimePickerBitis.Name = "dateTimePickerBitis";
            this.dateTimePickerBitis.Size = new System.Drawing.Size(192, 23);
            this.dateTimePickerBitis.TabIndex = 2;
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(615, 91);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(92, 50);
            this.buttonEkle.TabIndex = 4;
            this.buttonEkle.Text = "İzin Ekle";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // richTextBoxAciklama
            // 
            this.richTextBoxAciklama.Location = new System.Drawing.Point(26, 65);
            this.richTextBoxAciklama.Name = "richTextBoxAciklama";
            this.richTextBoxAciklama.Size = new System.Drawing.Size(583, 76);
            this.richTextBoxAciklama.TabIndex = 3;
            this.richTextBoxAciklama.Text = "";
            // 
            // labelAdi
            // 
            this.labelAdi.AutoSize = true;
            this.labelAdi.Location = new System.Drawing.Point(69, 8);
            this.labelAdi.Name = "labelAdi";
            this.labelAdi.Size = new System.Drawing.Size(92, 20);
            this.labelAdi.TabIndex = 5;
            this.labelAdi.Text = "Çalışan Adı:";
            // 
            // labelBaslangic
            // 
            this.labelBaslangic.AutoSize = true;
            this.labelBaslangic.Location = new System.Drawing.Point(257, 8);
            this.labelBaslangic.Name = "labelBaslangic";
            this.labelBaslangic.Size = new System.Drawing.Size(124, 20);
            this.labelBaslangic.TabIndex = 6;
            this.labelBaslangic.Text = "Başlangıç Tarihi:";
            // 
            // labelBitis
            // 
            this.labelBitis.AutoSize = true;
            this.labelBitis.Location = new System.Drawing.Point(462, 8);
            this.labelBitis.Name = "labelBitis";
            this.labelBitis.Size = new System.Drawing.Size(85, 20);
            this.labelBitis.TabIndex = 6;
            this.labelBitis.Text = "Bitiş Tarihi:";
            // 
            // buttonIzinSil
            // 
            this.buttonIzinSil.Location = new System.Drawing.Point(26, 355);
            this.buttonIzinSil.Name = "buttonIzinSil";
            this.buttonIzinSil.Size = new System.Drawing.Size(158, 44);
            this.buttonIzinSil.TabIndex = 7;
            this.buttonIzinSil.Text = "Seçili İzini Sil";
            this.buttonIzinSil.UseVisualStyleBackColor = true;
            this.buttonIzinSil.Click += new System.EventHandler(this.buttonIzinSil_Click);
            // 
            // buttonIzınDuzenle
            // 
            this.buttonIzınDuzenle.Location = new System.Drawing.Point(223, 355);
            this.buttonIzınDuzenle.Name = "buttonIzınDuzenle";
            this.buttonIzınDuzenle.Size = new System.Drawing.Size(158, 44);
            this.buttonIzınDuzenle.TabIndex = 7;
            this.buttonIzınDuzenle.Text = "Seçili İzini Düzenle";
            this.buttonIzınDuzenle.UseVisualStyleBackColor = true;
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Location = new System.Drawing.Point(615, 91);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(92, 50);
            this.buttonGuncelle.TabIndex = 4;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Visible = false;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.Location = new System.Drawing.Point(615, 31);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(92, 50);
            this.buttonTemizle.TabIndex = 4;
            this.buttonTemizle.Text = "Temizle";
            this.buttonTemizle.UseVisualStyleBackColor = true;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // FormIzinler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(799, 411);
            this.Controls.Add(this.buttonIzınDuzenle);
            this.Controls.Add(this.buttonIzinSil);
            this.Controls.Add(this.labelBitis);
            this.Controls.Add(this.labelBaslangic);
            this.Controls.Add(this.labelAdi);
            this.Controls.Add(this.richTextBoxAciklama);
            this.Controls.Add(this.buttonTemizle);
            this.Controls.Add(this.buttonGuncelle);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.dateTimePickerBitis);
            this.Controls.Add(this.dateTimePickerBaslangic);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(815, 450);
            this.Name = "FormIzinler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İzinler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormIzinler_FormClosing);
            this.Load += new System.EventHandler(this.FormIzinler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePickerBaslangic;
        private System.Windows.Forms.DateTimePicker dateTimePickerBitis;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.RichTextBox richTextBoxAciklama;
        private System.Windows.Forms.Label labelAdi;
        private System.Windows.Forms.Label labelBaslangic;
        private System.Windows.Forms.Label labelBitis;
        private System.Windows.Forms.Button buttonIzinSil;
        private System.Windows.Forms.Button buttonIzınDuzenle;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Button buttonTemizle;
    }
}