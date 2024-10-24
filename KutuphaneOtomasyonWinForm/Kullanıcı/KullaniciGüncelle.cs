using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonWinForm.Kullanıcı
{
    public partial class KullaniciGüncelle : Form
    {
        public KullaniciGüncelle()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonuEntities db = new KutuphaneOtomasyonuEntities();
        public void Listele()
        {
            var kullanicilar = db.Kullanicilar.ToList();
            dataGridView1.DataSource = kullanicilar;
        }

        private void KullaniciGüncelle_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void kullaniciGüncelleBtn_Click(object sender, EventArgs e)
        {
            int secilenId = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var kullanici = db.Kullanicilar.Where(_kullanici => _kullanici.kullanici_id == secilenId).FirstOrDefault();
            kullanici.kullanici_ad = kullaniciGüncelleAd.Text;
            kullanici.kullanici_soyad = kullaniciGüncelleSoyad.Text;
            kullanici.kullanici_mail = kullaniciGüncelleMail.Text;
            kullanici.kullanici_tc = kullaniciGüncelleTc.Text;
            kullanici.kullanici_tel = kullaniciGüncelleTel.Text;
            kullanici.kullanici_ceza =Convert.ToDouble(kullaniciGüncelleCeza.Text);
            if (kullaniciGüncelleCinE.Checked==true)
            {
                kullanici.kullanici_cinsiyet = "E";
            }
            else if(kullaniciGüncelleCinK.Checked == true)
            {
                kullanici.kullanici_cinsiyet = "K";
            }
            db.SaveChanges();
            Listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
            kullaniciGüncelleAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            kullaniciGüncelleSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            kullaniciGüncelleTc.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            kullaniciGüncelleMail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            kullaniciGüncelleTel.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            kullaniciGüncelleCeza.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[7].Value.ToString().Equals("E"))
            {
                kullaniciGüncelleCinE.Checked = true;
            }
            else
            {
                kullaniciGüncelleCinK.Checked = true;
            }

        }
    }
}
