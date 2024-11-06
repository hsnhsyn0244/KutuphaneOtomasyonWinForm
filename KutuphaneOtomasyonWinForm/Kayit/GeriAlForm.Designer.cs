namespace KutuphaneOtomasyonWinForm.Kayit
{
    partial class GeriAlForm
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
            this.kitapTeslimBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1291, 465);
            this.dataGridView1.TabIndex = 0;
            // 
            // kitapTeslimBtn
            // 
            this.kitapTeslimBtn.Location = new System.Drawing.Point(1112, 540);
            this.kitapTeslimBtn.Name = "kitapTeslimBtn";
            this.kitapTeslimBtn.Size = new System.Drawing.Size(191, 58);
            this.kitapTeslimBtn.TabIndex = 1;
            this.kitapTeslimBtn.Text = "Teslim Edildi";
            this.kitapTeslimBtn.UseVisualStyleBackColor = true;
            this.kitapTeslimBtn.Click += new System.EventHandler(this.kitapTeslimBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kitaplarını Teslim Etmeyen Kullanıcılar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GeriAlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1315, 684);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kitapTeslimBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GeriAlForm";
            this.Text = "GeriAlForm";
            this.Load += new System.EventHandler(this.GeriAlForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button kitapTeslimBtn;
        private System.Windows.Forms.Label label1;
    }
}