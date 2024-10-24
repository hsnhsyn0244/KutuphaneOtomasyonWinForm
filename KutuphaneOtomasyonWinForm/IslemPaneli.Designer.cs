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
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.panel2.Controls.Add(this.kullaniciGüncelleBtn);
            this.panel2.Controls.Add(this.kullaniciEkleBtn);
            this.panel2.Controls.Add(this.kullaniciSilBtn);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.kullaniciListeleBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 409);
            this.panel2.TabIndex = 1;
            // 
            // kullaniciGüncelleBtn
            // 
            this.kullaniciGüncelleBtn.Location = new System.Drawing.Point(0, 179);
            this.kullaniciGüncelleBtn.Name = "kullaniciGüncelleBtn";
            this.kullaniciGüncelleBtn.Size = new System.Drawing.Size(120, 47);
            this.kullaniciGüncelleBtn.TabIndex = 5;
            this.kullaniciGüncelleBtn.Text = "Kullanıcı Güncelle";
            this.kullaniciGüncelleBtn.UseVisualStyleBackColor = true;
            this.kullaniciGüncelleBtn.Click += new System.EventHandler(this.kullaniciGüncelleBtn_Click);
            // 
            // kullaniciEkleBtn
            // 
            this.kullaniciEkleBtn.Location = new System.Drawing.Point(0, 89);
            this.kullaniciEkleBtn.Name = "kullaniciEkleBtn";
            this.kullaniciEkleBtn.Size = new System.Drawing.Size(120, 47);
            this.kullaniciEkleBtn.TabIndex = 4;
            this.kullaniciEkleBtn.Text = "Kullanıcı Ekle";
            this.kullaniciEkleBtn.UseVisualStyleBackColor = true;
            this.kullaniciEkleBtn.Click += new System.EventHandler(this.kullaniciEkleBtn_Click);
            // 
            // kullaniciSilBtn
            // 
            this.kullaniciSilBtn.Location = new System.Drawing.Point(0, 270);
            this.kullaniciSilBtn.Name = "kullaniciSilBtn";
            this.kullaniciSilBtn.Size = new System.Drawing.Size(120, 47);
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
            this.kullaniciListeleBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.kullaniciListeleBtn.Location = new System.Drawing.Point(0, 0);
            this.kullaniciListeleBtn.Name = "kullaniciListeleBtn";
            this.kullaniciListeleBtn.Size = new System.Drawing.Size(120, 47);
            this.kullaniciListeleBtn.TabIndex = 0;
            this.kullaniciListeleBtn.Text = "Kullaıcılar";
            this.kullaniciListeleBtn.UseVisualStyleBackColor = true;
            this.kullaniciListeleBtn.Click += new System.EventHandler(this.kullaniciListeleBtn_Click);
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
    }
}