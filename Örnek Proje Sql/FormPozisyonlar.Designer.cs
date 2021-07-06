namespace Örnek_Proje_Sql
{
    partial class FormPozisyonlar
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
            this.textBoxPozisyonAdi = new System.Windows.Forms.TextBox();
            this.labelDepartmanAdi = new System.Windows.Forms.Label();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPozisyonAdi
            // 
            this.textBoxPozisyonAdi.Location = new System.Drawing.Point(146, 271);
            this.textBoxPozisyonAdi.Name = "textBoxPozisyonAdi";
            this.textBoxPozisyonAdi.Size = new System.Drawing.Size(142, 26);
            this.textBoxPozisyonAdi.TabIndex = 8;
            // 
            // labelDepartmanAdi
            // 
            this.labelDepartmanAdi.AutoSize = true;
            this.labelDepartmanAdi.Location = new System.Drawing.Point(20, 273);
            this.labelDepartmanAdi.Name = "labelDepartmanAdi";
            this.labelDepartmanAdi.Size = new System.Drawing.Size(103, 20);
            this.labelDepartmanAdi.TabIndex = 7;
            this.labelDepartmanAdi.Text = "Pozisyon Adı:";
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(119, 216);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(214, 41);
            this.buttonSil.TabIndex = 5;
            this.buttonSil.Text = "Seçili Pozisyonu Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonEkle
            // 
            this.buttonEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEkle.Location = new System.Drawing.Point(294, 264);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(131, 41);
            this.buttonEkle.TabIndex = 6;
            this.buttonEkle.Text = "Pozisyon Ekle";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(82, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(272, 194);
            this.dataGridView1.TabIndex = 4;
            // 
            // FormPozisyonlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(439, 321);
            this.Controls.Add(this.textBoxPozisyonAdi);
            this.Controls.Add(this.labelDepartmanAdi);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(455, 360);
            this.Name = "FormPozisyonlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pozisyonlar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPozisyonlar_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPozisyonAdi;
        private System.Windows.Forms.Label labelDepartmanAdi;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}