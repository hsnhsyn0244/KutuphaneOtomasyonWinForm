namespace KutuphaneOtomasyonWinForm.Dökümanlar
{
    partial class DokumanGuncelleForm
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
            this.dokumanGüncelleBasimTarihi = new System.Windows.Forms.DateTimePicker();
            this.dokumanGüncelleSayfaSayısı = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dokumanGüncelleTur = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dokumanGüncelletBtn = new System.Windows.Forms.Button();
            this.dokumanGüncelleYazarAdi = new System.Windows.Forms.TextBox();
            this.dokumanGüncelleYayinEvi = new System.Windows.Forms.TextBox();
            this.dokumanGüncelleAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dokumanGüncelleSayfaSayısı)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dokumanGüncelleBasimTarihi
            // 
            this.dokumanGüncelleBasimTarihi.Location = new System.Drawing.Point(146, 260);
            this.dokumanGüncelleBasimTarihi.Name = "dokumanGüncelleBasimTarihi";
            this.dokumanGüncelleBasimTarihi.Size = new System.Drawing.Size(200, 20);
            this.dokumanGüncelleBasimTarihi.TabIndex = 58;
            // 
            // dokumanGüncelleSayfaSayısı
            // 
            this.dokumanGüncelleSayfaSayısı.Location = new System.Drawing.Point(146, 173);
            this.dokumanGüncelleSayfaSayısı.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.dokumanGüncelleSayfaSayısı.Name = "dokumanGüncelleSayfaSayısı";
            this.dokumanGüncelleSayfaSayısı.Size = new System.Drawing.Size(200, 20);
            this.dokumanGüncelleSayfaSayısı.TabIndex = 57;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(17, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 17);
            this.label10.TabIndex = 56;
            this.label10.Text = "Basım Tarihi : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(40, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 17);
            this.label9.TabIndex = 55;
            this.label9.Text = "Yayın Evi : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(23, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 17);
            this.label8.TabIndex = 54;
            this.label8.Text = "Sayfa Sayısı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(12, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(256, 25);
            this.label7.TabIndex = 53;
            this.label7.Text = "DÖKÜMAN - GÜNCELLE";
            // 
            // dokumanGüncelleTur
            // 
            this.dokumanGüncelleTur.FormattingEnabled = true;
            this.dokumanGüncelleTur.Items.AddRange(new object[] {
            "Roman",
            "Hikaye",
            "Dergi",
            "Masal",
            "Ansiklopedi"});
            this.dokumanGüncelleTur.Location = new System.Drawing.Point(146, 128);
            this.dokumanGüncelleTur.Name = "dokumanGüncelleTur";
            this.dokumanGüncelleTur.Size = new System.Drawing.Size(200, 21);
            this.dokumanGüncelleTur.TabIndex = 52;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(391, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(718, 378);
            this.dataGridView1.TabIndex = 51;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dokumanGüncelletBtn
            // 
            this.dokumanGüncelletBtn.Location = new System.Drawing.Point(203, 360);
            this.dokumanGüncelletBtn.Name = "dokumanGüncelletBtn";
            this.dokumanGüncelletBtn.Size = new System.Drawing.Size(143, 39);
            this.dokumanGüncelletBtn.TabIndex = 50;
            this.dokumanGüncelletBtn.Text = "KAYDET";
            this.dokumanGüncelletBtn.UseVisualStyleBackColor = true;
            this.dokumanGüncelletBtn.Click += new System.EventHandler(this.dokumanGüncelletBtn_Click);
            // 
            // dokumanGüncelleYazarAdi
            // 
            this.dokumanGüncelleYazarAdi.Location = new System.Drawing.Point(146, 305);
            this.dokumanGüncelleYazarAdi.Name = "dokumanGüncelleYazarAdi";
            this.dokumanGüncelleYazarAdi.Size = new System.Drawing.Size(200, 20);
            this.dokumanGüncelleYazarAdi.TabIndex = 49;
            // 
            // dokumanGüncelleYayinEvi
            // 
            this.dokumanGüncelleYayinEvi.Location = new System.Drawing.Point(146, 219);
            this.dokumanGüncelleYayinEvi.Name = "dokumanGüncelleYayinEvi";
            this.dokumanGüncelleYayinEvi.Size = new System.Drawing.Size(200, 20);
            this.dokumanGüncelleYayinEvi.TabIndex = 48;
            // 
            // dokumanGüncelleAd
            // 
            this.dokumanGüncelleAd.Location = new System.Drawing.Point(146, 84);
            this.dokumanGüncelleAd.Name = "dokumanGüncelleAd";
            this.dokumanGüncelleAd.Size = new System.Drawing.Size(200, 20);
            this.dokumanGüncelleAd.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(40, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = "Yazar Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(89, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(78, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "Türü :";
            // 
            // DokumanGuncelleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1121, 516);
            this.Controls.Add(this.dokumanGüncelleBasimTarihi);
            this.Controls.Add(this.dokumanGüncelleSayfaSayısı);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dokumanGüncelleTur);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dokumanGüncelletBtn);
            this.Controls.Add(this.dokumanGüncelleYazarAdi);
            this.Controls.Add(this.dokumanGüncelleYayinEvi);
            this.Controls.Add(this.dokumanGüncelleAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DokumanGuncelleForm";
            this.Text = "DokumanGuncelleForm";
            this.Load += new System.EventHandler(this.DokumanGuncelleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dokumanGüncelleSayfaSayısı)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dokumanGüncelleBasimTarihi;
        private System.Windows.Forms.NumericUpDown dokumanGüncelleSayfaSayısı;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox dokumanGüncelleTur;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button dokumanGüncelletBtn;
        private System.Windows.Forms.TextBox dokumanGüncelleYazarAdi;
        private System.Windows.Forms.TextBox dokumanGüncelleYayinEvi;
        private System.Windows.Forms.TextBox dokumanGüncelleAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}