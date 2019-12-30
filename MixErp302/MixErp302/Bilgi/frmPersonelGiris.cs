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
    public partial class frmPersonelGiris : Form
    {
        MixErpDbEntities db = new MixErpDbEntities();
        Numaralar N = new Numaralar();
        int secimId = -1;
        bool edit = false;

        public frmPersonelGiris()
        {
            InitializeComponent();
        }

        private void frmPersonelGiris_Load(object sender, EventArgs e)
        {
            Combo();
            Listele();
            txtPersonelNo.Text = N.PersonelNo();
        }
        void Temizle()
        {
            foreach (Control con in split2.Panel1.Controls)
            {
                if (con is TextBox || con is ComboBox || con is DateTimePicker)
                {
                    con.Text = "";
                }
                secimId = -1;
                edit = false;
                txtPersonelNo.Text = N.PersonelNo();
                txtDepartman.SelectedIndex = 0;

            }
            
        }
        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var srg = (from s in db.tblPersonels select s).ToList();  //personel tablosunda kayıt varsa srg nin içine atıyor.
            foreach (var k in srg)
            {
                Liste.Rows.Add(); //her dönüşte satır oluşturur.
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = k.PersonelNo;
                Liste.Rows[i].Cells[2].Value = k.Adi;
                Liste.Rows[i].Cells[3].Value = k.Tel;
                Liste.Rows[i].Cells[4].Value = k.tblDepartman.DepartmanAdi;
                i++;
            }
            Liste.AllowUserToAddRows = false; //Sonuna boş satır eklememesi için.
        }

        private void Combo()
        {
            txtDepartman.DataSource = db.tblDepartmen.ToList();
            txtDepartman.ValueMember = "Id";
            txtDepartman.DisplayMember = "DepartmanAdi";
            //txtDepartman.SelectedIndex = -1; //-1. index te bir şey olmadığı için boş geliyor.
            txtDepartman.SelectedIndex = 0;
        }
        private void YeniKaydet()
        {
            tblPersonel pers = new tblPersonel();
            pers.Adi = txtAd.Text;
            pers.Adres = txtAdres.Text;
            pers.DepartmanId = db.tblDepartmen.First(x => x.DepartmanAdi == txtDepartman.Text).Id;// First tek bir kayıt döndürmesini sağlıyor. x'i biz tanımlıyoruz(a,b,c  denebilir.)
            pers.DogumTarih = DateTime.Parse(txtDogumTarih.Text);  //Parse da null değeri girilirse inception hatası verir. Convert ise '0' değerini atar. 
            //pers.DogumTarihi = Convert.ToDateTime (txtDogumTarih.Text); Üst satırın yerine kullanılabilir.
            pers.Email = txtEmail.Text;
            pers.IsBasTarih = DateTime.Parse(txtİsBasTarih.Text);
            pers.IsSonTarih = DateTime.Parse(txtİsSonTarih.Text);
            pers.PersonelNo = txtPersonelNo.Text;
            pers.TcNo = txtTc.Text;
            pers.Tel = txtTel.Text;

            db.tblPersonels.Add(pers);
            db.SaveChanges();
            MessageBox.Show("Kayıt Başarılı.");
            Listele();
            Temizle();

        }
        void Guncelle()
        {
            tblPersonel pers = db.tblPersonels.Find(secimId);
            pers.Adi = txtAd.Text;
            pers.Adres = txtAdres.Text;
            pers.DepartmanId = db.tblDepartmen.First(x => x.DepartmanAdi == txtDepartman.Text).Id;// First tek bir kayıt döndürmesini sağlıyor. x'i biz tanımlıyoruz(a,b,c  denebilir.)
            pers.DogumTarih = DateTime.Parse(txtDogumTarih.Text);  //Parse da null değeri girilirse inception hatası verir. Convert ise '0' değerini atar. 
            //pers.DogumTarihi = Convert.ToDateTime (txtDogumTarih.Text); Üst satırın yerine kullanılabilir.
            pers.Email = txtEmail.Text;
            pers.IsBasTarih = DateTime.Parse(txtİsBasTarih.Text);
            pers.IsSonTarih = DateTime.Parse(txtİsSonTarih.Text);
            pers.PersonelNo = txtPersonelNo.Text;
            pers.TcNo = txtTc.Text;
            pers.Tel = txtTel.Text;


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
            edit = true;//güncelleme işlemi yapabilmek için
            tblPersonel pers = db.tblPersonels.Find(secimId);
            txtAd.Text = pers.Adi;     //tersten yaptık güncelleme işlemi için bunlar.
            txtAdres.Text = pers.Adres;
            txtDepartman.Text = pers.tblDepartman.DepartmanAdi;//foreign key
            txtDogumTarih.Text = pers.DogumTarih.ToString();
            txtİsBasTarih.Text = pers.IsBasTarih.ToString();
            txtİsSonTarih.Text = pers.IsSonTarih.ToString();
            txtPersonelNo.Text = pers.PersonelNo;
            txtTc.Text = pers.TcNo;
            txtTel.Text = pers.Tel;
            txtEmail.Text = pers.Email;
        }

        private void Sec()//güncellleme için
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

            db.tblPersonels.Remove(db.tblPersonels.Find(secimId));
            db.SaveChanges();
            MessageBox.Show($"{secimId}'nolu kayıt silinmiştir.");
            Listele();
            Temizle();

        }


    }
}