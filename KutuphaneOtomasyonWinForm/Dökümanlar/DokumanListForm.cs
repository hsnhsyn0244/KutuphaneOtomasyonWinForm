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
    public partial class DokumanListForm : Form
    {
        public DokumanListForm()
        {
            InitializeComponent();
        }
        public void ListeleDokuman()
        {
            KutuphaneOtomasyonuEntities db = new KutuphaneOtomasyonuEntities();
            var dokumanlar = db.Dokumanlar.ToList();
            dataGridView1.DataSource = dokumanlar;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DokumanListForm_Load(object sender, EventArgs e)
        {
            ListeleDokuman();
        }
    }
}
