﻿namespace KutuphaneOtomasyonWinForm.Kullanıcı
{
    partial class KullaniciSilForm
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
            this.kullaiciSilBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(912, 270);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // kullaiciSilBtn
            // 
            this.kullaiciSilBtn.Location = new System.Drawing.Point(711, 318);
            this.kullaiciSilBtn.Name = "kullaiciSilBtn";
            this.kullaiciSilBtn.Size = new System.Drawing.Size(216, 58);
            this.kullaiciSilBtn.TabIndex = 1;
            this.kullaiciSilBtn.Text = "Sil";
            this.kullaiciSilBtn.UseVisualStyleBackColor = true;
            this.kullaiciSilBtn.Click += new System.EventHandler(this.kullaiciSilBtn_Click);
            // 
            // KullaniciSilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(967, 412);
            this.Controls.Add(this.kullaiciSilBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KullaniciSilForm";
            this.Text = "KullaniciSilForm";
            this.Load += new System.EventHandler(this.KullaniciSilForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button kullaiciSilBtn;
    }
}