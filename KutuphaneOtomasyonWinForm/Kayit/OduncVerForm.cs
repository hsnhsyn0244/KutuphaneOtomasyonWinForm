using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonWinForm.Kayıt_İşlemi
{
    public partial class OduncVerForm : Form
    {
        public OduncVerForm()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonuEntities db= new KutuphaneOtomasyonuEntities();

        private void OduncVerForm_Load(object sender, EventArgs e)
        {
            // Kayıt Listeleme işlemi yapıldı
            var kayıtList = db.Kayitlar.ToList();
            dataGridView1.DataSource = kayıtList;

            // Dokuman Listeleme

            var dokumanList = db.Dokumanlar.ToList();
            dataGridView2.DataSource = dokumanList;
            
            // Gözükmesini istemediğimiz columsları gizledik
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;

            //colums name değiştirdik
            dataGridView1.Columns[1].HeaderText = "Kullanıcı";
            dataGridView1.Columns[2].HeaderText = "Doküman Ad";

        }

        private void arananKullaniciTcBtn_Click(object sender, EventArgs e)
        {
            string arananTc = arananKullaniciTcText.Text;
            var kullaniciVarMi = db.Kullanicilar.Where(_arananTc => _arananTc.kullanici_tc == arananTc).FirstOrDefault();
            if (kullaniciVarMi!= null)
            {
            label2.Text = kullaniciVarMi.kullanici_ad + "  " + kullaniciVarMi.kullanici_soyad;
            }
            else
            {
                label2.Text = " !!!  BÖYLE BİR KULLANICI BULUNAMADI. ";
            }
        }

        private void kitapAraText_TextChanged(object sender, EventArgs e)
        {
            // Kitap Adına göre filtreleme yaptık.
            string aranacakAd = kitapAraText.Text;
            var bulunanDokumanlar = db.Dokumanlar.Where(_aranacakAd => _aranacakAd.dokuman_ad.Contains(aranacakAd)).ToList(); //Contains metodu içeriyor mu demek.
            dataGridView2.DataSource = bulunanDokumanlar;
        }
    }
}
