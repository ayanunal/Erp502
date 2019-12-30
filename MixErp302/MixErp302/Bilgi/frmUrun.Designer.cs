namespace MixErp302.Bilgi
{
    partial class frmUrun
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
            this.txtKategoriId = new System.Windows.Forms.ComboBox();
            this.txtMenseiId = new System.Windows.Forms.ComboBox();
            this.txtCariId = new System.Windows.Forms.ComboBox();
            this.pnlUst = new System.Windows.Forms.Panel();
            this.txtBul = new System.Windows.Forms.TextBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtUrunAciklama = new System.Windows.Forms.TextBox();
            this.txtUrunKodu = new System.Windows.Forms.TextBox();
            this.lbl9 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.splitY = new System.Windows.Forms.SplitContainer();
            this.txtBirimId = new System.Windows.Forms.ComboBox();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KategoriId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitX = new System.Windows.Forms.SplitContainer();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitY)).BeginInit();
            this.splitY.Panel1.SuspendLayout();
            this.splitY.Panel2.SuspendLayout();
            this.splitY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitX)).BeginInit();
            this.splitX.Panel1.SuspendLayout();
            this.splitX.Panel2.SuspendLayout();
            this.splitX.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKategoriId
            // 
            this.txtKategoriId.FormattingEnabled = true;
            this.txtKategoriId.Location = new System.Drawing.Point(463, 70);
            this.txtKategoriId.Name = "txtKategoriId";
            this.txtKategoriId.Size = new System.Drawing.Size(166, 21);
            this.txtKategoriId.TabIndex = 2;
            // 
            // txtMenseiId
            // 
            this.txtMenseiId.FormattingEnabled = true;
            this.txtMenseiId.Location = new System.Drawing.Point(463, 39);
            this.txtMenseiId.Name = "txtMenseiId";
            this.txtMenseiId.Size = new System.Drawing.Size(166, 21);
            this.txtMenseiId.TabIndex = 2;
            // 
            // txtCariId
            // 
            this.txtCariId.FormattingEnabled = true;
            this.txtCariId.Location = new System.Drawing.Point(146, 98);
            this.txtCariId.Name = "txtCariId";
            this.txtCariId.Size = new System.Drawing.Size(166, 21);
            this.txtCariId.TabIndex = 2;
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlUst.Controls.Add(this.txtBul);
            this.pnlUst.Controls.Add(this.btnBul);
            this.pnlUst.Controls.Add(this.btnSil);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(782, 59);
            this.pnlUst.TabIndex = 0;
            // 
            // txtBul
            // 
            this.txtBul.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBul.Location = new System.Drawing.Point(496, 18);
            this.txtBul.Name = "txtBul";
            this.txtBul.Size = new System.Drawing.Size(177, 20);
            this.txtBul.TabIndex = 2;
            
            // 
            // btnBul
            // 
            this.btnBul.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBul.Location = new System.Drawing.Point(692, 12);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(75, 31);
            this.btnBul.TabIndex = 1;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
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
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtUrunAciklama
            // 
            this.txtUrunAciklama.Location = new System.Drawing.Point(146, 67);
            this.txtUrunAciklama.Name = "txtUrunAciklama";
            this.txtUrunAciklama.Size = new System.Drawing.Size(166, 20);
            this.txtUrunAciklama.TabIndex = 1;
            // 
            // txtUrunKodu
            // 
            this.txtUrunKodu.Location = new System.Drawing.Point(146, 36);
            this.txtUrunKodu.Name = "txtUrunKodu";
            this.txtUrunKodu.Size = new System.Drawing.Size(166, 20);
            this.txtUrunKodu.TabIndex = 1;
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Location = new System.Drawing.Point(403, 106);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(32, 13);
            this.lbl9.TabIndex = 0;
            this.lbl9.Text = "Birim:";
            this.lbl9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(391, 39);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(44, 13);
            this.lbl7.TabIndex = 0;
            this.lbl7.Text = "Menşei:";
            this.lbl7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Location = new System.Drawing.Point(386, 74);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(49, 13);
            this.lbl8.TabIndex = 0;
            this.lbl8.Text = "Kategori:";
            this.lbl8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(24, 10);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(106, 33);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(69, 103);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(53, 13);
            this.lbl3.TabIndex = 0;
            this.lbl3.Text = "Firma Adı:";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(43, 70);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(79, 13);
            this.lbl2.TabIndex = 0;
            this.lbl2.Text = "Ürün Açıklama:";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(61, 36);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(61, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Ürün Kodu:";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.Red;
            this.btnKapat.Location = new System.Drawing.Point(24, 436);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(106, 33);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
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
            this.splitY.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.splitY.Panel1.Controls.Add(this.txtBirimId);
            this.splitY.Panel1.Controls.Add(this.txtKategoriId);
            this.splitY.Panel1.Controls.Add(this.txtMenseiId);
            this.splitY.Panel1.Controls.Add(this.txtCariId);
            this.splitY.Panel1.Controls.Add(this.txtUrunAciklama);
            this.splitY.Panel1.Controls.Add(this.txtUrunKodu);
            this.splitY.Panel1.Controls.Add(this.lbl9);
            this.splitY.Panel1.Controls.Add(this.lbl8);
            this.splitY.Panel1.Controls.Add(this.lbl7);
            this.splitY.Panel1.Controls.Add(this.lbl3);
            this.splitY.Panel1.Controls.Add(this.lbl2);
            this.splitY.Panel1.Controls.Add(this.lbl1);
            // 
            // splitY.Panel2
            // 
            this.splitY.Panel2.Controls.Add(this.Liste);
            this.splitY.Panel2.Controls.Add(this.pnlUst);
            this.splitY.Size = new System.Drawing.Size(786, 483);
            this.splitY.SplitterDistance = 175;
            this.splitY.TabIndex = 0;
            // 
            // txtBirimId
            // 
            this.txtBirimId.FormattingEnabled = true;
            this.txtBirimId.Location = new System.Drawing.Point(463, 100);
            this.txtBirimId.Name = "txtBirimId";
            this.txtBirimId.Size = new System.Drawing.Size(166, 21);
            this.txtBirimId.TabIndex = 2;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.UrunKodu,
            this.UrunAciklama,
            this.CariAdi,
            this.KategoriId});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Top;
            this.Liste.Location = new System.Drawing.Point(0, 59);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(782, 243);
            this.Liste.TabIndex = 1;
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 41;
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
            // CariAdi
            // 
            this.CariAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CariAdi.HeaderText = "Cari Adı";
            this.CariAdi.Name = "CariAdi";
            // 
            // KategoriId
            // 
            this.KategoriId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.KategoriId.HeaderText = "Kategori";
            this.KategoriId.Name = "KategoriId";
            this.KategoriId.Width = 71;
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
            this.splitX.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.splitX.Panel2.Controls.Add(this.btnKapat);
            this.splitX.Panel2.Controls.Add(this.btnKaydet);
            this.splitX.Size = new System.Drawing.Size(941, 483);
            this.splitX.SplitterDistance = 786;
            this.splitX.TabIndex = 1;
            // 
            // frmUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 483);
            this.Controls.Add(this.splitX);
            this.Name = "frmUrun";
            this.Text = "frmUrun";
            this.Load += new System.EventHandler(this.frmUrun_Load);
            this.pnlUst.ResumeLayout(false);
            this.pnlUst.PerformLayout();
            this.splitY.Panel1.ResumeLayout(false);
            this.splitY.Panel1.PerformLayout();
            this.splitY.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitY)).EndInit();
            this.splitY.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.splitX.Panel1.ResumeLayout(false);
            this.splitX.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitX)).EndInit();
            this.splitX.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox txtKategoriId;
        private System.Windows.Forms.ComboBox txtMenseiId;
        private System.Windows.Forms.ComboBox txtCariId;
        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtUrunAciklama;
        private System.Windows.Forms.TextBox txtUrunKodu;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.SplitContainer splitY;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.SplitContainer splitX;
        private System.Windows.Forms.ComboBox txtBirimId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KategoriId;
        private System.Windows.Forms.TextBox txtBul;
        private System.Windows.Forms.Button btnBul;
    }
}