using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcakBiletiAlma
{
    public partial class frmAdminGiris : Form
    {
        public frmAdminGiris()
        {
            InitializeComponent();
        }

        private void frmAdminGiris_Load(object sender, EventArgs e)
        {

        }


        private void txtKullaniciAd_TextChanged(object sender, EventArgs e)
        {
            txtKullaniciAd.CharacterCasing = CharacterCasing.Upper;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            frmAdmin yeni = new frmAdmin();
            if (txtKullaniciAd.Text == "ADMIN" && txtSifre.Text == "123")
            {
                MessageBox.Show("Giriş Başarılı.");
                yeni.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş Başarısız'");
                txtKullaniciAd.Clear();
                txtSifre.Clear();
            }
        }

        private void btnAna_Click(object sender, EventArgs e)
        {
            frmAnasayfa yeni = new frmAnasayfa();
            yeni.Show();
            this.Hide();
        }
    }
}
