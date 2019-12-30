using MixErp302.Data;
using MixErp302.Fonksiyonlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MixErp302.Bilgi
{
    public partial class frmCariGiris : Form
    {
        MixErpDbEntities db = new MixErpDbEntities();
        Numaralar N = new Numaralar();
        int secimId = -1;
        bool edit = false;
        

        public frmCariGiris()
        {
            InitializeComponent();
        }

        private void frmCariGiris_Load(object sender, EventArgs e)
        {
            Combo();
            Listele();
            txtCariNo.Text = N.CariNo();
        }

        void Temizle()
        {
            foreach (Control con in splitY.Panel1.Controls)
            {
                if (con is TextBox || con is ComboBox || con is DateTimePicker)
                {
                    con.Text = "";
                }
                secimId = -1;
                edit = false;
               
                txtCariTipId.SelectedIndex = 0;
                txtCariNo.Text = N.CariNo();

            }

        }
        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var srg = (from s in db.tblCaris select s).ToList();  
            foreach (var k in srg)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = k.CariNo;
                Liste.Rows[i].Cells[2].Value = k.CariAdi;
                Liste.Rows[i].Cells[3].Value = k.VergiNoTcNo;
                Liste.Rows[i].Cells[4].Value = k.VergiD;
                i++;
            }
            Liste.AllowUserToAddRows = false; 

        }

        private void Combo()
        {
            txtCariTipId.DataSource = db.blgCariTipis.ToList();
            txtCariTipId.ValueMember = "Id";
            txtCariTipId.DisplayMember = "CariTipi";
            txtCariTipId.SelectedIndex = -1;

            txtSehirId.Text = "";
            txtSehirId.Items.Clear();

            var srg = (from s in db.illers
                       select s).ToList();
            foreach (var k in srg)
            {
                txtSehirId.Items.Add(k.isim);
            }

        }

        private void YeniKaydet()
        {
            tblCari car = new tblCari();
            car.CariAdi = txtCariAdi.Text;
            car.Adres = txtAdres.Text;
            car.CariNo = txtCariNo.Text;
            car.Tel = txtTel.Text;
            car.VergiD = txtVergiD.Text;
            car.VergiNoTcNo = txtVergiNoTc.Text;
            car.SehirId= db.illers.First(x => x.isim == txtSehirId.Text).il_no;
            car.IlceId= db.ilcelers.First(x => x.isim == txtIlceId.Text).ilce_no;
            car.CariTipId = db.blgCariTipis.First(x => x.CariTipi == txtCariTipId.Text).Id;

            db.tblCaris.Add(car);
            db.SaveChanges();
            MessageBox.Show("Kayıt Başarılı.");
            Listele();
            Temizle();

        }
       
        void Guncelle()
        {
            tblCari car = db.tblCaris.Find(secimId);
            car.CariAdi = txtCariAdi.Text;
            car.Adres = txtAdres.Text;
            car.SehirId = db.illers.First(x => x.isim == txtSehirId.Text).il_no;
            car.CariNo = txtCariNo.Text;
            car.CariTipId =db.blgCariTipis.First(x=>x.CariTipi==txtCariTipId.Text).Id;
            car.VergiNoTcNo = txtVergiNoTc.Text;
            car.VergiD = txtVergiD.Text;
            car.Tel = txtTel.Text;
            car.IlceId = db.ilcelers.First(x => x.isim == txtIlceId.Text).ilce_no;


            db.SaveChanges();
            MessageBox.Show("Güncelleme Başarılı.");
            Listele();
            Temizle();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (edit && secimId > 0) Guncelle();
            else if (edit == false) YeniKaydet();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (secimId > 0)
            {
                Ac(secimId);
            }
        }

        private void Ac(int secimId)
        {
            edit = true;
            tblCari car = db.tblCaris.Find(secimId);
            txtCariAdi.Text = car.CariAdi;     
            txtAdres.Text = car.Adres;
            txtSehirId.Text = car.iller.isim;
            txtIlceId.Text = car.ilceler.isim;
            txtVergiD.Text = car.VergiD;
            txtCariNo.Text = car.CariNo;
            txtTel.Text = car.Tel;
            txtVergiNoTc.Text = car.VergiNoTcNo;
            txtCariTipId.Text = car.blgCariTipi.CariTipi;
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
        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (edit && secimId > 0)
            {
                Sil();
            }
        }
        private void Sil()
        {

            db.tblCaris.Remove(db.tblCaris.Find(secimId));
            db.SaveChanges();
            MessageBox.Show($"{secimId}'nolu kayıt silinmiştir.");
            Listele();
            Temizle();

        }

        private void txtSehirId_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIlceId.Text = "";
            txtIlceId.Items.Clear();
            int a = db.illers.First(x => x.isim == txtSehirId.Text).il_no;
            var srg = (from s in db.ilcelers where s.il_no == a select s).ToList();
            var lst = (from s in db.ilcelers where s.il_no == a select s).ToList();
            foreach (var k in srg)
            {
                txtIlceId.Items.Add(k.isim);
            }
        }

       
    }
}
