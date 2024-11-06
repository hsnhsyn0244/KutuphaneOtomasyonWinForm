namespace KutuphaneOtomasyonWinForm.Kayıt_İşlemi
{
    partial class OduncVerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.arananKullaniciTcText = new System.Windows.Forms.TextBox();
            this.arananKullaniciTcBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.kitapAraText = new System.Windows.Forms.TextBox();
            this.oduncVerBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 344);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1299, 264);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı TC Giriniz :";
            // 
            // arananKullaniciTcText
            // 
            this.arananKullaniciTcText.Location = new System.Drawing.Point(198, 16);
            this.arananKullaniciTcText.Name = "arananKullaniciTcText";
            this.arananKullaniciTcText.Size = new System.Drawing.Size(239, 20);
            this.arananKullaniciTcText.TabIndex = 2;
            // 
            // arananKullaniciTcBtn
            // 
            this.arananKullaniciTcBtn.Location = new System.Drawing.Point(312, 42);
            this.arananKullaniciTcBtn.Name = "arananKullaniciTcBtn";
            this.arananKullaniciTcBtn.Size = new System.Drawing.Size(125, 23);
            this.arananKullaniciTcBtn.TabIndex = 3;
            this.arananKullaniciTcBtn.Text = "Ara";
            this.arananKullaniciTcBtn.UseVisualStyleBackColor = true;
            this.arananKullaniciTcBtn.Click += new System.EventHandler(this.arananKullaniciTcBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(500, 79);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(811, 242);
            this.dataGridView2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(497, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kitap Ara :";
            // 
            // kitapAraText
            // 
            this.kitapAraText.Location = new System.Drawing.Point(605, 16);
            this.kitapAraText.Name = "kitapAraText";
            this.kitapAraText.Size = new System.Drawing.Size(268, 20);
            this.kitapAraText.TabIndex = 7;
            this.kitapAraText.TextChanged += new System.EventHandler(this.kitapAraText_TextChanged);
            // 
            // oduncVerBtn
            // 
            this.oduncVerBtn.Location = new System.Drawing.Point(133, 267);
            this.oduncVerBtn.Name = "oduncVerBtn";
            this.oduncVerBtn.Size = new System.Drawing.Size(154, 54);
            this.oduncVerBtn.TabIndex = 8;
            this.oduncVerBtn.Text = "Ödünç Ver";
            this.oduncVerBtn.UseVisualStyleBackColor = true;
            this.oduncVerBtn.Click += new System.EventHandler(this.oduncVerBtn_Click);
            // 
            // OduncVerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1323, 620);
            this.Controls.Add(this.oduncVerBtn);
            this.Controls.Add(this.kitapAraText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.arananKullaniciTcBtn);
            this.Controls.Add(this.arananKullaniciTcText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OduncVerForm";
            this.Text = "OduncVerForm";
            this.Load += new System.EventHandler(this.OduncVerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox arananKullaniciTcText;
        private System.Windows.Forms.Button arananKullaniciTcBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kitapAraText;
        private System.Windows.Forms.Button oduncVerBtn;
    }
}