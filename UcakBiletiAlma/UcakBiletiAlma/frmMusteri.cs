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
    public partial class frmMusteri : Form
    {
        UcakBiletiEntities db = new UcakBiletiEntities();
        int idBul = -1;
        
        public frmMusteri()
        {
            InitializeComponent();
        }

        private void frmMusteri_Load(object sender, EventArgs e)
        {
            Combo();
        }

        private void Combo()
        {

            txtSinif.Items.Clear();
            var srg = (from s in db.tblSinifs select s).ToList();
            foreach (var k in srg)
            {
                txtSinif.Items.Add(k.Sinif);
            }

            txtNereden.DataSource = db.tblHavalimanis.ToList();
            txtNereden.ValueMember = "il_no";
            txtNereden.DisplayMember = "havalimaniAdi";
            txtNereden.SelectedIndex = -1;

            txtNereye.DataSource = db.tblHavalimanis.ToList();
            txtNereye.ValueMember = "il_no";
            txtNereye.DisplayMember = "havalimaniAdi";
            txtNereye.SelectedIndex = -1;
        }

        private void txtSinif_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUcret.Text = "";
            int a = -1;
            a = db.tblSinifs.First(x => x.Sinif == txtSinif.Text).Id;
            var k = "";
            k = db.tblUcrets.First(y => y.SinifId == a).Ucret;
            txtUcret.Text = k;
        }

        private void txtNereye_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtNereden.Text!="" && txtNereye.Text!="")
            {
                if (txtNereden.Text == txtNereye.Text)
                {
                    MessageBox.Show("Kalkış-Varış noktası aynı olamaz.");
                } 
            }
        }

        private void txtNereden_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtNereden.Text != "" && txtNereye.Text != "")
            {
                if (txtNereden.Text == txtNereye.Text)
                {
                    MessageBox.Show("Kalkış-Varış noktası aynı olamaz.");
                }
            }
        }

        private void txtKoltukNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime k = Convert.ToDateTime(txtGidisTarih.Text);
            var srg = (from s in db.tblOnays where (s.Nereden == txtNereden.Text && s.Nereye == txtNereye.Text && s.GidisTarihi == k && s.TcNo==txtTc.Text) select s).ToList();
            if (srg != null)
            {
                foreach (var z in srg)
                {
                    if(z.KoltukNo == txtKoltukNo.Text)
                    {
                        MessageBox.Show(txtKoltukNo.Text + " nolu koltuk doludur.");
                        txtKoltukNo.Text = "";
                    }
                }
            }

            DateTime m = Convert.ToDateTime(txtGidisTarih.Text);
            var brg = (from s in db.tblRezerves where (s.Nereden == txtNereden.Text && s.Nereye == txtNereye.Text && s.GidisTarihi == m && s.TcNo == txtTc.Text) select s).ToList();
            if (brg != null)
            {
                foreach (var z in brg)
                {
                    if (z.KoltukNo == txtKoltukNo.Text)
                    {
                        MessageBox.Show(txtKoltukNo.Text + " nolu koltuk doludur.");
                        txtKoltukNo.Text = "";
                    }
                }
            }
        }

        private void btnAl_Click(object sender, EventArgs e)
        {
            Onayla();
        }

        private void Onayla()
        {
            tblOnay ony = new tblOnay();
            ony.Nereden = txtNereden.Text;
            ony.Nereye = txtNereye.Text;
            ony.SinifId = db.tblSinifs.First(x => x.Sinif == txtSinif.Text).Id;
            ony.KoltukNo = txtKoltukNo.Text;
            ony.GidisTarihi = Convert.ToDateTime(txtGidisTarih.Text);
            ony.SaatId = Convert.ToInt32(txtSaat.Text);
            ony.MusAdiSoyadi = txtAd.Text;
            ony.Tel = txtTel.Text;
            ony.Cinsiyet = txtCinsiyet.Text;
            ony.TcNo = txtTc.Text;
            ony.Email = txtEmail.Text;
            ony.DogumTarih = Convert.ToDateTime(txtDTarih.Text);
            ony.UcretId = Convert.ToInt32(txtUcret.Text);

            string kimlikno = txtTc.Text;
            kimlikno = kimlikno.Trim();
            if (kimlikno.Length != 11) { MessageBox.Show("TC numaranızı doğru giriniz"); txtTc.Text = "";}
            else
            {
                db.tblOnays.Add(ony);
                db.SaveChanges();
                MessageBox.Show("Biletiniz Alınmıştır.Ödeme Sayfasına yönlendirileceksiniz.Lütfen Bekleyin..");
                Temizle();
                idBul = (from s in db.tblOnays orderby s.OnayId descending select s).First().OnayId;
                frmOdeme yeni = new frmOdeme();
                if (idBul > 0) { yeni.IdAl = idBul; }
                yeni.Show();
                this.Hide();
            }
        }

        private void Temizle()
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is ComboBox || item is TextBox || item is DateTimePicker)
                {
                    item.Text = "";
                }
            }
        }

        private void btnRezerve_Click(object sender, EventArgs e)
        {
            Rezerve();
        }

        private void Rezerve()
        {
            tblRezerve rez = new tblRezerve();
            rez.Nereden = txtNereden.Text;
            rez.Nereye = txtNereye.Text;
            rez.SinifId = db.tblSinifs.First(x => x.Sinif == txtSinif.Text).Id;
            rez.KoltukNo = txtKoltukNo.Text;
            rez.GidisTarihi = Convert.ToDateTime(txtGidisTarih.Text);
            rez.SaatId = Convert.ToInt32(txtSaat.Text);
            rez.MusAdiSoyadi = txtAd.Text;
            rez.Tel = txtTel.Text;
            rez.Cinsiyet = txtCinsiyet.Text;
            rez.TcNo = txtTc.Text;
            rez.Email = txtEmail.Text;
            rez.DogumTarih = Convert.ToDateTime(txtDTarih.Text);
            rez.UcretId = Convert.ToInt32(txtUcret.Text);

            string kimlikno = txtTc.Text;
            kimlikno = kimlikno.Trim();
            if (kimlikno.Length != 11) { MessageBox.Show("TC numaranızı doğru giriniz"); txtTc.Text = ""; }
            else
            {
                db.tblRezerves.Add(rez);
                db.SaveChanges();
                MessageBox.Show("Biletiniz Rezerve edilmiştir.Ana sayfaya yönlendirileceksiniz.Lütfen Bekleyin..");
                Temizle();
                frmAnasayfa yeni = new frmAnasayfa();
                yeni.Show();
                this.Hide();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            frmAnasayfa yeni = new frmAnasayfa();
            yeni.Show();
            this.Hide();
        }


    }
}
