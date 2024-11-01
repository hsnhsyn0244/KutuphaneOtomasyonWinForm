using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonWinForm.Kullanıcı
{
    public partial class KullaniciEkleForm : Form
    {
        public KullaniciEkleForm()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonuEntities db = new KutuphaneOtomasyonuEntities();
        public void Listele()
        {
            
            var kullanicilar = db.Kullanicilar.ToList();
            dataGridView1.DataSource = kullanicilar;
        }
        private void KullaniciEkleForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void kullaniciEkleKaydetBtn_Click(object sender, EventArgs e)
        {
            Kullanicilar kullanicilar = new Kullanicilar();
            kullanicilar.kullanici_ad = kullaniciEkleAd.Text;
            kullanicilar.kullanici_soyad = kullaniciEkleSoyad.Text;
            kullanicilar.kullanici_mail = kullaniciEkleMail.Text;
            kullanicilar.kullanici_tc = kullaniciEkleTc.Text;
            kullanicilar.kullanici_tel = kullaniciEkleTel.Text;
            kullanicilar.kullanici_ceza = Convert.ToDouble(kullaniciEkleCeza.Text);

            if (kullaniciEkleCinE.Checked == true)
            {
                kullanicilar.kullanici_cinsiyet = "E";
            }else if(kullaniciEkleCinK.Checked == true)
            {
                kullanicilar.kullanici_cinsiyet = "K";
            }
            db.Kullanicilar.Add(kullanicilar);
            db.SaveChanges();
            Listele();
        }

        private void kullaniciEkleSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kullaniciEkleAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void kullaniciEkleCinK_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kullaniciEkleCinE_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kullaniciEkleCeza_TextChanged(object sender, EventArgs e)
        {

        }

        private void kullaniciEkleMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void kullaniciEkleTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void kullaniciEkleTc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
