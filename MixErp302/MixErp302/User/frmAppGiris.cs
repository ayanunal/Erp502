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
    public partial class frmAppGiris : Form
    {
        MixErpDbEntities db = new MixErpDbEntities();
        public frmAppGiris()
        {
            InitializeComponent();
        }

        private void frmAppGiris_Load(object sender, EventArgs e)
        {

        }
        void GirisKontrol()
        {
            try  //Sistem çökmemesi için kullan. İkinci bir şans gibi.
            {
                int srg = (from s in db.tblUsers where s.KulAdi == txtKulAdi.Text && s.Sifre == txtSifre.Text select s).First().Id;
                if (srg > 0)
                {
                    frmAnaSayfa Fana = new frmAnaSayfa();
                    Fana.WindowState = FormWindowState.Maximized;
                    Fana.roleId = db.tblUsers.Find(srg).Role.Value;
                    Fana.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Eyy kullanıcı girmiş olduğun bilgiler hatalı. Bir daha bak gözüm.");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Eyy kullanıcı girmiş olduğun bilgiler hatalı. Bir daha bak gözüm.");
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            GirisKontrol();
            
        }
    }
}
