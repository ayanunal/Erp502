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

namespace MixErp302.User
{
    public partial class frmKulGiris : Form
    {
        MixErpDbEntities db = new MixErpDbEntities();
        int secimId = -1;
        bool edit = false;

        public frmKulGiris()
        {
            InitializeComponent();
        }

        private void frmKulGiris_Load(object sender, EventArgs e)
        {
            Listele();
            txtRole.SelectedIndex = 0;
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

                txtRole.SelectedIndex = 0;
                

            }

        }
        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var lst = (from s in db.tblUsers where s.KulAdi.Contains(txtBul.Text) ||s.Sifre.Contains(txtBul.Text) select s).ToList();
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.Id;
                Liste.Rows[i].Cells[1].Value = k.KulAdi;
                Liste.Rows[i].Cells[2].Value = k.Sifre;
                Liste.Rows[i].Cells[3].Value = k.Role;
                i++;
            }
            Liste.AllowUserToAddRows = false;
        }

        private void YeniKaydet()
        {
            tblUser use = new tblUser();
            use.KulAdi = txtKulAdi.Text;
            use.Sifre = txtSifre.Text;
            use.Role = txtRole.SelectedIndex;

            db.tblUsers.Add(use);
            db.SaveChanges();
            MessageBox.Show("Kayıt Başarılı.");
            Listele();
            Temizle();
        }
        void Guncelle()
        {
            tblUser use = db.tblUsers.Find(secimId);
            use.KulAdi = txtKulAdi.Text;
            use.Sifre = txtSifre.Text;
            use.Role = txtRole.SelectedIndex;
            


            db.SaveChanges();
            MessageBox.Show("Güncelleme Başarılı.");
            Listele();
            Temizle();
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
            var srg = db.tblUsers.Find(secimId);
            txtKulAdi.Text = srg.KulAdi;
            txtSifre.Text = srg.Sifre;
            for (int i = 0; i < txtRole.Items.Count; i++)
            {
                if (srg.Role == i)
                {
                    txtRole.SelectedIndex = i;
                }
            }
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
            if (txtKulAdi.Text!="" && secimId!=-1)
            {
                db.tblUsers.Remove(db.tblUsers.Find(secimId));
                db.SaveChanges();
                MessageBox.Show($"{secimId}'nolu kayıt silinmiştir."); 
            }
            else
            {
                MessageBox.Show("İlk olarak Liste den kayıt seçin.");
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (edit && secimId > 0) Guncelle();
            else if (edit == false) YeniKaydet();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
