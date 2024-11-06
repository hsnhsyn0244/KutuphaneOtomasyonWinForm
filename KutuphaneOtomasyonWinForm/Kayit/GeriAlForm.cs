using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonWinForm.Kayit
{
    public partial class GeriAlForm : Form
    {
        public GeriAlForm()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonuEntities db = new KutuphaneOtomasyonuEntities();

        public void Listele()
        {
            var kayitlar = db.Kayitlar.Where(_kayitlar => _kayitlar.durum == false).ToList();
            dataGridView1.DataSource = kayitlar;
        }

        private void GeriAlForm_Load(object sender, EventArgs e)
        {
            Listele();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kitapTeslimBtn_Click(object sender, EventArgs e)
        {
            int secilenKayit = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var kayit = db.Kayitlar.Where(_kayit => _kayit.kayit_id == secilenKayit).FirstOrDefault();
            kayit.durum = true; 
            db.SaveChanges();
            Listele();
            MessageBox.Show("Kitap Teslim Alımı başarıyla gerçekleşti");
        }
    }
}
