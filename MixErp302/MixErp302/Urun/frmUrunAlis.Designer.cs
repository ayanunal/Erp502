namespace MixErp302.Urun
{
    partial class frmUrunAlis
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
            this.splitX = new System.Windows.Forms.SplitContainer();
            this.splitY = new System.Windows.Forms.SplitContainer();
            this.txtFaturaNo = new System.Windows.Forms.TextBox();
            this.txtATarih = new System.Windows.Forms.DateTimePicker();
            this.txtOdeme = new System.Windows.Forms.ComboBox();
            this.txtCari = new System.Windows.Forms.ComboBox();
            this.txtVade = new System.Windows.Forms.ComboBox();
            this.lbl9 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.UrunKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AraKdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlUst = new System.Windows.Forms.Panel();
            this.txtUkod = new System.Windows.Forms.ComboBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.labl = new System.Windows.Forms.Label();
            this.txtKdvToplam = new System.Windows.Forms.TextBox();
            this.labbel = new System.Windows.Forms.Label();
            this.txtGenelToplam = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtAraToplam = new System.Windows.Forms.TextBox();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtAlisGrupNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitX)).BeginInit();
            this.splitX.Panel1.SuspendLayout();
            this.splitX.Panel2.SuspendLayout();
            this.splitX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitY)).BeginInit();
            this.splitY.Panel1.SuspendLayout();
            this.splitY.Panel2.SuspendLayout();
            this.splitY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.pnlUst.SuspendLayout();
            this.SuspendLayout();
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
            this.splitX.Panel2.BackColor = System.Drawing.Color.Lime;
            this.splitX.Panel2.Controls.Add(this.btnKapat);
            this.splitX.Panel2.Controls.Add(this.btnKaydet);
            this.splitX.Panel2.Controls.Add(this.txtAlisGrupNo);
            this.splitX.Panel2.Controls.Add(this.label1);
            this.splitX.Size = new System.Drawing.Size(958, 486);
            this.splitX.SplitterDistance = 803;
            this.splitX.TabIndex = 2;
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
            this.splitY.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.splitY.Panel1.Controls.Add(this.txtFaturaNo);
            this.splitY.Panel1.Controls.Add(this.txtATarih);
            this.splitY.Panel1.Controls.Add(this.txtOdeme);
            this.splitY.Panel1.Controls.Add(this.txtCari);
            this.splitY.Panel1.Controls.Add(this.txtVade);
            this.splitY.Panel1.Controls.Add(this.lbl9);
            this.splitY.Panel1.Controls.Add(this.lbl8);
            this.splitY.Panel1.Controls.Add(this.label2);
            this.splitY.Panel1.Controls.Add(this.lbl7);
            this.splitY.Panel1.Controls.Add(this.lbl3);
            // 
            // splitY.Panel2
            // 
            this.splitY.Panel2.Controls.Add(this.Liste);
            this.splitY.Panel2.Controls.Add(this.pnlUst);
            this.splitY.Size = new System.Drawing.Size(803, 486);
            this.splitY.SplitterDistance = 137;
            this.splitY.TabIndex = 0;
            // 
            // txtFaturaNo
            // 
            this.txtFaturaNo.Location = new System.Drawing.Point(88, 93);
            this.txtFaturaNo.Name = "txtFaturaNo";
            this.txtFaturaNo.Size = new System.Drawing.Size(166, 20);
            this.txtFaturaNo.TabIndex = 4;
            // 
            // txtATarih
            // 
            this.txtATarih.Location = new System.Drawing.Point(88, 63);
            this.txtATarih.Name = "txtATarih";
            this.txtATarih.Size = new System.Drawing.Size(228, 20);
            this.txtATarih.TabIndex = 3;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fatura No:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(22, 63);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(55, 13);
            this.lbl7.TabIndex = 0;
            this.lbl7.Text = "Alış Tarihi:";
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
            // Liste
            // 
            this.Liste.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UrunKodu,
            this.UrunAciklama,
            this.Birim,
            this.BFiyat,
            this.Adet,
            this.AraKdv,
            this.Id});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Top;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(799, 229);
            this.Liste.TabIndex = 1;
            this.Liste.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Liste_CellEndEdit);
            this.Liste.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Liste_EditingControlShowing);
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
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.Color.Lime;
            this.pnlUst.Controls.Add(this.txtUkod);
            this.pnlUst.Controls.Add(this.btnPrint);
            this.pnlUst.Controls.Add(this.btnSil);
            this.pnlUst.Controls.Add(this.labl);
            this.pnlUst.Controls.Add(this.txtKdvToplam);
            this.pnlUst.Controls.Add(this.labbel);
            this.pnlUst.Controls.Add(this.txtGenelToplam);
            this.pnlUst.Controls.Add(this.lbl1);
            this.pnlUst.Controls.Add(this.txtAraToplam);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUst.Location = new System.Drawing.Point(0, 228);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(799, 113);
            this.pnlUst.TabIndex = 0;
            // 
            // txtUkod
            // 
            this.txtUkod.FormattingEnabled = true;
            this.txtUkod.Location = new System.Drawing.Point(10, 53);
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
            this.btnSil.Size = new System.Drawing.Size(76, 31);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            // 
            // labl
            // 
            this.labl.AutoSize = true;
            this.labl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labl.Location = new System.Drawing.Point(394, 52);
            this.labl.Name = "labl";
            this.labl.Size = new System.Drawing.Size(67, 13);
            this.labl.TabIndex = 0;
            this.labl.Text = "Kdv Toplam:";
            this.labl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtKdvToplam
            // 
            this.txtKdvToplam.Location = new System.Drawing.Point(467, 45);
            this.txtKdvToplam.Name = "txtKdvToplam";
            this.txtKdvToplam.Size = new System.Drawing.Size(166, 20);
            this.txtKdvToplam.TabIndex = 1;
            // 
            // labbel
            // 
            this.labbel.AutoSize = true;
            this.labbel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labbel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labbel.Location = new System.Drawing.Point(385, 79);
            this.labbel.Name = "labbel";
            this.labbel.Size = new System.Drawing.Size(76, 13);
            this.labbel.TabIndex = 0;
            this.labbel.Text = "Genel Toplam:";
            this.labbel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGenelToplam
            // 
            this.txtGenelToplam.Location = new System.Drawing.Point(467, 76);
            this.txtGenelToplam.Name = "txtGenelToplam";
            this.txtGenelToplam.Size = new System.Drawing.Size(166, 20);
            this.txtGenelToplam.TabIndex = 1;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl1.Location = new System.Drawing.Point(397, 21);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(64, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Ara Toplam:";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAraToplam
            // 
            this.txtAraToplam.Location = new System.Drawing.Point(467, 14);
            this.txtAraToplam.Name = "txtAraToplam";
            this.txtAraToplam.Size = new System.Drawing.Size(166, 20);
            this.txtAraToplam.TabIndex = 1;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.Red;
            this.btnKapat.Location = new System.Drawing.Point(24, 439);
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
            // txtAlisGrupNo
            // 
            this.txtAlisGrupNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAlisGrupNo.Location = new System.Drawing.Point(0, 86);
            this.txtAlisGrupNo.Name = "txtAlisGrupNo";
            this.txtAlisGrupNo.Size = new System.Drawing.Size(149, 20);
            this.txtAlisGrupNo.TabIndex = 1;
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
            this.label1.Text = "Alış Grup No";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.Aqua;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrint.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnPrint.Location = new System.Drawing.Point(687, 21);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(84, 71);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmUrunAlis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 486);
            this.Controls.Add(this.splitX);
            this.Name = "frmUrunAlis";
            this.Text = "frmUrunAlis";
            this.Load += new System.EventHandler(this.frmUrunAlis_Load);
            this.splitX.Panel1.ResumeLayout(false);
            this.splitX.Panel2.ResumeLayout(false);
            this.splitX.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitX)).EndInit();
            this.splitX.ResumeLayout(false);
            this.splitY.Panel1.ResumeLayout(false);
            this.splitY.Panel1.PerformLayout();
            this.splitY.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitY)).EndInit();
            this.splitY.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.pnlUst.ResumeLayout(false);
            this.pnlUst.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitX;
        private System.Windows.Forms.SplitContainer splitY;
        private System.Windows.Forms.ComboBox txtOdeme;
        private System.Windows.Forms.ComboBox txtCari;
        private System.Windows.Forms.ComboBox txtVade;
        private System.Windows.Forms.TextBox txtAraToplam;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DateTimePicker txtATarih;
        private System.Windows.Forms.TextBox txtAlisGrupNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labl;
        private System.Windows.Forms.TextBox txtKdvToplam;
        private System.Windows.Forms.Label labbel;
        private System.Windows.Forms.TextBox txtGenelToplam;
        private System.Windows.Forms.ComboBox txtUkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birim;
        private System.Windows.Forms.DataGridViewTextBoxColumn BFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn AraKdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFaturaNo;
        private System.Windows.Forms.Button btnPrint;
    }
}