namespace MixErp302.Urun
{
    partial class frmUrunSatis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUkod = new System.Windows.Forms.ComboBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.labl = new System.Windows.Forms.Label();
            this.txtKdvToplam = new System.Windows.Forms.TextBox();
            this.labbel = new System.Windows.Forms.Label();
            this.txtGenelToplam = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtAraToplam = new System.Windows.Forms.TextBox();
            this.pnlUst = new System.Windows.Forms.Panel();
            this.txtKarOrani = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSatisGrupNo = new System.Windows.Forms.TextBox();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.txtSTarih = new System.Windows.Forms.DateTimePicker();
            this.txtOdeme = new System.Windows.Forms.ComboBox();
            this.txtCari = new System.Windows.Forms.ComboBox();
            this.txtVade = new System.Windows.Forms.ComboBox();
            this.lbl9 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.splitY = new System.Windows.Forms.SplitContainer();
            this.splitX = new System.Windows.Forms.SplitContainer();
            this.UrunKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SatisFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AraKdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitY)).BeginInit();
            this.splitY.Panel1.SuspendLayout();
            this.splitY.Panel2.SuspendLayout();
            this.splitY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitX)).BeginInit();
            this.splitX.Panel1.SuspendLayout();
            this.splitX.Panel2.SuspendLayout();
            this.splitX.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.Red;
            this.btnKapat.Location = new System.Drawing.Point(24, 446);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(106, 33);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(24, 10);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(106, 33);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(0, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Satış Grup No";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUkod
            // 
            this.txtUkod.FormattingEnabled = true;
            this.txtUkod.Location = new System.Drawing.Point(10, 70);
            this.txtUkod.Name = "txtUkod";
            this.txtUkod.Size = new System.Drawing.Size(121, 21);
            this.txtUkod.TabIndex = 2;
            this.txtUkod.Visible = false;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Chartreuse;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSil.Location = new System.Drawing.Point(10, 12);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(106, 31);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            // 
            // labl
            // 
            this.labl.AutoSize = true;
            this.labl.BackColor = System.Drawing.Color.Green;
            this.labl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labl.Location = new System.Drawing.Point(540, 56);
            this.labl.Name = "labl";
            this.labl.Size = new System.Drawing.Size(67, 13);
            this.labl.TabIndex = 0;
            this.labl.Text = "Kdv Toplam:";
            this.labl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtKdvToplam
            // 
            this.txtKdvToplam.Location = new System.Drawing.Point(613, 49);
            this.txtKdvToplam.Name = "txtKdvToplam";
            this.txtKdvToplam.Size = new System.Drawing.Size(166, 20);
            this.txtKdvToplam.TabIndex = 1;
            // 
            // labbel
            // 
            this.labbel.AutoSize = true;
            this.labbel.BackColor = System.Drawing.Color.Green;
            this.labbel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labbel.Location = new System.Drawing.Point(531, 83);
            this.labbel.Name = "labbel";
            this.labbel.Size = new System.Drawing.Size(76, 13);
            this.labbel.TabIndex = 0;
            this.labbel.Text = "Genel Toplam:";
            this.labbel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGenelToplam
            // 
            this.txtGenelToplam.Location = new System.Drawing.Point(613, 80);
            this.txtGenelToplam.Name = "txtGenelToplam";
            this.txtGenelToplam.Size = new System.Drawing.Size(166, 20);
            this.txtGenelToplam.TabIndex = 1;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Green;
            this.lbl1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl1.Location = new System.Drawing.Point(543, 25);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(64, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Ara Toplam:";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAraToplam
            // 
            this.txtAraToplam.Location = new System.Drawing.Point(613, 18);
            this.txtAraToplam.Name = "txtAraToplam";
            this.txtAraToplam.Size = new System.Drawing.Size(166, 20);
            this.txtAraToplam.TabIndex = 1;
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.Color.Yellow;
            this.pnlUst.Controls.Add(this.txtUkod);
            this.pnlUst.Controls.Add(this.btnSil);
            this.pnlUst.Controls.Add(this.txtKarOrani);
            this.pnlUst.Controls.Add(this.labl);
            this.pnlUst.Controls.Add(this.txtKdvToplam);
            this.pnlUst.Controls.Add(this.label2);
            this.pnlUst.Controls.Add(this.labbel);
            this.pnlUst.Controls.Add(this.txtGenelToplam);
            this.pnlUst.Controls.Add(this.lbl1);
            this.pnlUst.Controls.Add(this.txtAraToplam);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUst.Location = new System.Drawing.Point(0, 264);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(814, 113);
            this.pnlUst.TabIndex = 0;
            // 
            // txtKarOrani
            // 
            this.txtKarOrani.FormattingEnabled = true;
            this.txtKarOrani.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35"});
            this.txtKarOrani.Location = new System.Drawing.Point(311, 38);
            this.txtKarOrani.Name = "txtKarOrani";
            this.txtKarOrani.Size = new System.Drawing.Size(121, 21);
            this.txtKarOrani.TabIndex = 2;
            this.txtKarOrani.SelectedIndexChanged += new System.EventHandler(this.txtKarOrani_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kar Oranı:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSatisGrupNo
            // 
            this.txtSatisGrupNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSatisGrupNo.Location = new System.Drawing.Point(0, 86);
            this.txtSatisGrupNo.Name = "txtSatisGrupNo";
            this.txtSatisGrupNo.Size = new System.Drawing.Size(149, 20);
            this.txtSatisGrupNo.TabIndex = 1;
            // 
            // Liste
            // 
            this.Liste.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UrunKodu,
            this.UrunAciklama,
            this.Birim,
            this.BFiyat,
            this.SatisFiyat,
            this.Adet,
            this.AraKdv,
            this.Id,
            this.SAdet});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Top;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(814, 270);
            this.Liste.TabIndex = 1;
            this.Liste.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Liste_CellEndEdit);
            this.Liste.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Liste_EditingControlShowing);
            // 
            // txtSTarih
            // 
            this.txtSTarih.Location = new System.Drawing.Point(88, 63);
            this.txtSTarih.Name = "txtSTarih";
            this.txtSTarih.Size = new System.Drawing.Size(228, 20);
            this.txtSTarih.TabIndex = 3;
            // 
            // txtOdeme
            // 
            this.txtOdeme.FormattingEnabled = true;
            this.txtOdeme.Location = new System.Drawing.Point(417, 60);
            this.txtOdeme.Name = "txtOdeme";
            this.txtOdeme.Size = new System.Drawing.Size(166, 21);
            this.txtOdeme.TabIndex = 2;
            // 
            // txtCari
            // 
            this.txtCari.FormattingEnabled = true;
            this.txtCari.Location = new System.Drawing.Point(88, 25);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(265, 21);
            this.txtCari.TabIndex = 2;
            // 
            // txtVade
            // 
            this.txtVade.FormattingEnabled = true;
            this.txtVade.Items.AddRange(new object[] {
            "Belirtilmemiş",
            "1",
            "3",
            "4",
            "5",
            "6",
            "9",
            "12"});
            this.txtVade.Location = new System.Drawing.Point(417, 22);
            this.txtVade.Name = "txtVade";
            this.txtVade.Size = new System.Drawing.Size(166, 21);
            this.txtVade.TabIndex = 2;
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Location = new System.Drawing.Point(342, 64);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(69, 13);
            this.lbl9.TabIndex = 0;
            this.lbl9.Text = "Ödeme Türü:";
            this.lbl9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Location = new System.Drawing.Point(31, 30);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(46, 13);
            this.lbl8.TabIndex = 0;
            this.lbl8.Text = "Cari Adı:";
            this.lbl8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(22, 63);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(62, 13);
            this.lbl7.TabIndex = 0;
            this.lbl7.Text = "Satış Tarihi:";
            this.lbl7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(376, 28);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(35, 13);
            this.lbl3.TabIndex = 0;
            this.lbl3.Text = "Vade:";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // splitY
            // 
            this.splitY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitY.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitY.Location = new System.Drawing.Point(0, 0);
            this.splitY.Name = "splitY";
            this.splitY.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitY.Panel1
            // 
            this.splitY.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.splitY.Panel1.Controls.Add(this.txtSTarih);
            this.splitY.Panel1.Controls.Add(this.txtOdeme);
            this.splitY.Panel1.Controls.Add(this.txtCari);
            this.splitY.Panel1.Controls.Add(this.txtVade);
            this.splitY.Panel1.Controls.Add(this.lbl9);
            this.splitY.Panel1.Controls.Add(this.lbl8);
            this.splitY.Panel1.Controls.Add(this.lbl7);
            this.splitY.Panel1.Controls.Add(this.lbl3);
            // 
            // splitY.Panel2
            // 
            this.splitY.Panel2.Controls.Add(this.Liste);
            this.splitY.Panel2.Controls.Add(this.pnlUst);
            this.splitY.Size = new System.Drawing.Size(818, 493);
            this.splitY.SplitterDistance = 108;
            this.splitY.TabIndex = 0;
            // 
            // splitX
            // 
            this.splitX.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitX.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitX.Location = new System.Drawing.Point(0, 0);
            this.splitX.Name = "splitX";
            // 
            // splitX.Panel1
            // 
            this.splitX.Panel1.Controls.Add(this.splitY);
            // 
            // splitX.Panel2
            // 
            this.splitX.Panel2.BackColor = System.Drawing.Color.Yellow;
            this.splitX.Panel2.Controls.Add(this.btnKapat);
            this.splitX.Panel2.Controls.Add(this.btnKaydet);
            this.splitX.Panel2.Controls.Add(this.txtSatisGrupNo);
            this.splitX.Panel2.Controls.Add(this.label1);
            this.splitX.Size = new System.Drawing.Size(973, 493);
            this.splitX.SplitterDistance = 818;
            this.splitX.TabIndex = 3;
            // 
            // UrunKodu
            // 
            this.UrunKodu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.UrunKodu.HeaderText = "Ürün Kodu";
            this.UrunKodu.Name = "UrunKodu";
            this.UrunKodu.Width = 83;
            // 
            // UrunAciklama
            // 
            this.UrunAciklama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UrunAciklama.HeaderText = "Ürün Açıklama";
            this.UrunAciklama.Name = "UrunAciklama";
            // 
            // Birim
            // 
            this.Birim.HeaderText = "Birim";
            this.Birim.Name = "Birim";
            // 
            // BFiyat
            // 
            dataGridViewCellStyle1.Format = "C2";
            this.BFiyat.DefaultCellStyle = dataGridViewCellStyle1;
            this.BFiyat.HeaderText = "Birim Fiyat";
            this.BFiyat.Name = "BFiyat";
            // 
            // SatisFiyat
            // 
            this.SatisFiyat.HeaderText = "Satış Fiyatı";
            this.SatisFiyat.Name = "SatisFiyat";
            // 
            // Adet
            // 
            dataGridViewCellStyle2.Format = "N0";
            this.Adet.DefaultCellStyle = dataGridViewCellStyle2;
            this.Adet.HeaderText = "Adet";
            this.Adet.Name = "Adet";
            // 
            // AraKdv
            // 
            dataGridViewCellStyle3.Format = "C2";
            this.AraKdv.DefaultCellStyle = dataGridViewCellStyle3;
            this.AraKdv.HeaderText = "KdvTutar";
            this.AraKdv.Name = "AraKdv";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // SAdet
            // 
            this.SAdet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SAdet.HeaderText = "Stok Adet";
            this.SAdet.Name = "SAdet";
            this.SAdet.Width = 73;
            // 
            // frmUrunSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 493);
            this.Controls.Add(this.splitX);
            this.Name = "frmUrunSatis";
            this.Text = "frmUrunSatis";
            this.Load += new System.EventHandler(this.frmUrunSatis_Load);
            this.pnlUst.ResumeLayout(false);
            this.pnlUst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.splitY.Panel1.ResumeLayout(false);
            this.splitY.Panel1.PerformLayout();
            this.splitY.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitY)).EndInit();
            this.splitY.ResumeLayout(false);
            this.splitX.Panel1.ResumeLayout(false);
            this.splitX.Panel2.ResumeLayout(false);
            this.splitX.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitX)).EndInit();
            this.splitX.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtUkod;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label labl;
        private System.Windows.Forms.TextBox txtKdvToplam;
        private System.Windows.Forms.Label labbel;
        private System.Windows.Forms.TextBox txtGenelToplam;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtAraToplam;
        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.TextBox txtSatisGrupNo;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.DateTimePicker txtSTarih;
        private System.Windows.Forms.ComboBox txtOdeme;
        private System.Windows.Forms.ComboBox txtCari;
        private System.Windows.Forms.ComboBox txtVade;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.SplitContainer splitY;
        private System.Windows.Forms.SplitContainer splitX;
        private System.Windows.Forms.ComboBox txtKarOrani;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birim;
        private System.Windows.Forms.DataGridViewTextBoxColumn BFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn SatisFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn AraKdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn SAdet;
    }
}