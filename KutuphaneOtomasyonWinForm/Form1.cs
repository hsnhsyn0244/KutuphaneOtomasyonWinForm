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
        // App.config dosyasındaki name keyi ile ulaşmış olduk veri tabanına
        KutuphaneOtomasyonuEntities db = new KutuphaneOtomasyonuEntities();
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
        private void userNameInput_TextChanged(object sender, EventArgs e)
        {

        }
        private void passwordInput_TextChanged(object sender, EventArgs e)
        {

        }
        private void GirisBtn_Click(object sender, EventArgs e)
        {
            string gelenAd = userNameInput.Text;
            string gelenSifre = passwordInput.Text;
            // Linq sorgusu
            var personeller = db.Personeller.Where(_personel => _personel.personel_kullaniciAd.Equals(gelenAd) && _personel.personel_sifre.Equals(gelenSifre) ).FirstOrDefault();

            if (personeller == null)
            {
                 MessageBox.Show("Kullanıcı adı veya sifre hatali");
            }
            else
            {
                MessageBox.Show("Başarılı");
                IslemPaneli panel = new IslemPaneli();
                panel.Show();
                this.Hide();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
