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
    public partial class frmUrun : Form
    {
        MixErpDbEntities db = new MixErpDbEntities();
        int secimId = -1;
        bool edit = false;
        Numaralar N = new Numaralar();

        public frmUrun()
        {
            InitializeComponent();
        }

        private void frmUrun_Load(object sender, EventArgs e)
        {
            Combo();
            Listele();
        }
        void Temizle()
        {
            foreach (Control con in splitY.Panel1.Controls)
            {
                if (con is TextBox || con is ComboBox)
                {
                    con.Text = "";
                }
                secimId = -1;
                edit = false;
                txtKategoriId.SelectedIndex = 0;
                

            }
        }
        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var srg = (from s in db.tblUrunlers where s.UrunKodu.Contains(txtBul.Text) || s.UrunAciklama.Contains(txtBul.Text) || s.blgKategori.KategoriAdi.Contains(txtBul.Text) || s.tblCari.CariAdi.Contains(txtBul.Text) select s).ToList();
            foreach (var k in srg)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = k.UrunKodu;
                Liste.Rows[i].Cells[2].Value = k.UrunAciklama;
                Liste.Rows[i].Cells[3].Value = k.tblCari.CariAdi;
                Liste.Rows[i].Cells[4].Value = k.blgKategori.KategoriAdi;
                i++;
            }
            Liste.AllowUserToAddRows = false;
        }

        private void Combo()
        {
            txtKategoriId.DataSource = db.blgKategoris.ToList();
            txtKategoriId.ValueMember = "Id";
            txtKategoriId.DisplayMember = "KategoriAdi";
            txtKategoriId.SelectedIndex = 0;

            txtMenseiId.DataSource = db.bMenseis.ToList();
            txtMenseiId.ValueMember = "Id";
            txtMenseiId.DisplayMember = "MenseiAdi";
            txtMenseiId.SelectedIndex = 0;

            txtBirimId.DataSource = db.blgBirims.ToList();
            txtBirimId.ValueMember = "Id";
            txtBirimId.DisplayMember = "BirimAdi";
            txtBirimId.SelectedIndex = 0;
            
            txtCariId.DataSource = db.tblCaris.ToList();
            txtCariId.ValueMember = "Id";
            txtCariId.DisplayMember = "CariAdi";
            txtCariId.SelectedIndex = 0;
        }
       
        private void YeniKaydet()
        {
            var uKontrol = db.tblUrunlers.Where(x => x.UrunKodu.ToLower() == txtUrunKodu.Text.ToLower()).ToList();
            if (uKontrol.Count()==0)
            {
                tblUrunler urn = new tblUrunler();
                urn.UrunKodu = txtUrunKodu.Text;
                urn.UrunAciklama = txtUrunAciklama.Text;
                urn.MenseiId = db.bMenseis.First(x => x.MenseiAdi == txtMenseiId.Text).Id;
                urn.KategoriId = db.blgKategoris.First(x => x.KategoriAdi == txtKategoriId.Text).Id;
                urn.BirimId = db.blgBirims.First(x => x.BirimAdi == txtBirimId.Text).Id;
                urn.CariId = db.tblCaris.First(x => x.CariAdi == txtCariId.Text).Id;

                db.tblUrunlers.Add(urn);
                db.SaveChanges();

                tblStokDurum stk = new tblStokDurum();
                stk.Ambar = 0;
                stk.Barkod = txtUrunKodu.Text + "/" + txtUrunAciklama.Text;
                stk.Depo = 0;
                stk.Raf = 0;
                stk.StokKodu = N.StokKodu();
                stk.UrunId = db.tblUrunlers.First(x => x.UrunKodu == txtUrunKodu.Text).Id;
                db.tblStokDurums.Add(stk);
                db.SaveChanges();
                Listele();
                Temizle();

                MessageBox.Show("Kayıt Başarılı.");
                 
            }
            else
            {
                MessageBox.Show("Bu ürün daha önce kaydedilmiş. Lütfen kontrol ediniz!!!");
                txtUrunKodu.Text = "";
                
            }
           
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (edit && secimId > 0) Guncelle();
            else if (edit == false) YeniKaydet();
        }

        private void Guncelle()
        {
            tblUrunler urn = db.tblUrunlers.Find(secimId);
            urn.UrunKodu = txtUrunKodu.Text;
            urn.UrunAciklama = txtUrunAciklama.Text;
            urn.MenseiId = db.bMenseis.First(x => x.MenseiAdi == txtMenseiId.Text).Id;
            urn.KategoriId = db.blgKategoris.First(x => x.KategoriAdi == txtKategoriId.Text).Id;
            urn.BirimId = db.blgBirims.First(x => x.BirimAdi == txtBirimId.Text).Id;
            urn.CariId = db.tblCaris.First(x => x.CariAdi == txtCariId.Text).Id;


            db.SaveChanges();
            MessageBox.Show("Güncelleme Başarılı.");
            Listele();
            Temizle();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
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
            tblUrunler urn = db.tblUrunlers.Find(secimId);
            txtBirimId.Text = urn.blgBirim.BirimAdi;
            txtCariId.Text = urn.tblCari.CariAdi;
            txtKategoriId.Text = urn.blgKategori.KategoriAdi;
            txtMenseiId.Text = urn.bMensei.MenseiAdi;
            txtUrunAciklama.Text = urn.UrunAciklama;
            txtUrunKodu.Text = urn.UrunKodu;
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

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (edit && secimId > 0)
            {
                Sil();
            }
        }

        private void Sil()
        {
            db.tblUrunlers.Remove(db.tblUrunlers.Find(secimId));
            db.SaveChanges();
            MessageBox.Show($"{secimId}'nolu kayıt silinmiştir.");
            Listele();
            Temizle();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            Listele();
        }

        
    }
}
