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
    public partial class DokumanGuncelleForm : Form
    {
        public DokumanGuncelleForm()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonuEntities db = new KutuphaneOtomasyonuEntities();
        public void DokumanListele()
        {
            var dokumanlar = db.Dokumanlar.ToList();
            dataGridView1.DataSource = dokumanlar;
        }

        private void DokumanGuncelleForm_Load(object sender, EventArgs e)
        {
            DokumanListele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dokumanGüncelleAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dokumanGüncelleTur.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dokumanGüncelleSayfaSayısı.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dokumanGüncelleYayinEvi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dokumanGüncelleBasimTarihi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            dokumanGüncelleYazarAdi.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();


        }

        private void dokumanGüncelletBtn_Click(object sender, EventArgs e)
        {
            int secilenID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var dokuman = db.Dokumanlar.Where(_dokumanlar => _dokumanlar.dokuman_id == secilenID).FirstOrDefault();
            Dokumanlar dokumanlar = new Dokumanlar();
            dokumanlar.dokuman_ad = dokumanGüncelleAd.Text;
            dokumanlar.dokuman_sayfaSayisi = Convert.ToInt16(dokumanGüncelleSayfaSayısı.Value);
            dokumanlar.dokuman_yayinci = dokumanGüncelleYayinEvi.Text;
            dokumanlar.dokuman_basimTarihi = dokumanGüncelleBasimTarihi.Value;
            dokumanlar.dokuman_yazar = dokumanGüncelleYazarAdi.Text;
            // combobox içindeki veriyi seçimini bu şekilde yapıyoruz.
            dokumanlar.dokuman_turu = dokumanGüncelleTur.GetItemText(dokumanGüncelleTur.SelectedItem);
            db.Dokumanlar.Add(dokumanlar);
            db.SaveChanges();
            DokumanListele();
        }
    }
}
