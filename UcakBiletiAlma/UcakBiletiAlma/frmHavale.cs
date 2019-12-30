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
    public partial class frmHavale : Form
    {
        UcakBiletiEntities db = new UcakBiletiEntities();
        public int IdBul = -1;
        public frmHavale()
        {
            InitializeComponent();
        }

        private void btnHavale_Click(object sender, EventArgs e)
        {
            if (txtKartNo.Text.Length!=20 || txtGecerlilik.Text.Length!=4 || txtCvc.Text.Length!=3)
            {
                MessageBox.Show("Lütfen Kart Bilgilerinizi Doğru Giriniz.");
                Temizle();
            }
            else
            {
                MessageBox.Show("Ödemeniz alınmıştır.WAIR AIRLINES iyi yolculuklar diler.");
                IdBul = (from s in db.tblOnays orderby s.OnayId descending select s).First().OnayId;
                var onay = db.tblOnays.Find(IdBul);
                db.tblOnays.Remove(onay);
                db.SaveChanges();
                frmAnasayfa yeni = new frmAnasayfa();
                yeni.Show();
                this.Hide();
            }
        }

        private void Temizle()
        {
            txtKartNo.Text = "";
            txtGecerlilik.Text = "";
            txtCvc.Text = "";
        }

        private void frmHavale_Load(object sender, EventArgs e)
        {

        }
    }
}
