namespace Örnek_Proje_Sql
{
    partial class FormGiris
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
            this.components = new System.ComponentModel.Container();
            this.buttonCalisanlar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_tarih = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_saat = new System.Windows.Forms.Label();
            this.buttonDepartmanlar = new System.Windows.Forms.Button();
            this.buttonPozisyonlar = new System.Windows.Forms.Button();
            this.buttonSubeler = new System.Windows.Forms.Button();
            this.buttonIzinler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCalisanlar
            // 
            this.buttonCalisanlar.AutoSize = true;
            this.buttonCalisanlar.BackColor = System.Drawing.Color.MistyRose;
            this.buttonCalisanlar.Location = new System.Drawing.Point(36, 68);
            this.buttonCalisanlar.Name = "buttonCalisanlar";
            this.buttonCalisanlar.Size = new System.Drawing.Size(116, 36);
            this.buttonCalisanlar.TabIndex = 0;
            this.buttonCalisanlar.Text = "Çalışanlar";
            this.buttonCalisanlar.UseVisualStyleBackColor = false;
            this.buttonCalisanlar.Click += new System.EventHandler(this.buttonCalisanlar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Salmon;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(179, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hoşgeldiniz!";
            // 
            // label_tarih
            // 
            this.label_tarih.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_tarih.AutoSize = true;
            this.label_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_tarih.Location = new System.Drawing.Point(12, 233);
            this.label_tarih.Name = "label_tarih";
            this.label_tarih.Size = new System.Drawing.Size(40, 20);
            this.label_tarih.TabIndex = 2;
            this.label_tarih.Text = "tarih";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_saat
            // 
            this.label_saat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_saat.AutoSize = true;
            this.label_saat.Location = new System.Drawing.Point(420, 233);
            this.label_saat.Name = "label_saat";
            this.label_saat.Size = new System.Drawing.Size(40, 20);
            this.label_saat.TabIndex = 3;
            this.label_saat.Text = "saat";
            // 
            // buttonDepartmanlar
            // 
            this.buttonDepartmanlar.AutoSize = true;
            this.buttonDepartmanlar.BackColor = System.Drawing.Color.MistyRose;
            this.buttonDepartmanlar.Location = new System.Drawing.Point(36, 110);
            this.buttonDepartmanlar.Name = "buttonDepartmanlar";
            this.buttonDepartmanlar.Size = new System.Drawing.Size(116, 36);
            this.buttonDepartmanlar.TabIndex = 1;
            this.buttonDepartmanlar.Text = "Departmanlar";
            this.buttonDepartmanlar.UseVisualStyleBackColor = false;
            this.buttonDepartmanlar.Click += new System.EventHandler(this.buttonDepartmanlar_Click);
            // 
            // buttonPozisyonlar
            // 
            this.buttonPozisyonlar.AutoSize = true;
            this.buttonPozisyonlar.BackColor = System.Drawing.Color.MistyRose;
            this.buttonPozisyonlar.Location = new System.Drawing.Point(36, 152);
            this.buttonPozisyonlar.Name = "buttonPozisyonlar";
            this.buttonPozisyonlar.Size = new System.Drawing.Size(116, 36);
            this.buttonPozisyonlar.TabIndex = 2;
            this.buttonPozisyonlar.Text = "Pozisyonlar";
            this.buttonPozisyonlar.UseVisualStyleBackColor = false;
            this.buttonPozisyonlar.Click += new System.EventHandler(this.buttonPozisyonlar_Click);
            // 
            // buttonSubeler
            // 
            this.buttonSubeler.AutoSize = true;
            this.buttonSubeler.BackColor = System.Drawing.Color.MistyRose;
            this.buttonSubeler.Location = new System.Drawing.Point(194, 68);
            this.buttonSubeler.Name = "buttonSubeler";
            this.buttonSubeler.Size = new System.Drawing.Size(116, 36);
            this.buttonSubeler.TabIndex = 3;
            this.buttonSubeler.Text = "Şubeler";
            this.buttonSubeler.UseVisualStyleBackColor = false;
            this.buttonSubeler.Click += new System.EventHandler(this.buttonSubeler_Click);
            // 
            // buttonIzinler
            // 
            this.buttonIzinler.AutoSize = true;
            this.buttonIzinler.BackColor = System.Drawing.Color.MistyRose;
            this.buttonIzinler.Location = new System.Drawing.Point(194, 110);
            this.buttonIzinler.Name = "buttonIzinler";
            this.buttonIzinler.Size = new System.Drawing.Size(116, 36);
            this.buttonIzinler.TabIndex = 4;
            this.buttonIzinler.Text = "İzinler";
            this.buttonIzinler.UseVisualStyleBackColor = false;
            this.buttonIzinler.Click += new System.EventHandler(this.buttonIzinler_Click);
            // 
            // FormGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(499, 261);
            this.Controls.Add(this.label_saat);
            this.Controls.Add(this.label_tarih);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonIzinler);
            this.Controls.Add(this.buttonSubeler);
            this.Controls.Add(this.buttonPozisyonlar);
            this.Controls.Add(this.buttonDepartmanlar);
            this.Controls.Add(this.buttonCalisanlar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(515, 300);
            this.Name = "FormGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İnsan Kaynakları Personeli Yönetim Paneli";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGiris_FormClosed);
            this.Load += new System.EventHandler(this.FormGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalisanlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_tarih;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_saat;
        private System.Windows.Forms.Button buttonDepartmanlar;
        private System.Windows.Forms.Button buttonPozisyonlar;
        private System.Windows.Forms.Button buttonSubeler;
        private System.Windows.Forms.Button buttonIzinler;
    }
}