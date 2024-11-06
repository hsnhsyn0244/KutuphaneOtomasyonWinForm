using KutuphaneOtomasyonWinForm.Dökümanlar;
using KutuphaneOtomasyonWinForm.Kayıt_İşlemi;
using KutuphaneOtomasyonWinForm.Kullanıcı;

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
    public partial class IslemPaneli : Form
    {
        public IslemPaneli()
        {
            InitializeComponent();
        }

        KutuphaneOtomasyonuEntities db = new KutuphaneOtomasyonuEntities(); 

        private void IslemPaneli_Load(object sender, EventArgs e)
        {
            kullaniciEkleBtn.Visible = false;
            kullaniciGüncelleBtn.Visible = false;
            kullaniciSilBtn.Visible = false;

            dokumanSilBtn.Visible = false;
            DokumanGuncelleBtn.Visible = false;
            dokumanEkleBtn.Visible = false; 
        }
        private void kullaniciListeleBtn_Click(object sender, EventArgs e)
        {
            if (kullaniciEkleBtn.Visible==false)
            {
                kullaniciEkleBtn.Visible = true;
                kullaniciGüncelleBtn.Visible = true;
                kullaniciSilBtn.Visible = true;
            }
            else
            {
                kullaniciEkleBtn.Visible = false;
                kullaniciGüncelleBtn.Visible = false;
                kullaniciSilBtn.Visible = false;
            }
            KullaniciListForm kullaniciListForm = new KullaniciListForm();
            kullaniciListForm.MdiParent = this;
            kullaniciListForm.Show();
        }
        private void kullaniciEkleBtn_Click(object sender, EventArgs e)
        {
            KullaniciEkleForm ekleForm = new KullaniciEkleForm();
            ekleForm.MdiParent = this;
            ekleForm.Show();
        }
        private void kullaniciSilBtn_Click(object sender, EventArgs e)
        {
            KullaniciSilForm kullaniciSil = new KullaniciSilForm();
            kullaniciSil.MdiParent = this;
            kullaniciSil.Show();
        }
        private void kullaniciGüncelleBtn_Click_1(object sender, EventArgs e)
        {
            KullaniciGüncelle güncelleForm = new KullaniciGüncelle();
            güncelleForm.MdiParent = this;
            güncelleForm.Show();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dokumanEkleBtn_Click_1(object sender, EventArgs e)
        {
            DokumanEkleForm dokumanEkle = new DokumanEkleForm();
            dokumanEkle.MdiParent = this;
            dokumanEkle.Show(); 
            
        }
        private void dokumanSilBtn_Click_1(object sender, EventArgs e)
        {
            DokumanSilForm dokumanSil = new DokumanSilForm();
            dokumanSil.MdiParent = this;
            dokumanSil.Show();
        }
        private void DokumanGuncelleBtn_Click_1(object sender, EventArgs e)
        {
            DokumanGuncelleForm dokumanGuncelle = new DokumanGuncelleForm();
            dokumanGuncelle.MdiParent = this;
            dokumanGuncelle.Show();

        }

        
        private void dokumanListBtn_Click_1(object sender, EventArgs e)
        {
            if (dokumanEkleBtn.Visible == false)
            {
                dokumanEkleBtn.Visible = true;
                DokumanGuncelleBtn.Visible = true;
                dokumanSilBtn.Visible = true;
            }
            else
            {
                dokumanEkleBtn.Visible = false;
                DokumanGuncelleBtn.Visible = false;
                dokumanSilBtn.Visible = false;
            }
          
            DokumanListForm dokumanListForm = new DokumanListForm();
            dokumanListForm.MdiParent = this;
            dokumanListForm.Show();
        }

        private void oduncVermeBtn_Click(object sender, EventArgs e)
        {
            OduncVerForm oduncVer = new OduncVerForm();
            oduncVer.MdiParent = this;
            oduncVer.Show();
        }

        private void geriAlBtn_Click(object sender, EventArgs e)
        {
            Kayit.GeriAlForm geriAl = new Kayit.GeriAlForm();
            geriAl.MdiParent = this;
            geriAl.Show();
        }
    }
}
