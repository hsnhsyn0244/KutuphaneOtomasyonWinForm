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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1299, 230);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(39, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı TC Giriniz :";
            // 
            // arananKullaniciTcText
            // 
            this.arananKullaniciTcText.Location = new System.Drawing.Point(227, 44);
            this.arananKullaniciTcText.Name = "arananKullaniciTcText";
            this.arananKullaniciTcText.Size = new System.Drawing.Size(239, 20);
            this.arananKullaniciTcText.TabIndex = 2;
            // 
            // arananKullaniciTcBtn
            // 
            this.arananKullaniciTcBtn.Location = new System.Drawing.Point(520, 40);
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
            this.label2.Location = new System.Drawing.Point(224, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // OduncVerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1323, 512);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.arananKullaniciTcBtn);
            this.Controls.Add(this.arananKullaniciTcText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OduncVerForm";
            this.Text = "OduncVerForm";
            this.Load += new System.EventHandler(this.OduncVerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox arananKullaniciTcText;
        private System.Windows.Forms.Button arananKullaniciTcBtn;
        private System.Windows.Forms.Label label2;
    }
}