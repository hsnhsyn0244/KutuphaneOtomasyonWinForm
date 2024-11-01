namespace KutuphaneOtomasyonWinForm.Dökümanlar
{
    partial class DokumanSilForm
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
            this.dokumanSilBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dokumanSilBtn
            // 
            this.dokumanSilBtn.Location = new System.Drawing.Point(610, 334);
            this.dokumanSilBtn.Name = "dokumanSilBtn";
            this.dokumanSilBtn.Size = new System.Drawing.Size(170, 58);
            this.dokumanSilBtn.TabIndex = 3;
            this.dokumanSilBtn.Text = "Sil";
            this.dokumanSilBtn.UseVisualStyleBackColor = true;
            this.dokumanSilBtn.Click += new System.EventHandler(this.dokumanSilBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(759, 270);
            this.dataGridView1.TabIndex = 2;
            // 
            // DokumanSilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(38)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dokumanSilBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DokumanSilForm";
            this.Text = "DokumanSilForm";
            this.Load += new System.EventHandler(this.DokumanSilForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dokumanSilBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}