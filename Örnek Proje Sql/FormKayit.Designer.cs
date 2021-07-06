namespace Örnek_Proje_Sql
{
    partial class FormKayit
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
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.textBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.labelSifre = new System.Windows.Forms.Label();
            this.labelKullaniciAdi = new System.Windows.Forms.Label();
            this.textBoxSifre2 = new System.Windows.Forms.TextBox();
            this.labelSifre2 = new System.Windows.Forms.Label();
            this.buttonKayit = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(145, 57);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.PasswordChar = '*';
            this.textBoxSifre.Size = new System.Drawing.Size(160, 26);
            this.textBoxSifre.TabIndex = 5;
            // 
            // textBoxKullaniciAdi
            // 
            this.textBoxKullaniciAdi.Location = new System.Drawing.Point(145, 20);
            this.textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            this.textBoxKullaniciAdi.Size = new System.Drawing.Size(160, 26);
            this.textBoxKullaniciAdi.TabIndex = 2;
            // 
            // labelSifre
            // 
            this.labelSifre.AutoSize = true;
            this.labelSifre.Location = new System.Drawing.Point(27, 60);
            this.labelSifre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSifre.Name = "labelSifre";
            this.labelSifre.Size = new System.Drawing.Size(46, 20);
            this.labelSifre.TabIndex = 3;
            this.labelSifre.Text = "Şifre:";
            // 
            // labelKullaniciAdi
            // 
            this.labelKullaniciAdi.AutoSize = true;
            this.labelKullaniciAdi.Location = new System.Drawing.Point(27, 23);
            this.labelKullaniciAdi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKullaniciAdi.Name = "labelKullaniciAdi";
            this.labelKullaniciAdi.Size = new System.Drawing.Size(97, 20);
            this.labelKullaniciAdi.TabIndex = 4;
            this.labelKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // textBoxSifre2
            // 
            this.textBoxSifre2.Location = new System.Drawing.Point(145, 92);
            this.textBoxSifre2.Name = "textBoxSifre2";
            this.textBoxSifre2.PasswordChar = '*';
            this.textBoxSifre2.Size = new System.Drawing.Size(160, 26);
            this.textBoxSifre2.TabIndex = 7;
            this.textBoxSifre2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSifre2_KeyDown);
            // 
            // labelSifre2
            // 
            this.labelSifre2.AutoSize = true;
            this.labelSifre2.Location = new System.Drawing.Point(27, 95);
            this.labelSifre2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSifre2.Name = "labelSifre2";
            this.labelSifre2.Size = new System.Drawing.Size(46, 20);
            this.labelSifre2.TabIndex = 6;
            this.labelSifre2.Text = "Şifre:";
            // 
            // buttonKayit
            // 
            this.buttonKayit.Location = new System.Drawing.Point(145, 139);
            this.buttonKayit.Name = "buttonKayit";
            this.buttonKayit.Size = new System.Drawing.Size(78, 33);
            this.buttonKayit.TabIndex = 8;
            this.buttonKayit.Text = "Kayıt Ol";
            this.buttonKayit.UseVisualStyleBackColor = true;
            this.buttonKayit.Click += new System.EventHandler(this.buttonKayit_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.DarkRed;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonExit.Location = new System.Drawing.Point(309, -1);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(20, 20);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 184);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonKayit);
            this.Controls.Add(this.textBoxSifre2);
            this.Controls.Add(this.labelSifre2);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.textBoxKullaniciAdi);
            this.Controls.Add(this.labelSifre);
            this.Controls.Add(this.labelKullaniciAdi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.TextBox textBoxKullaniciAdi;
        private System.Windows.Forms.Label labelSifre;
        private System.Windows.Forms.Label labelKullaniciAdi;
        private System.Windows.Forms.TextBox textBoxSifre2;
        private System.Windows.Forms.Label labelSifre2;
        private System.Windows.Forms.Button buttonKayit;
        private System.Windows.Forms.Button buttonExit;
    }
}