﻿using MixErp302.Data;
using MixErp302.Fonksiyonlar;
using MixErp302.Urun;
using MixErp302.Yaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MixErp302.Print
{
    public partial class frmPrint : Form
    {
        MixErpDbEntities db = new MixErpDbEntities();
        public string HangiListe;
        public string GrupNo;
        public frmPrint()
        {
            InitializeComponent();
        }

        private void frmPrint_Load(object sender, EventArgs e)
        {
            switch (HangiListe)
            {
                case "UrunAlis":
                    UrunAlis();
                    break;    
                default:
                    break;
            }
        }

        private void UrunAlis()
        {
            frmUrunAlis alis = Application.OpenForms["frmUrunAlis"] as frmUrunAlis;
            UrunAlisReport cr = new UrunAlisReport();

            var result = (from s in db.vwUrunAlisAltUsts where s.AlisGrupNo == GrupNo select s).ToList();

            PrintYardim ch = new PrintYardim();
            DataTable dt = ch.ConvertTo(result);
            cr.SetDataSource(dt);
            crvPrint.ReportSource = cr;
        }
    }
}
