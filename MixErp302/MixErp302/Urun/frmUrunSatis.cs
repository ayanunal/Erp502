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

namespace MixErp302.Urun
{
    public partial class frmUrunSatis : Form
    {
        MixErpDbEntities db = new MixErpDbEntities();
        Numaralar N = new Numaralar();
        int UrnSatisId = -1;
        bool edit = false;
        
        public frmUrunSatis()
        {
            InitializeComponent();
        }

        public string[] MyArray { get; set; }
        private void frmUrunSatis_Load(object sender, EventArgs e)
        {
            txtSatisGrupNo.Text = N.SatisGrupNo();
            Combo();
            txtKarOrani.SelectedIndex = 0;
        }

        private void Combo()
        {
            
            txtCari.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtCari.AutoCompleteMode = AutoCompleteMode.Suggest;
            AutoCompleteStringCollection veri = new AutoCompleteStringCollection();
            var lst = db.tblCaris.Select(x => x.CariAdi).Distinct();

            foreach (var cari in lst)
            {
                veri.Add(cari);
                txtCari.Items.Add(cari);
            }
            txtCari.AutoCompleteCustomSource = veri;

            txtOdeme.DataSource = db.bOdemeTurleris.ToList();
            txtOdeme.ValueMember = "Id";
            txtOdeme.DisplayMember = "OdemeTipi";

            var srg = db.tblUrunlers.Select(x => x.UrunKodu);
            foreach (var k in srg)
            {
                txtUkod.Items.Add(k);
            }

            int dgv;
            dgv = txtUkod.Items.Count;
            MyArray = new string[dgv];
            for (int i = 0; i < dgv; i++)
            {
                MyArray[i] = txtUkod.Items[i].ToString();
            }
            
        }

        private void Liste_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox txt = e.Control as TextBox;
            if (Liste.CurrentCell.ColumnIndex == 0 && txt != null)
            {
                txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txt.AutoCompleteCustomSource.AddRange(MyArray);
            }
            else if (Liste.CurrentCell.ColumnIndex != 0 && txt != null)
            {
                txt.AutoCompleteMode = AutoCompleteMode.None;
            }
        }

        private void Liste_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string a = Liste.CurrentRow.Cells[0].Value.ToString();
                var lst = (from s in db.tblUrunlers where s.UrunKodu == a select s).First();

                
                Liste.CurrentRow.Cells[1].Value = lst.UrunAciklama;
                Liste.CurrentRow.Cells[2].Value = lst.blgBirim.BirimAdi;
                Liste.CurrentRow.Cells[3].Value = db.tblStokDurums.First(x=>x.UrunId==lst.Id).OBFiyat;
                Liste.CurrentRow.Cells[8].Value = db.tblStokDurums.First(x=>x.UrunId==lst.Id).Raf;

                decimal bfyt = Convert.ToDecimal(Liste.CurrentRow.Cells[3].Value);
                int korn = Convert.ToInt32(txtKarOrani.Text);

