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
    public partial class KullaniciListForm : Form
    {
        public KullaniciListForm()
        {
            InitializeComponent();
        }
        public void Listele ()
        {
            KutuphaneOtomasyonuEntities db = new KutuphaneOtomasyonuEntities();
            var kullanicilar = db.Kullanicilar.ToList();
            dataGridView1.DataSource = kullanicilar;
        }
        private void KullaniciListForm_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
