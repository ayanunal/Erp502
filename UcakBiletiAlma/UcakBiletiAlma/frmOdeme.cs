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
    public partial class frmOdeme : Form
    {
        UcakBiletiEntities db = new UcakBiletiEntities();
        public int IdAl = -1;
        public frmOdeme()
        {
            InitializeComponent();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            IdAl = (from s in db.tblOnays orderby s.OnayId descending select s).First().OnayId;
            var onay = db.tblOnays.Find(IdAl);
            db.tblOnays.Remove(onay);
            db.SaveChanges();
            frmAnasayfa yeni = new frmAnasayfa();
            yeni.Show();
            this.Hide();
        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            if (txtNakit.Checked && txtKredi.Checked ==false && txtHavale.Checked==false)
            {
                IdAl = (from s in db.tblOnays orderby s.OnayId descending select s).First().OnayId;
                var onay = db.tblOnays.Find(IdAl);
                db.tblOnays.Remove(onay);
                db.SaveChanges();
                MessageBox.Show("Nakit ödeme işleminiz gerçekleştirilmiştir.WAIR AIRLINES iyi yolculuklar diler.");
                frmAnasayfa yeni = new frmAnasayfa();
                yeni.Show();
                this.Hide();
            }
            else if (txtKredi.Checked && txtNakit.Checked==false && txtHavale.Checked==false)
            {
                frmKredi yeni = new frmKredi();
                yeni.Show();
                this.Hide();
            }
            else if(txtHavale.Checked && txtNakit.Checked==false && txtKredi.Checked==false)
            {
                frmHavale yeni = new frmHavale();
                yeni.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Lütfen tek seçim yapınız.");
                Temizle();
            }
        }

        private void Temizle()
        {
            txtNakit.Checked = false;
            txtKredi.Checked = false;
            txtHavale.Checked = false;
        }

        private void frmOdeme_Load(object sender, EventArgs e)
        {
            Getir();
        }

        private void Getir()
        {
            if (IdAl > 0)
            {
                var onay = db.tblOnays.Find(IdAl);
                txtAdSoyad.Text = onay.MusAdiSoyadi;
                txtTc.Text = onay.TcNo;
                txtCinsiyet.Text = onay.Cinsiyet;
                txtNereden.Text = onay.Nereden;
                txtNereye.Text = onay.Nereye;
                txtSaat.Text = Convert.ToString(onay.SaatId);
                txtSinif.Text = Convert.ToString(onay.SinifId);
                txtUcret.Text = Convert.ToString(onay.UcretId);
            }
            else
            {
                var onay = db.tblOnays.Find(frmAnasayfa.AktarmaI);
                txtAdSoyad.Text = onay.MusAdiSoyadi;
                txtTc.Text = onay.TcNo;
                txtCinsiyet.Text = onay.Cinsiyet;
                txtNereden.Text = onay.Nereden;
                txtNereye.Text = onay.Nereye;
                txtSaat.Text = Convert.ToString(onay.SaatId);
                txtSinif.Text = Convert.ToString(onay.SinifId);
                txtUcret.Text = Convert.ToString(onay.UcretId);
            }
            
        }
    }
}
