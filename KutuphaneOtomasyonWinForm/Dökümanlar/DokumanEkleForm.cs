using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonWinForm.Dökümanlar
{
    public partial class DokumanEkleForm : Form
    {
        public DokumanEkleForm()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonuEntities db = new KutuphaneOtomasyonuEntities();

        public void ListeleDokuman()
        {
            var dokumanlar = db.Dokumanlar.ToList();
            dataGridView1.DataSource = dokumanlar;
        }
        private void DokumanEkleForm_Load(object sender, EventArgs e)
        {
            ListeleDokuman();
        }
        private void dokumanEkleKaydetBtn_Click(object sender, EventArgs e)
        {
            Dokumanlar dokumanlar = new Dokumanlar();   
            dokumanlar.dokuman_ad = dokumanEkleAd.Text;
            dokumanlar.dokuman_sayfaSayisi = Convert.ToInt16(dokumanEkleSayfaSayısı.Value); 
            dokumanlar.dokuman_yayinci = dokumanEkleYayinEvi.Text;
            dokumanlar.dokuman_basimTarihi = dokumanEkleBasimTarihi.Value;
            dokumanlar.dokuman_yazar = dokumanEkleYazarAdi.Text;
            // combobox içindeki veriyi seçimini bu şekilde yapıyoruz.
            dokumanlar.dokuman_turu = dokumanEkleTur.GetItemText(dokumanEkleTur.SelectedItem);
            db.Dokumanlar.Add(dokumanlar);
            db.SaveChanges();
            ListeleDokuman();

        }
        private void dokumanEkleAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void dokumanEkleSayfaSayısı_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dokumanEkleTur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
