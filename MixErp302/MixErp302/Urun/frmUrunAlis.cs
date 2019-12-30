using MixErp302.Data;
using MixErp302.Fonksiyonlar;
using MixErp302.Print;
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
    public partial class frmUrunAlis : Form
    {
        //2.işlem global alana db bağlantımızı ve gerekli olacak property ve field larımızı ekleriz.
        MixErpDbEntities db = new MixErpDbEntities();
        //3.işlem numaralar sınıfında gerekli sınıfı oluştur.
        Numaralar N = new Numaralar();
        //int secimId = -1;
        int UrnAlisId = -1;
        bool edit = false;
        //9. işlem 

        public string[] MyArray{get; set;}

        public frmUrunAlis()
        {
            InitializeComponent();
        }

        private void frmUrunAlis_Load(object sender, EventArgs e)
        {
            //1.işlem Load event i oluşturulur.

            //4.işlem numaralar sınıfında oluşturdun metodu burada ilgili textbox için çalıştır.
            txtAlisGrupNo.Text = N.AlisGrupNo();
            //5.işlem ==> Combobox lar için Combo adında method yaz ve bunu generate et.
            ComboBox();

        }

        private void ComboBox()
        {
            //6.işlem cari adları için autocomplete özelliğini açtığımız bir combobox doldurma yöntemi.
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
            //7.işlem Ödeme tipi için combobox doldur.

            txtOdeme.DataSource = db.bOdemeTurleris.ToList();
            txtOdeme.ValueMember = "Id";
            txtOdeme.DisplayMember = "OdemeTipi";

            //8.işlem 
            var srg = db.tblUrunlers.Select(x => x.UrunKodu);
            foreach (var k in srg)
            {
                txtUkod.Items.Add(k);
            }
            //10.işlem 
            int dgv;
            dgv = txtUkod.Items.Count;
            MyArray=new string [dgv];
            for (int i = 0; i < dgv; i++)
            {
                MyArray[i] = txtUkod.Items[i].ToString();
            }
        }
        //11.işlem datagridview şimşek
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
        //12. işlem
        private void Liste_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==0)
            {
                string a = Liste.CurrentRow.Cells[0].Value.ToString();
                var lst = (from s in db.tblUrunlers where s.UrunKodu == a select s).First();
                Liste.CurrentRow.Cells[1].Value = lst.UrunAciklama;
                Liste.CurrentRow.Cells[2].Value = lst.blgBirim.BirimAdi;
                
            }
            if(e.ColumnIndex==4)
            {
                if (Liste.CurrentRow.Cells[3].Value != null)
                {
                    Rhesapla();
                }
                
            }
            if (e.ColumnIndex == 3)
            {
                if (Liste.CurrentRow.Cells[4].Value != null)
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
                
                a = Convert.ToDecimal(Liste.CurrentRow.Cells[3].Value.ToString());
                b = Convert.ToDecimal(Liste.CurrentRow.Cells[4].Value.ToString());
                Liste.CurrentRow.Cells[5].Value = a * b * 0.18M;//cell[3]*cell[4] 

               
                for (int i = 0; i < Liste.RowCount; i++)
                {
                    
                    atop += (Convert.ToDecimal(Liste.Rows[i].Cells[3].Value) * Convert.ToDecimal(Liste.Rows[i].Cells[4].Value));
                    ktop += Convert.ToDecimal(Liste.Rows[i].Cells[5].Value);

                }
                gtop = atop + ktop;
                txtAraToplam.Text = atop.ToString();
                txtKdvToplam.Text = ktop.ToString();
                txtGenelToplam.Text = gtop.ToString();
            }
            else
            {
                MessageBox.Show("Adam gibi değer gir.");
                Liste.CurrentRow.Cells[5].Value = "";
            }
            
        }

        void YeniKaydet()
        {

            var srch = new tblUrunAlisUst();
            srch.AlisGrupNo = txtAlisGrupNo.Text;
            srch.AraToplam = Convert.ToDecimal(txtAraToplam.Text);
            srch.ATarih = Convert.ToDateTime(txtATarih.Text);
            srch.FaturaNo = txtFaturaNo.Text;
            srch.CariId = db.tblCaris.First(x => x.CariAdi == txtCari.Text).Id;
            srch.C_Vade= Convert.ToInt32(txtVade.Text);
            srch.OdemeId = db.bOdemeTurleris.First(x => x.OdemeTipi == txtOdeme.Text).Id;
            srch.KdvToplam = Convert.ToDecimal(txtKdvToplam.Text);
            srch.GenelToplam = Convert.ToDecimal(txtGenelToplam.Text);

            db.tblUrunAlisUsts.Add(srch);
            db.SaveChanges();
            Liste.AllowUserToAddRows = false;


            
            tblUrunAlisAlt[] unalt = new tblUrunAlisAlt[Liste.RowCount];
            for (int i=0;i<Liste.RowCount;i++)
            {
                unalt[i] = new tblUrunAlisAlt();
                unalt[i].Miktar = Convert.ToInt32(Liste.Rows[i].Cells[4].Value.ToString());
                unalt[i].AlisGrupNo = txtAlisGrupNo.Text;
                unalt[i].BFiyat= Convert.ToDecimal(Liste.Rows[i].Cells[3].Value.ToString());
                string brm = Liste.Rows[i].Cells[2].Value.ToString();
                unalt[i].BirimId = db.blgBirims.First(x => x.BirimAdi == brm).Id;
                string urn = Liste.Rows[i].Cells[1].Value.ToString();
                unalt[i].UrunId= db.tblUrunlers.First(x => x.UrunAciklama == urn).Id;
                unalt[i].AToplam = Convert.ToDecimal(Liste.Rows[i].Cells[3].Value)* Convert.ToDecimal(Liste.Rows[i].Cells[4].Value);
                unalt[i].Kdv = Convert.ToDecimal(Liste.Rows[i].Cells[5].Value);

                db.tblUrunAlisAlts.Add(unalt[i]);

                string uBarkod = Liste.Rows[i].Cells[0].Value.ToString()+"/"+ Liste.Rows[i].Cells[1].Value.ToString();
                var sKontrol = db.tblStokDurums.First(x => x.Barkod == uBarkod);
                

                decimal obFiyat;
                decimal ETopObFiyat;
                decimal YTopObFiyat;
                if (sKontrol.OBFiyat == null)
                {
                    obFiyat = 0;
                    ETopObFiyat = 0;
                   
                }
                else
                {
                    obFiyat = sKontrol.OBFiyat.Value;
                    ETopObFiyat=obFiyat* sKontrol.Depo.Value;
                }
                YTopObFiyat = Convert.ToDecimal(Liste.Rows[i].Cells[3].Value) * Convert.ToInt32(Liste.Rows[i].Cells[4].Value);

                decimal TopEYfiyat = ETopObFiyat + YTopObFiyat;
                int EAdet = sKontrol.Depo.Value;
                int YAdet= Convert.ToInt32(Liste.Rows[i].Cells[4].Value);
                int TopEYadet = EAdet + YAdet;
                decimal SonucBFiyat = TopEYfiyat / TopEYadet;
                sKontrol.Ambar += 0;
                sKontrol.Depo += Convert.ToInt32(Liste.Rows[i].Cells[4].Value);
                sKontrol.Raf += Convert.ToInt32(Liste.Rows[i].Cells[4].Value);
                sKontrol.OBFiyat = SonucBFiyat;
            }
            db.SaveChanges();

            
            MessageBox.Show("Kayıt Başarılı.");
        }
        void Guncelle()
        {
            var srch = db.tblUrunAlisUsts.First(x => x.AlisGrupNo == txtAlisGrupNo.Text);
            srch.AlisGrupNo = txtAlisGrupNo.Text;
            srch.AraToplam = Convert.ToDecimal(txtAraToplam.Text);
            srch.ATarih = Convert.ToDateTime(txtATarih.Text);
            srch.FaturaNo = txtFaturaNo.Text;
            srch.CariId = db.tblCaris.First(x => x.CariAdi == txtCari.Text).Id;
            srch.C_Vade = Convert.ToInt32(txtVade.Text);
            srch.OdemeId = db.bOdemeTurleris.First(x => x.OdemeTipi == txtOdeme.Text).Id;
            srch.KdvToplam = Convert.ToDecimal(txtKdvToplam.Text);
            srch.GenelToplam = Convert.ToDecimal(txtGenelToplam.Text);

            db.SaveChanges();
            Liste.AllowUserToAddRows = false;


            tblUrunAlisAlt[] unalt = new tblUrunAlisAlt[Liste.RowCount];
            for (int i = 0; i < Liste.RowCount; i++)
            {
                var altId = Convert.ToInt32(Liste.Rows[i].Cells[6].Value);
                unalt[i] = db.tblUrunAlisAlts.First(x => x.AlisGrupNo == txtAlisGrupNo.Text && x.Id==altId);
                unalt[i].Miktar = Convert.ToInt32(Liste.Rows[i].Cells[4].Value.ToString());
                unalt[i].AlisGrupNo = txtAlisGrupNo.Text;
                unalt[i].BFiyat = Convert.ToDecimal(Liste.Rows[i].Cells[3].Value.ToString());
                string brm = Liste.Rows[i].Cells[2].Value.ToString();
                unalt[i].BirimId = db.blgBirims.First(x => x.BirimAdi == brm).Id;
                string urn = Liste.Rows[i].Cells[1].Value.ToString();
                unalt[i].UrunId = db.tblUrunlers.First(x => x.UrunAciklama == urn).Id;
                unalt[i].AToplam = Convert.ToDecimal(Liste.Rows[i].Cells[3].Value) * Convert.ToDecimal(Liste.Rows[i].Cells[4].Value);
                unalt[i].Kdv = Convert.ToDecimal(Liste.Rows[i].Cells[5].Value);
                
            }
            db.SaveChanges();
            MessageBox.Show("Başağrıyla Güncellendi.");
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (edit  && UrnAlisId > 0) Guncelle();else if (!edit) YeniKaydet();
        }

        protected override void OnLoad(EventArgs e)
        {
            //Buraya öyle bir kod yazacamki değiştirmek istediğim kodun üzerine yazılarak onu manipule etmiş olacağım.
            var btnUralno = new Button();
            btnUralno.Size = new Size(25, txtAlisGrupNo.ClientSize.Height + 2);
            btnUralno.Location = new Point(txtAlisGrupNo.ClientSize.Width - btnUralno.Width, -1);
            btnUralno.Cursor = Cursors.Default;
            //btnUralno.Image = Properties.Resources.Arrow;   --Resources oluştuktan sonra 
            btnUralno.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            txtAlisGrupNo.Controls.Add(btnUralno);
            

            base.OnLoad(e);

            btnUralno.Click += btnUralno_Click;

        }
        Formlar F = new Formlar();
        private void btnUralno_Click(object sender, EventArgs e)
        {
            int id = F.UrunAlisNo(true);
            if (id > 0)
            {
                Ac(id);
            }
            frmAnaSayfa.AktarmaInt = -1;
        }

        private void Ac(int id)
        {

            edit = true;
            UrnAlisId = id;
            string ustNo = id.ToString().PadLeft(7, '0');
            tblUrunAlisUst ust = db.tblUrunAlisUsts.First(x => x.AlisGrupNo ==ustNo);
            txtAlisGrupNo.Text = ust.AlisGrupNo;
            txtAraToplam.Text = ust.AraToplam.ToString();
            txtATarih.Text = ust.ATarih.ToString();
            txtCari.Text = ust.tblCari.CariAdi;
            txtFaturaNo.Text = ust.FaturaNo;
            txtGenelToplam.Text = ust.GenelToplam.ToString();
            txtKdvToplam.Text = ust.KdvToplam.ToString();
            txtOdeme.Text = ust.bOdemeTurleri.OdemeTipi;
            txtVade.Text = ust.C_Vade.ToString();

            Liste.Rows.Clear();
            //Liste.AllowUserToAddRows = false;
            int i= 0;
            var alt = (from s in db.tblUrunAlisAlts where s.AlisGrupNo == ustNo select s).ToList();
            foreach(var k in alt)
            {
                
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.tblUrunler.UrunKodu;
                Liste.Rows[i].Cells[1].Value = k.tblUrunler.UrunAciklama;
                Liste.Rows[i].Cells[2].Value = k.blgBirim.BirimAdi;
                Liste.Rows[i].Cells[3].Value = k.BFiyat;
                Liste.Rows[i].Cells[4].Value = k.Miktar;
                Liste.Rows[i].Cells[5].Value = k.Kdv;
                Liste.Rows[i].Cells[6].Value = k.Id;
                i++;
                
            }
            //Liste.AllowUserToAddRows = false;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Yaz();
        }

        private void Yaz()
        {
            frmPrint pr = new frmPrint();
            pr.GrupNo = txtAlisGrupNo.Text;
            pr.HangiListe = "UrunAlis";
            pr.Show();
        }
    }
}