                Liste.CurrentRow.Cells[4].Value = bfyt+(bfyt*korn)/100;

            }
            if (e.ColumnIndex == 5)
            {
                if (Liste.CurrentRow.Cells[4].Value != null)
                {
                    Rhesapla();
                }
                
            }

            if (e.ColumnIndex == 4)
            {
                if (Liste.CurrentRow.Cells[5].Value != null)
                {
                    Rhesapla();
                }

            }
        }

        private void Rhesapla()
        {
            decimal a, b;
            decimal atop = 0;
            decimal ktop = 0;
            decimal gtop = 0;

            if (Liste.CurrentRow.Cells[3].Value != null && Liste.CurrentRow.Cells[4].Value != null)
            {

                a = Convert.ToDecimal(Liste.CurrentRow.Cells[4].Value.ToString());
                b = Convert.ToDecimal(Liste.CurrentRow.Cells[5].Value.ToString());
                Liste.CurrentRow.Cells[6].Value = a * b * 0.18M;//cell[3]*cell[4] 


                for (int i = 0; i < Liste.RowCount; i++)
                {

                    atop += (Convert.ToDecimal(Liste.Rows[i].Cells[4].Value) * Convert.ToDecimal(Liste.Rows[i].Cells[5].Value));
                    ktop += Convert.ToDecimal(Liste.Rows[i].Cells[6].Value);

                }
                gtop = atop + ktop;
                txtAraToplam.Text = atop.ToString();
                txtKdvToplam.Text = ktop.ToString();
                txtGenelToplam.Text = gtop.ToString();
            }
            else
            {
                MessageBox.Show("Adam gibi değer gir.");
                Liste.CurrentRow.Cells[6].Value = "";
            }
        }
        bool KayitKont=false;
        void YeniKaydet()
        {
            for (int i = 0; i < Liste.RowCount; i++)
            {
                if (Convert.ToInt32(Liste.CurrentRow.Cells[5].Value) > Convert.ToInt32(Liste.CurrentRow.Cells[8].Value))
                {
                    MessageBox.Show("Yeterli ürün adedi yoktur.Stok adedini kontrol ediniz.");
                    KayitKont = true;
                    Liste.CurrentRow.Cells[5].Style.BackColor = Color.Red;
                    Liste.CurrentRow.Cells[5].Style.ForeColor = Color.White;
                }
                else
                {
                    Liste.CurrentRow.Cells[5].Style.BackColor = Color.Empty;
                    Liste.CurrentRow.Cells[5].Style.ForeColor = DefaultForeColor;
                }
            }
            if (KayitKont)
            {
                KayitKont = false;
                return;
            }
            var srch = new tblUrunSatisUst();
            srch.SatisGrupNo = txtSatisGrupNo.Text;
            srch.AraToplam = Convert.ToDecimal(txtAraToplam.Text);
            srch.STarih = Convert.ToDateTime(txtSTarih.Text);
            srch.CariId = db.tblCaris.First(x => x.CariAdi == txtCari.Text).Id;
            srch.Vade = Convert.ToInt32(txtVade.Text);
            srch.OdemeId = db.bOdemeTurleris.First(x => x.OdemeTipi == txtOdeme.Text).Id;
            srch.KdvToplam = Convert.ToDecimal(txtKdvToplam.Text);
            srch.GenelToplam = Convert.ToDecimal(txtGenelToplam.Text);
            srch.Durum = false;

            db.tblUrunSatisUsts.Add(srch);
            db.SaveChanges();
            Liste.AllowUserToAddRows = false;



            tblUrunSatisAlt[] unsalt = new tblUrunSatisAlt[Liste.RowCount];
            for (int i = 0; i < Liste.RowCount; i++)
            {
                unsalt[i] = new tblUrunSatisAlt();
                unsalt[i].Miktar = Convert.ToInt32(Liste.Rows[i].Cells[5].Value.ToString());
                unsalt[i].SatisGrupNo = txtSatisGrupNo.Text;
                unsalt[i].BFiyat = Convert.ToDecimal(Liste.Rows[i].Cells[3].Value.ToString());
                unsalt[i].SFiyat = Convert.ToDecimal(Liste.Rows[i].Cells[4].Value.ToString());
                string brm = Liste.Rows[i].Cells[2].Value.ToString();
                unsalt[i].BirimId = db.blgBirims.First(x => x.BirimAdi == brm).Id;
                string urn = Liste.Rows[i].Cells[1].Value.ToString();
                unsalt[i].UrunId = db.tblUrunlers.First(x => x.UrunAciklama == urn).Id;
                unsalt[i].AToplam = Convert.ToDecimal(Liste.Rows[i].Cells[4].Value) * Convert.ToDecimal(Liste.Rows[i].Cells[5].Value);
                unsalt[i].Kdv = Convert.ToDecimal(Liste.Rows[i].Cells[6].Value);

                db.tblUrunSatisAlts.Add(unsalt[i]);

                string uBarkod = Liste.Rows[i].Cells[0].Value.ToString() + "/" + Liste.Rows[i].Cells[1].Value.ToString();
                var sKontrol = db.tblStokDurums.First(x => x.Barkod == uBarkod);
                sKontrol.Ambar += 0;
                sKontrol.Depo -= Convert.ToInt32(Liste.Rows[i].Cells[5].Value);
                sKontrol.Raf -= Convert.ToInt32(Liste.Rows[i].Cells[5].Value);
            }
            db.SaveChanges();


            MessageBox.Show("Kayıt Başarılı.");
        }

        void Guncelle()
        {
            var srch = db.tblUrunSatisUsts.First(x => x.SatisGrupNo == txtSatisGrupNo.Text);
            srch.SatisGrupNo = txtSatisGrupNo.Text;
            srch.AraToplam = Convert.ToDecimal(txtAraToplam.Text);
            srch.STarih = Convert.ToDateTime(txtSTarih.Text);
            srch.CariId = db.tblCaris.First(x => x.CariAdi == txtCari.Text).Id;
            srch.Vade = Convert.ToInt32(txtVade.Text);
            srch.OdemeId = db.bOdemeTurleris.First(x => x.OdemeTipi == txtOdeme.Text).Id;
            srch.KdvToplam = Convert.ToDecimal(txtKdvToplam.Text);
            srch.GenelToplam = Convert.ToDecimal(txtGenelToplam.Text);
            srch.Durum = false;

            db.SaveChanges();
            Liste.AllowUserToAddRows = false;


            tblUrunSatisAlt[] unsalt = new tblUrunSatisAlt[Liste.RowCount];
            for (int i = 0; i < Liste.RowCount; i++)
            {
                var altId = Convert.ToInt32(Liste.Rows[i].Cells[7].Value);
                unsalt[i] = db.tblUrunSatisAlts.First(x => x.SatisGrupNo == txtSatisGrupNo.Text && x.Id == altId);
                unsalt[i].Miktar = Convert.ToInt32(Liste.Rows[i].Cells[5].Value.ToString());
                unsalt[i].SatisGrupNo = txtSatisGrupNo.Text;
                unsalt[i].BFiyat = Convert.ToDecimal(Liste.Rows[i].Cells[3].Value.ToString());
                unsalt[i].SFiyat = Convert.ToDecimal(Liste.Rows[i].Cells[4].Value.ToString());
                string brm = Liste.Rows[i].Cells[2].Value.ToString();
                unsalt[i].BirimId = db.blgBirims.First(x => x.BirimAdi == brm).Id;
                string urn = Liste.Rows[i].Cells[1].Value.ToString();
                unsalt[i].UrunId = db.tblUrunlers.First(x => x.UrunAciklama == urn).Id;
                unsalt[i].AToplam = Convert.ToDecimal(Liste.Rows[i].Cells[4].Value) * Convert.ToDecimal(Liste.Rows[i].Cells[5].Value);
                unsalt[i].Kdv = Convert.ToDecimal(Liste.Rows[i].Cells[6].Value);

            }
            db.SaveChanges();
            MessageBox.Show("Başarıyla Güncellendi.");
        }

        protected override void OnLoad(EventArgs e)
        {
            var btnUrsatno = new Button();
            btnUrsatno.Size = new Size(25, txtSatisGrupNo.ClientSize.Height + 2);
            btnUrsatno.Location = new Point(txtSatisGrupNo.ClientSize.Width - btnUrsatno.Width, -1);
            btnUrsatno.Cursor = Cursors.Default;
            btnUrsatno.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            txtSatisGrupNo.Controls.Add(btnUrsatno);
            base.OnLoad(e);

            btnUrsatno.Click += BtnUrsatno_Click;
            
            
        }
        Formlar F = new Formlar();
        private void BtnUrsatno_Click(object sender, EventArgs e)
        {
            int id = F.UrunSatisNo(true);
            if (id > 0)
            {
                Ac(id);
            }
            frmAnaSayfa.AktarmaInt = -1;
        }

        private void Ac(int id)
        {
            edit = true;
            UrnSatisId = id;
            string ustNo = id.ToString().PadLeft(7, '0');
            tblUrunSatisUst ust = db.tblUrunSatisUsts.First(x => x.SatisGrupNo == ustNo);
            txtSatisGrupNo.Text = ust.SatisGrupNo;
            txtAraToplam.Text = ust.AraToplam.ToString();
            txtSTarih.Text = ust.STarih.ToString();
            txtCari.Text = ust.tblCari.CariAdi;
            txtGenelToplam.Text = ust.GenelToplam.ToString();
            txtKdvToplam.Text = ust.KdvToplam.ToString();
            txtOdeme.Text = ust.bOdemeTurleri.OdemeTipi;
            txtVade.Text = ust.Vade.ToString();

            Liste.Rows.Clear();

            int i = 0;
            var alt = (from s in db.tblUrunSatisAlts where s.SatisGrupNo == ustNo select s).ToList();
            foreach (var k in alt)
            {

                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.tblUrunler.UrunKodu;
                Liste.Rows[i].Cells[1].Value = k.tblUrunler.UrunAciklama;
                Liste.Rows[i].Cells[2].Value = k.blgBirim.BirimAdi;
                Liste.Rows[i].Cells[3].Value = k.BFiyat;
                Liste.Rows[i].Cells[4].Value = k.SFiyat;
                Liste.Rows[i].Cells[5].Value = k.Miktar;
                Liste.Rows[i].Cells[6].Value = k.Kdv;
                Liste.Rows[i].Cells[7].Value = k.Id;
                i++;

            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            YeniKaydet();
        }

        private void txtKarOrani_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Liste.RowCount>1)
            {
                Liste.AllowUserToAddRows = false;

                decimal a, b;
                decimal atop = 0;
                decimal ktop = 0;
                decimal gtop = 0;
                for (int i = 0; i < Liste.RowCount; i++)
                {
                    decimal bfyt = Convert.ToDecimal(Liste.Rows[i].Cells[3].Value);
                    int korn = Convert.ToInt32(txtKarOrani.Text);

                    Liste.Rows[i].Cells[4].Value = bfyt + (bfyt * korn) / 100;
                    
                    a = Convert.ToDecimal(Liste.Rows[i].Cells[4].Value.ToString());
                    b = Convert.ToDecimal(Liste.Rows[i].Cells[5].Value.ToString());
                    Liste.CurrentRow.Cells[6].Value = a * b * 0.18M;
                    
                    atop += (Convert.ToDecimal(Liste.Rows[i].Cells[4].Value) * Convert.ToDecimal(Liste.Rows[i].Cells[5].Value));
                    ktop += Convert.ToDecimal(Liste.Rows[i].Cells[6].Value);
                    
                    gtop = atop + ktop;
                    txtAraToplam.Text = atop.ToString();
                    txtKdvToplam.Text = ktop.ToString();
                    txtGenelToplam.Text = gtop.ToString();
                    
                        
                }
                Liste.AllowUserToAddRows = true;
            }
        }
    }
}
