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
    public partial class DokumanSilForm : Form
    {
        public DokumanSilForm()
        {
            InitializeComponent();
        }

        KutuphaneOtomasyonuEntities db = new KutuphaneOtomasyonuEntities();
        public void ListeleDokuman()
        {
            var dokumanlar = db.Dokumanlar.ToList();
            dataGridView1.DataSource = dokumanlar;
        }

        private void dokumanSilBtn_Click(object sender, EventArgs e)
        {
            int secilenID = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var dokuman = db.Dokumanlar.Where(_dokuman => _dokuman.dokuman_id == secilenID).FirstOrDefault();

            if(dokuman != null)
            {
                db.Dokumanlar.Remove(dokuman);
                db.SaveChanges();
                ListeleDokuman();
            }
            else
            {
                MessageBox.Show("kullanıcı seçilirken hata oluştu");
            }

        }
        private void DokumanSilForm_Load(object sender, EventArgs e)
        {
            ListeleDokuman();
        }
    }
}
