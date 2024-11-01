namespace KutuphaneOtomasyonWinForm.Dökümanlar
{
    partial class DokumanEkleForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dokumanEkleKaydetBtn = new System.Windows.Forms.Button();
            this.dokumanEkleYazarAdi = new System.Windows.Forms.TextBox();
            this.dokumanEkleYayinEvi = new System.Windows.Forms.TextBox();
            this.dokumanEkleAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dokumanEkleTur = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dokumanEkleSayfaSayısı = new System.Windows.Forms.NumericUpDown();
            this.dokumanEkleBasimTarihi = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokumanEkleSayfaSayısı)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(391, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(753, 455);
            this.dataGridView1.TabIndex = 34;
            // 
            // dokumanEkleKaydetBtn
            // 
            this.dokumanEkleKaydetBtn.Location = new System.Drawing.Point(204, 364);
            this.dokumanEkleKaydetBtn.Name = "dokumanEkleKaydetBtn";
            this.dokumanEkleKaydetBtn.Size = new System.Drawing.Size(143, 39);
            this.dokumanEkleKaydetBtn.TabIndex = 33;
            this.dokumanEkleKaydetBtn.Text = "KAYDET";
            this.dokumanEkleKaydetBtn.UseVisualStyleBackColor = true;
            this.dokumanEkleKaydetBtn.Click += new System.EventHandler(this.dokumanEkleKaydetBtn_Click);
            // 
            // dokumanEkleYazarAdi
            // 
            this.dokumanEkleYazarAdi.Location = new System.Drawing.Point(147, 309);
            this.dokumanEkleYazarAdi.Name = "dokumanEkleYazarAdi";
            this.dokumanEkleYazarAdi.Size = new System.Drawing.Size(200, 20);
            this.dokumanEkleYazarAdi.TabIndex = 29;
            // 
            // dokumanEkleYayinEvi
            // 
            this.dokumanEkleYayinEvi.Location = new System.Drawing.Point(147, 223);
            this.dokumanEkleYayinEvi.Name = "dokumanEkleYayinEvi";
            this.dokumanEkleYayinEvi.Size = new System.Drawing.Size(200, 20);
            this.dokumanEkleYayinEvi.TabIndex = 27;
            // 
            // dokumanEkleAd
            // 
            this.dokumanEkleAd.Location = new System.Drawing.Point(147, 88);
            this.dokumanEkleAd.Name = "dokumanEkleAd";
            this.dokumanEkleAd.Size = new System.Drawing.Size(200, 20);
            this.dokumanEkleAd.TabIndex = 26;
            this.dokumanEkleAd.TextChanged += new System.EventHandler(this.dokumanEkleAd_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(41, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Yazar Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(90, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(79, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Türü :";
            // 
            // dokumanEkleTur
            // 
            this.dokumanEkleTur.FormattingEnabled = true;
            this.dokumanEkleTur.Items.AddRange(new object[] {
            "Roman",
            "Hikaye",
            "Dergi",
            "Masal",
            "Ansiklopedi"});
            this.dokumanEkleTur.Location = new System.Drawing.Point(147, 132);
            this.dokumanEkleTur.Name = "dokumanEkleTur";
            this.dokumanEkleTur.Size = new System.Drawing.Size(200, 21);
            this.dokumanEkleTur.TabIndex = 35;
            this.dokumanEkleTur.SelectedIndexChanged += new System.EventHandler(this.dokumanEkleTur_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(12, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 25);
            this.label7.TabIndex = 36;
            this.label7.Text = "DÖKÜMAN - EKLE";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(24, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "Sayfa Sayısı :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(41, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 17);
            this.label9.TabIndex = 39;
            this.label9.Text = "Yayın Evi : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(18, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 17);
            this.label10.TabIndex = 40;
            this.label10.Text = "Basım Tarihi : ";
            // 
            // dokumanEkleSayfaSayısı
            // 
            this.dokumanEkleSayfaSayısı.Location = new System.Drawing.Point(147, 177);
            this.dokumanEkleSayfaSayısı.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.dokumanEkleSayfaSayısı.Name = "dokumanEkleSayfaSayısı";
            this.dokumanEkleSayfaSayısı.Size = new System.Drawing.Size(200, 20);
            this.dokumanEkleSayfaSayısı.TabIndex = 42;
            this.dokumanEkleSayfaSayısı.ValueChanged += new System.EventHandler(this.dokumanEkleSayfaSayısı_ValueChanged);
            // 
            // dokumanEkleBasimTarihi
            // 
            this.dokumanEkleBasimTarihi.Location = new System.Drawing.Point(147, 264);
            this.dokumanEkleBasimTarihi.Name = "dokumanEkleBasimTarihi";
            this.dokumanEkleBasimTarihi.Size = new System.Drawing.Size(200, 20);
            this.dokumanEkleBasimTarihi.TabIndex = 43;
            // 
            // DokumanEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1168, 598);
            this.Controls.Add(this.dokumanEkleBasimTarihi);
            this.Controls.Add(this.dokumanEkleSayfaSayısı);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dokumanEkleTur);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dokumanEkleKaydetBtn);
            this.Controls.Add(this.dokumanEkleYazarAdi);
            this.Controls.Add(this.dokumanEkleYayinEvi);
            this.Controls.Add(this.dokumanEkleAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DokumanEkleForm";
            this.Text = "DokumanEkle";
            this.Load += new System.EventHandler(this.DokumanEkleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dokumanEkleSayfaSayısı)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button dokumanEkleKaydetBtn;
        private System.Windows.Forms.TextBox dokumanEkleYazarAdi;
        private System.Windows.Forms.TextBox dokumanEkleYayinEvi;
        private System.Windows.Forms.TextBox dokumanEkleAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox dokumanEkleTur;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown dokumanEkleSayfaSayısı;
        private System.Windows.Forms.DateTimePicker dokumanEkleBasimTarihi;
    }
}