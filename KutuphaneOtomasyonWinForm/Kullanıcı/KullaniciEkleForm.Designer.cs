namespace KutuphaneOtomasyonWinForm.Kullanıcı
{
    partial class KullaniciEkleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.kullaniciEkleAd = new System.Windows.Forms.TextBox();
            this.kullaniciEkleSoyad = new System.Windows.Forms.TextBox();
            this.kullaniciEkleTc = new System.Windows.Forms.TextBox();
            this.kullaniciEkleTel = new System.Windows.Forms.TextBox();
            this.kullaniciEkleMail = new System.Windows.Forms.TextBox();
            this.kullaniciEkleCeza = new System.Windows.Forms.TextBox();
            this.kullaniciEkleCinE = new System.Windows.Forms.RadioButton();
            this.kullaniciEkleCinK = new System.Windows.Forms.RadioButton();
            this.kullaniciEkleKaydetBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "AD :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "SOYAD :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "TEL :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "MAİL :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "CEZA :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "CİNSİYET :";
            // 
            // kullaniciEkleAd
            // 
            this.kullaniciEkleAd.Location = new System.Drawing.Point(123, 43);
            this.kullaniciEkleAd.Name = "kullaniciEkleAd";
            this.kullaniciEkleAd.Size = new System.Drawing.Size(153, 20);
            this.kullaniciEkleAd.TabIndex = 7;
            // 
            // kullaniciEkleSoyad
            // 
            this.kullaniciEkleSoyad.Location = new System.Drawing.Point(123, 85);
            this.kullaniciEkleSoyad.Name = "kullaniciEkleSoyad";
            this.kullaniciEkleSoyad.Size = new System.Drawing.Size(153, 20);
            this.kullaniciEkleSoyad.TabIndex = 8;
            this.kullaniciEkleSoyad.TextChanged += new System.EventHandler(this.kullaniciEkleSoyad_TextChanged);
            // 
            // kullaniciEkleTc
            // 
            this.kullaniciEkleTc.Location = new System.Drawing.Point(123, 173);
            this.kullaniciEkleTc.Name = "kullaniciEkleTc";
            this.kullaniciEkleTc.Size = new System.Drawing.Size(153, 20);
            this.kullaniciEkleTc.TabIndex = 10;
            // 
            // kullaniciEkleTel
            // 
            this.kullaniciEkleTel.Location = new System.Drawing.Point(123, 212);
            this.kullaniciEkleTel.Name = "kullaniciEkleTel";
            this.kullaniciEkleTel.Size = new System.Drawing.Size(153, 20);
            this.kullaniciEkleTel.TabIndex = 11;
            // 
            // kullaniciEkleMail
            // 
            this.kullaniciEkleMail.Location = new System.Drawing.Point(123, 254);
            this.kullaniciEkleMail.Name = "kullaniciEkleMail";
            this.kullaniciEkleMail.Size = new System.Drawing.Size(153, 20);
            this.kullaniciEkleMail.TabIndex = 12;
            // 
            // kullaniciEkleCeza
            // 
            this.kullaniciEkleCeza.Location = new System.Drawing.Point(123, 302);
            this.kullaniciEkleCeza.Name = "kullaniciEkleCeza";
            this.kullaniciEkleCeza.Size = new System.Drawing.Size(153, 20);
            this.kullaniciEkleCeza.TabIndex = 13;
            // 
            // kullaniciEkleCinE
            // 
            this.kullaniciEkleCinE.AutoSize = true;
            this.kullaniciEkleCinE.Location = new System.Drawing.Point(123, 130);
            this.kullaniciEkleCinE.Name = "kullaniciEkleCinE";
            this.kullaniciEkleCinE.Size = new System.Drawing.Size(32, 17);
            this.kullaniciEkleCinE.TabIndex = 14;
            this.kullaniciEkleCinE.TabStop = true;
            this.kullaniciEkleCinE.Text = "E";
            this.kullaniciEkleCinE.UseVisualStyleBackColor = true;
            // 
            // kullaniciEkleCinK
            // 
            this.kullaniciEkleCinK.AutoSize = true;
            this.kullaniciEkleCinK.Location = new System.Drawing.Point(197, 130);
            this.kullaniciEkleCinK.Name = "kullaniciEkleCinK";
            this.kullaniciEkleCinK.Size = new System.Drawing.Size(32, 17);
            this.kullaniciEkleCinK.TabIndex = 15;
            this.kullaniciEkleCinK.TabStop = true;
            this.kullaniciEkleCinK.Text = "K";
            this.kullaniciEkleCinK.UseVisualStyleBackColor = true;
            // 
            // kullaniciEkleKaydetBtn
            // 
            this.kullaniciEkleKaydetBtn.Location = new System.Drawing.Point(148, 352);
            this.kullaniciEkleKaydetBtn.Name = "kullaniciEkleKaydetBtn";
            this.kullaniciEkleKaydetBtn.Size = new System.Drawing.Size(128, 26);
            this.kullaniciEkleKaydetBtn.TabIndex = 16;
            this.kullaniciEkleKaydetBtn.Text = "KAYDET";
            this.kullaniciEkleKaydetBtn.UseVisualStyleBackColor = true;
            this.kullaniciEkleKaydetBtn.Click += new System.EventHandler(this.kullaniciEkleKaydetBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(299, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(898, 335);
            this.dataGridView1.TabIndex = 17;
            // 
            // KullaniciEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 517);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.kullaniciEkleKaydetBtn);
            this.Controls.Add(this.kullaniciEkleCinK);
            this.Controls.Add(this.kullaniciEkleCinE);
            this.Controls.Add(this.kullaniciEkleCeza);
            this.Controls.Add(this.kullaniciEkleMail);
            this.Controls.Add(this.kullaniciEkleTel);
            this.Controls.Add(this.kullaniciEkleTc);
            this.Controls.Add(this.kullaniciEkleSoyad);
            this.Controls.Add(this.kullaniciEkleAd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KullaniciEkleForm";
            this.Text = "KullaniciEkleForm";
            this.Load += new System.EventHandler(this.KullaniciEkleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox kullaniciEkleAd;
        private System.Windows.Forms.TextBox kullaniciEkleSoyad;
        private System.Windows.Forms.TextBox kullaniciEkleTc;
        private System.Windows.Forms.TextBox kullaniciEkleTel;
        private System.Windows.Forms.TextBox kullaniciEkleMail;
        private System.Windows.Forms.TextBox kullaniciEkleCeza;
        private System.Windows.Forms.RadioButton kullaniciEkleCinE;
        private System.Windows.Forms.RadioButton kullaniciEkleCinK;
        private System.Windows.Forms.Button kullaniciEkleKaydetBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}