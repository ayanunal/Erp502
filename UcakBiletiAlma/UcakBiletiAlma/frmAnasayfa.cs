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
    public partial class frmAnasayfa : Form
    {
        public static int AktarmaI = -1;
        public frmAnasayfa()
        {
            InitializeComponent();
        }


        private void frmAnasayfa_Load(object sender, EventArgs e)
        {

        }


        private void btnBilet_Click(object sender, EventArgs e)
        {
            frmMusteri yeni = new frmMusteri();
            yeni.Show();
            this.Hide();
        }

        private void btnAdmin_Click_1(object sender, EventArgs e)
        {
            frmAdminGiris yeni = new frmAdminGiris();
            yeni.Show();
            this.Hide();
        }


        private void btnRez_Click(object sender, EventArgs e)
        {
            frmTcGiris yeni = new frmTcGiris();
            yeni.Show();
            this.Hide();
        }
    }
}
