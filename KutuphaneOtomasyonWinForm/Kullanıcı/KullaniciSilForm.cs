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
    public partial class KullaniciSilForm : Form
    {
        public KullaniciSilForm()
        {
            InitializeComponent();    
        }
        KutuphaneOtomasyonuEntities db = new KutuphaneOtomasyonuEntities();
        public void Listele()
        {
           
            var kullanicilar = db.Kullanicilar.ToList();
            dataGridView1.DataSource = kullanicilar.ToList();
        }
        private void KullaniciSilForm_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void kullaiciSilBtn_Click(object sender, EventArgs e)
        {
            int secilenId = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var kullanici = db.Kullanicilar.Where(_kullanici => _kullanici.kullanici_id == secilenId).FirstOrDefault();

            if (kullanici != null) { 
                db.Kullanicilar.Remove(kullanici);
                db.SaveChanges();
                Listele();
            }
            else
            {
                MessageBox.Show("kullanıcı seçilirken hata oluştu");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
