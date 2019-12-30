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
    public partial class frmAdmin : Form
    {
        UcakBiletiEntities db = new UcakBiletiEntities();

        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            Listele();
            Listele1();
        }

        private void Listele()
        {
            ListeRezervasyon.Rows.Clear();
            int i = 0;
            var srg = (from s in db.tblRezerves
                       select s).ToList();    
            foreach (var k in srg)
            {
                ListeRezervasyon.Rows.Add(); 
                ListeRezervasyon.Rows[i].Cells[0].Value = k.MusAdiSoyadi; 
                ListeRezervasyon.Rows[i].Cells[1].Value = k.Nereden;  
                ListeRezervasyon.Rows[i].Cells[2].Value = k.Nereye;
                ListeRezervasyon.Rows[i].Cells[3].Value = k.tblSinif.Sinif;
                i++;
            }
            ListeRezervasyon.AllowUserToAddRows = false;
        }

        private void Listele1()
        {
            ListeOnay.Rows.Clear();
            int i = 0;
            var srg = (from s in db.tblOnays
                       select s).ToList();    
            foreach (var k in srg)
            {
                ListeOnay.Rows.Add(); 
                ListeOnay.Rows[i].Cells[0].Value = k.MusAdiSoyadi; 
                ListeOnay.Rows[i].Cells[1].Value = k.Nereden; 
                ListeOnay.Rows[i].Cells[2].Value = k.Nereye;
                ListeOnay.Rows[i].Cells[3].Value = k.tblSinif.Sinif;
                i++;
            }
            ListeOnay.AllowUserToAddRows = false;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            frmAnasayfa yeni = new frmAnasayfa();
            yeni.Show();
            this.Hide();
        }
    }
}
