﻿using KutuphaneOtomasyonWinForm.Kullanıcı;
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

        private void kullaniciGüncelleBtn_Click(object sender, EventArgs e)
        {
            KullaniciGüncelle güncelleForm = new KullaniciGüncelle();
            güncelleForm.MdiParent = this;
            güncelleForm.Show();
        }

        private void kullaniciSilBtn_Click(object sender, EventArgs e)
        {
            KullaniciSilForm kullaniciSil = new KullaniciSilForm();
            kullaniciSil.MdiParent = this;
            kullaniciSil.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
