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
    public partial class frmRezerve : Form
    {
        UcakBiletiEntities db = new UcakBiletiEntities();
        int secimId=-1;
        public int IdAl = -1;
        public string tcgelen = "";

        public frmRezerve()
        {
            InitializeComponent();
        }

        private void frmRezerve_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var srg = (from s in db.tblRezerves
                       where s.TcNo==tcgelen
                       select s).ToList();    
            foreach (var k in srg)
            {
                Liste.Rows.Add(); 
                Liste.Rows[i].Cells[0].Value = k.RezerveId;  
                Liste.Rows[i].Cells[1].Value = k.TcNo;  
                Liste.Rows[i].Cells[2].Value = k.Nereden;  
                Liste.Rows[i].Cells[3].Value = k.Nereye;
                Liste.Rows[i].Cells[4].Value = k.GidisTarihi;
                Liste.Rows[i].Cells[5].Value = k.SaatId;
                Liste.Rows[i].Cells[6].Value = k.MusAdiSoyadi;
                Liste.Rows[i].Cells[7].Value = k.Tel;
                Liste.Rows[i].Cells[8].Value = k.UcretId;
                Liste.Rows[i].Cells[9].Value = k.KoltukNo;
                i++;
            }
            Liste.AllowUserToAddRows = false;
        }

        private void Sec()
        {
            try
            {
                secimId = Convert.ToInt32(Liste.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception)
            {

                secimId = -1;
            }
        }

      
        private void Ekle(int secimId)
        {
            tblOnay ony = new tblOnay();
            var rezerv = db.tblRezerves.Find(secimId);

            ony.TcNo = rezerv.TcNo;
            ony.Cinsiyet = rezerv.Cinsiyet;
            ony.DogumTarih = rezerv.DogumTarih;
            ony.Email = rezerv.Email;
            ony.GidisTarihi = rezerv.GidisTarihi;
            ony.KoltukNo = rezerv.KoltukNo;
            ony.MusAdiSoyadi = rezerv.MusAdiSoyadi;
            ony.Nereden = rezerv.Nereden;
            ony.Nereye = rezerv.Nereye;
            ony.SaatId = rezerv.SaatId;
            ony.SinifId = rezerv.SinifId;
            ony.Tel = rezerv.Tel;
            ony.UcretId = rezerv.UcretId;
            db.tblOnays.Add(ony);
            db.SaveChanges();
            frmAnasayfa.AktarmaI= int.Parse(db.tblOnays
                            .OrderByDescending(p => p.OnayId)
                            .Select(r => r.OnayId)
                            .First().ToString());

            db.tblRezerves.Remove(rezerv);
            db.SaveChanges();
            MessageBox.Show("Biletiniz Onaylanmıştır.");
            Listele();
            Temizle();
            MessageBox.Show("Biletiniz Alınmıştır.Ödeme Sayfasına yönlendirileceksiniz.Lütfen Bekleyin..");
            frmOdeme yeni = new frmOdeme();
            yeni.Show();
            this.Hide();
        }
        private void Temizle()
        {
            Liste.Rows.Clear();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            if (secimId > 0)
            {
                Sil();
            }
        }

        private void Sil()
        {
            db.tblRezerves.Remove(db.tblRezerves.Find(secimId));
            db.SaveChanges();
            MessageBox.Show("Biletiniz silinmiştir.Ana sayfaya yönlendirileceksiniz.");
            Listele();
            Temizle();
            frmAnasayfa yeni = new frmAnasayfa();
            yeni.Show();
            this.Hide();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            frmAnasayfa yeni = new frmAnasayfa();
            yeni.Show();
            this.Hide();
        }

        private void btnkaydett_Click(object sender, EventArgs e)
        {
            if (secimId > 0)
            {
                Ekle(secimId);
            }
        }
    }
}
