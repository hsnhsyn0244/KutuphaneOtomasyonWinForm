namespace KutuphaneOtomasyonWinForm
{
    partial class IslemPaneli
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
            this.kullanibiBilgiTitle = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.kullaniciGüncelleBtn = new System.Windows.Forms.Button();
            this.kullaniciEkleBtn = new System.Windows.Forms.Button();
            this.kullaniciSilBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.kullaniciListeleBtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.DokumanGuncelleBtn = new System.Windows.Forms.Button();
            this.dokumanEkleBtn = new System.Windows.Forms.Button();
            this.dokumanSilBtn = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dokumanListBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kullanibiBilgiTitle
            // 
            this.kullanibiBilgiTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.kullanibiBilgiTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.kullanibiBilgiTitle.Location = new System.Drawing.Point(0, 0);
            this.kullanibiBilgiTitle.Name = "kullanibiBilgiTitle";
            this.kullanibiBilgiTitle.Size = new System.Drawing.Size(1114, 41);
            this.kullanibiBilgiTitle.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.panel2.Controls.Add(this.DokumanGuncelleBtn);
            this.panel2.Controls.Add(this.dokumanEkleBtn);
            this.panel2.Controls.Add(this.dokumanSilBtn);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.dokumanListBtn);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.kullaniciGüncelleBtn);
            this.panel2.Controls.Add(this.kullaniciEkleBtn);
            this.panel2.Controls.Add(this.kullaniciSilBtn);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.kullaniciListeleBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(135, 409);
            this.panel2.TabIndex = 1;
            // 
            // kullaniciGüncelleBtn
            // 
            this.kullaniciGüncelleBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.kullaniciGüncelleBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.kullaniciGüncelleBtn.Location = new System.Drawing.Point(0, 141);
            this.kullaniciGüncelleBtn.Name = "kullaniciGüncelleBtn";
            this.kullaniciGüncelleBtn.Size = new System.Drawing.Size(135, 47);
            this.kullaniciGüncelleBtn.TabIndex = 5;
            this.kullaniciGüncelleBtn.Text = "Kullanıcı Güncelle";
            this.kullaniciGüncelleBtn.UseVisualStyleBackColor = true;
            this.kullaniciGüncelleBtn.Click += new System.EventHandler(this.kullaniciGüncelleBtn_Click);
            // 
            // kullaniciEkleBtn
            // 
            this.kullaniciEkleBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.kullaniciEkleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullaniciEkleBtn.Location = new System.Drawing.Point(0, 94);
            this.kullaniciEkleBtn.Name = "kullaniciEkleBtn";
            this.kullaniciEkleBtn.Size = new System.Drawing.Size(135, 47);
            this.kullaniciEkleBtn.TabIndex = 4;
            this.kullaniciEkleBtn.Text = "Kullanıcı Ekle";
            this.kullaniciEkleBtn.UseVisualStyleBackColor = true;
            this.kullaniciEkleBtn.Click += new System.EventHandler(this.kullaniciEkleBtn_Click);
            // 
            // kullaniciSilBtn
            // 
            this.kullaniciSilBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.kullaniciSilBtn.Location = new System.Drawing.Point(0, 47);
            this.kullaniciSilBtn.Name = "kullaniciSilBtn";
            this.kullaniciSilBtn.Size = new System.Drawing.Size(135, 47);
            this.kullaniciSilBtn.TabIndex = 3;
            this.kullaniciSilBtn.Text = "Kullanıcı Sil";
            this.kullaniciSilBtn.UseVisualStyleBackColor = true;
            this.kullaniciSilBtn.Click += new System.EventHandler(this.kullaniciSilBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(-3, 83);
            this.button3.MaximumSize = new System.Drawing.Size(130, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 0);
            this.button3.TabIndex = 2;
            this.button3.Text = "Kullanici Ekle";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // kullaniciListeleBtn
            // 
            this.kullaniciListeleBtn.BackColor = System.Drawing.Color.White;
            this.kullaniciListeleBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.kullaniciListeleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kullaniciListeleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullaniciListeleBtn.Location = new System.Drawing.Point(0, 0);
            this.kullaniciListeleBtn.Name = "kullaniciListeleBtn";
            this.kullaniciListeleBtn.Size = new System.Drawing.Size(135, 47);
            this.kullaniciListeleBtn.TabIndex = 0;
            this.kullaniciListeleBtn.Text = "Kullaıcılar";
            this.kullaniciListeleBtn.UseVisualStyleBackColor = false;
            this.kullaniciListeleBtn.Click += new System.EventHandler(this.kullaniciListeleBtn_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(-3, 283);
            this.button5.MaximumSize = new System.Drawing.Size(130, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 0);
            this.button5.TabIndex = 6;
            this.button5.Text = "Kullanici Ekle";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // DokumanGuncelleBtn
            // 
            this.DokumanGuncelleBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DokumanGuncelleBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DokumanGuncelleBtn.Location = new System.Drawing.Point(0, 329);
            this.DokumanGuncelleBtn.Name = "DokumanGuncelleBtn";
            this.DokumanGuncelleBtn.Size = new System.Drawing.Size(135, 47);
            this.DokumanGuncelleBtn.TabIndex = 11;
            this.DokumanGuncelleBtn.Text = "Döküman Güncelle";
            this.DokumanGuncelleBtn.UseVisualStyleBackColor = true;
            this.DokumanGuncelleBtn.Click += new System.EventHandler(this.DokumanGuncelleBtn_Click);
            // 
            // dokumanEkleBtn
            // 
            this.dokumanEkleBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dokumanEkleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dokumanEkleBtn.Location = new System.Drawing.Point(0, 282);
            this.dokumanEkleBtn.Name = "dokumanEkleBtn";
            this.dokumanEkleBtn.Size = new System.Drawing.Size(135, 47);
            this.dokumanEkleBtn.TabIndex = 10;
            this.dokumanEkleBtn.Text = "Döküman Ekle";
            this.dokumanEkleBtn.UseVisualStyleBackColor = true;
            this.dokumanEkleBtn.Click += new System.EventHandler(this.dokumanEkleBtn_Click);
            // 
            // dokumanSilBtn
            // 
            this.dokumanSilBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dokumanSilBtn.Location = new System.Drawing.Point(0, 235);
            this.dokumanSilBtn.Name = "dokumanSilBtn";
            this.dokumanSilBtn.Size = new System.Drawing.Size(135, 47);
            this.dokumanSilBtn.TabIndex = 9;
            this.dokumanSilBtn.Text = "Döküman Sil";
            this.dokumanSilBtn.UseVisualStyleBackColor = true;
            this.dokumanSilBtn.Click += new System.EventHandler(this.dokumanSilBtn_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(-2, 193);
            this.button6.MaximumSize = new System.Drawing.Size(130, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(123, 0);
            this.button6.TabIndex = 8;
            this.button6.Text = "Kullanici Ekle";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // dokumanListBtn
            // 
            this.dokumanListBtn.BackColor = System.Drawing.Color.White;
            this.dokumanListBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dokumanListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dokumanListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dokumanListBtn.Location = new System.Drawing.Point(0, 188);
            this.dokumanListBtn.Name = "dokumanListBtn";
            this.dokumanListBtn.Size = new System.Drawing.Size(135, 47);
            this.dokumanListBtn.TabIndex = 7;
            this.dokumanListBtn.Text = "Dökümanlar";
            this.dokumanListBtn.UseVisualStyleBackColor = false;
            this.dokumanListBtn.Click += new System.EventHandler(this.dokumanListBtn_Click);
            // 
            // IslemPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.kullanibiBilgiTitle);
            this.IsMdiContainer = true;
            this.Name = "IslemPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IslemPaneli";
            this.Load += new System.EventHandler(this.IslemPaneli_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel kullanibiBilgiTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button kullaniciListeleBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button kullaniciEkleBtn;
        private System.Windows.Forms.Button kullaniciSilBtn;
        private System.Windows.Forms.Button kullaniciGüncelleBtn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button DokumanGuncelleBtn;
        private System.Windows.Forms.Button dokumanEkleBtn;
        private System.Windows.Forms.Button dokumanSilBtn;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button dokumanListBtn;
    }
}