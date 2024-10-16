using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void NameInput_TextChanged(object sender, EventArgs e)
        {

        }private void passwordInput_TextChanged(object sender, EventArgs e)
        {

        }
        private void GirisBtn_Click(object sender, EventArgs e)
        {
            string gelenAd = NameInput.Text;
            string gelenSifre = passwordInput.Text;

            if (gelenAd.Equals("hasan") && gelenSifre.Equals("1234"))
            {
                MessageBox.Show("Giris Basarılı");
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya sifre hatali");
            }

        }
    }
}
