using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UcakBiletiAlma.model;

namespace UcakBiletiAlma
{
    public partial class frmTcGiris : Form
    {
        UcakBiletiEntities db = new UcakBiletiEntities();
        
        public frmTcGiris()
        {
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            //int a = (from s in db.tblRezerves where s.TcNo>0 select s);
            //var src=(from s in tblRezerve where s.TcNo select s.TcNo)
            var src = (from s in db.tblRezerves where s.TcNo == txtTcGir.Text select s.TcNo).FirstOrDefault();
            if (txtTcGir.TextLength!=11 )
            {
                MessageBox.Show("Lütfen Tc'nizi doğru giriniz.");
                Temizle();
            }
            else  if(txtTcGir.Text!=src)
            {
                MessageBox.Show("Hatalı giriş.Bilgilerinizi kontrol ediniz.");
                Temizle();

            }
            else {
                MessageBox.Show("Yükleniyor..");
                frmRezerve yeni = new frmRezerve();
                yeni.tcgelen = txtTcGir.Text;
                yeni.Show();
                this.Hide();
            }
                
        }

        private void Temizle()
        {
            txtTcGir.Text = "";
        }

        private void frmTcGiris_Load(object sender, EventArgs e)
        {

        }

        private void btnAna_Click(object sender, EventArgs e)
        {
            frmAnasayfa yeni = new frmAnasayfa();
            yeni.Show();
            this.Hide();
        }
    }
}
