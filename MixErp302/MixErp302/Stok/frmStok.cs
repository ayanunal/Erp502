using MixErp302.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MixErp302.Stok
{
    public partial class frmStok : Form
    {
        MixErpDbEntities db = new MixErpDbEntities();
        int secimId = -1;
        public bool Secim = false;
        public frmStok()
        {
            InitializeComponent();
        }

        private void frmStokDurumListe_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            //var urunKod=db.tblStokDurums.First(x=>x.)
            Liste.Rows.Clear();
            int i = 0;
            var srg = (from s in db.tblStokDurums where s.tblUrunler.UrunKodu.Contains(txtBul.Text) select s).ToList();
            foreach (var k in srg)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = k.StokKodu;
                Liste.Rows[i].Cells[2].Value = k.tblUrunler.UrunKodu;
                Liste.Rows[i].Cells[3].Value = k.tblUrunler.UrunAciklama;
                Liste.Rows[i].Cells[4].Value = k.Depo;
                Liste.Rows[i].Cells[5].Value = k.Raf;
                Liste.Rows[i].Cells[6].Value = k.Ambar;
                Liste.Rows[i].Cells[7].Value = k.Barkod;
                i++;
            }
            Liste.AllowUserToAddRows = false;
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim = true && secimId > 0)
            {
                frmAnaSayfa.AktarmaInt = secimId;
                Close();
            }
        }

        private void Sec()
        {
            try
            {
                secimId = Convert.ToInt32(Liste.CurrentRow.Cells[0].Value);
            }
            catch (Exception)
            {

                secimId = -1;
            }
        }
    }
}
