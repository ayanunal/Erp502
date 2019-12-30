namespace MixErp302.Bilgi
{
    partial class frmCariGiris
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
            this.splitX = new System.Windows.Forms.SplitContainer();
            this.splitY = new System.Windows.Forms.SplitContainer();
            this.txtIlceId = new System.Windows.Forms.ComboBox();
            this.txtSehirId = new System.Windows.Forms.ComboBox();
            this.txtCariTipId = new System.Windows.Forms.ComboBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtVergiD = new System.Windows.Forms.TextBox();
            this.txtVergiNoTc = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtCariAdi = new System.Windows.Forms.TextBox();
            this.txtCariNo = new System.Windows.Forms.TextBox();
            this.lbl9 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VergiNoTc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VergiD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlUst = new System.Windows.Forms.Panel();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
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
            this.splitX.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.splitX.Panel2.Controls.Add(this.btnKapat);
            this.splitX.Panel2.Controls.Add(this.btnKaydet);
            this.splitX.Size = new System.Drawing.Size(963, 481);
            this.splitX.SplitterDistance = 808;
            this.splitX.TabIndex = 0;
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
            this.splitY.Panel1.Controls.Add(this.txtIlceId);
            this.splitY.Panel1.Controls.Add(this.txtSehirId);
            this.splitY.Panel1.Controls.Add(this.txtCariTipId);
            this.splitY.Panel1.Controls.Add(this.txtAdres);
            this.splitY.Panel1.Controls.Add(this.txtVergiD);
            this.splitY.Panel1.Controls.Add(this.txtVergiNoTc);
            this.splitY.Panel1.Controls.Add(this.txtTel);
            this.splitY.Panel1.Controls.Add(this.txtCariAdi);
            this.splitY.Panel1.Controls.Add(this.txtCariNo);
            this.splitY.Panel1.Controls.Add(this.lbl9);
            this.splitY.Panel1.Controls.Add(this.lbl8);
            this.splitY.Panel1.Controls.Add(this.lbl7);
            this.splitY.Panel1.Controls.Add(this.lbl6);
            this.splitY.Panel1.Controls.Add(this.lbl4);
            this.splitY.Panel1.Controls.Add(this.lbl3);
            this.splitY.Panel1.Controls.Add(this.lbl5);
            this.splitY.Panel1.Controls.Add(this.lbl2);
            this.splitY.Panel1.Controls.Add(this.lbl1);
            // 
            // splitY.Panel2
            // 
            this.splitY.Panel2.Controls.Add(this.Liste);
            this.splitY.Panel2.Controls.Add(this.pnlUst);
            this.splitY.Size = new System.Drawing.Size(808, 481);
            this.splitY.SplitterDistance = 294;
            this.splitY.TabIndex = 0;
            // 
            // txtIlceId
            // 
            this.txtIlceId.FormattingEnabled = true;
            this.txtIlceId.Location = new System.Drawing.Point(443, 130);
            this.txtIlceId.Name = "txtIlceId";
            this.txtIlceId.Size = new System.Drawing.Size(121, 21);
            this.txtIlceId.TabIndex = 2;
            // 
            // txtSehirId
            // 
            this.txtSehirId.FormattingEnabled = true;
            this.txtSehirId.Location = new System.Drawing.Point(443, 103);
            this.txtSehirId.Name = "txtSehirId";
            this.txtSehirId.Size = new System.Drawing.Size(121, 21);
            this.txtSehirId.TabIndex = 2;
            this.txtSehirId.SelectedIndexChanged += new System.EventHandler(this.txtSehirId_SelectedIndexChanged);
            // 
            // txtCariTipId
            // 
            this.txtCariTipId.FormattingEnabled = true;
            this.txtCariTipId.Location = new System.Drawing.Point(443, 70);
            this.txtCariTipId.Name = "txtCariTipId";
            this.txtCariTipId.Size = new System.Drawing.Size(121, 21);
            this.txtCariTipId.TabIndex = 2;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(146, 172);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(418, 87);
            this.txtAdres.TabIndex = 1;
            // 
            // txtVergiD
            // 
            this.txtVergiD.Location = new System.Drawing.Point(146, 135);
            this.txtVergiD.Name = "txtVergiD";
            this.txtVergiD.Size = new System.Drawing.Size(121, 20);
            this.txtVergiD.TabIndex = 1;
            // 
            // txtVergiNoTc
            // 
            this.txtVergiNoTc.Location = new System.Drawing.Point(443, 36);
            this.txtVergiNoTc.Name = "txtVergiNoTc";
            this.txtVergiNoTc.Size = new System.Drawing.Size(121, 20);
            this.txtVergiNoTc.TabIndex = 1;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(146, 104);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(121, 20);
            this.txtTel.TabIndex = 1;
            // 
            // txtCariAdi
            // 
            this.txtCariAdi.Location = new System.Drawing.Point(146, 67);
            this.txtCariAdi.Name = "txtCariAdi";
            this.txtCariAdi.Size = new System.Drawing.Size(121, 20);
            this.txtCariAdi.TabIndex = 1;
            // 
            // txtCariNo
            // 
            this.txtCariNo.Location = new System.Drawing.Point(146, 36);
            this.txtCariNo.Name = "txtCariNo";
            this.txtCariNo.Size = new System.Drawing.Size(121, 20);
            this.txtCariNo.TabIndex = 1;
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Location = new System.Drawing.Point(398, 138);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(39, 13);
            this.lbl9.TabIndex = 0;
            this.lbl9.Text = "İlçe Id:";
            this.lbl9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Location = new System.Drawing.Point(391, 107);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(46, 13);
            this.lbl8.TabIndex = 0;
            this.lbl8.Text = "Şehir Id:";
            this.lbl8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(391, 74);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(46, 13);
            this.lbl7.TabIndex = 0;
            this.lbl7.Text = "Cari Tip:";
            this.lbl7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(368, 43);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(69, 13);
            this.lbl6.TabIndex = 0;
            this.lbl6.Text = "Vergi No/Tc:";
            this.lbl6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(37, 142);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(69, 13);
            this.lbl4.TabIndex = 0;
            this.lbl4.Text = "Vergi Dairesi:";
            this.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(60, 111);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(46, 13);
            this.lbl3.TabIndex = 0;
            this.lbl3.Text = "Telefon:";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(61, 172);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(37, 13);
            this.lbl5.TabIndex = 0;
            this.lbl5.Text = "Adres:";
            this.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(60, 70);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(46, 13);
            this.lbl2.TabIndex = 0;
            this.lbl2.Text = "Cari Adı:";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(61, 36);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(45, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Cari No:";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CariNo,
            this.CariAdi,
            this.VergiNoTc,
            this.VergiD});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Top;
            this.Liste.Location = new System.Drawing.Point(0, 59);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(804, 150);
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
            // CariNo
            // 
            this.CariNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariNo.HeaderText = "Cari No";
            this.CariNo.Name = "CariNo";
            this.CariNo.Width = 67;
            // 
            // CariAdi
            // 
            this.CariAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CariAdi.HeaderText = "Cari Adı";
            this.CariAdi.Name = "CariAdi";
            // 
            // VergiNoTc
            // 
            this.VergiNoTc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.VergiNoTc.HeaderText = "Vergi No/Tc";
            this.VergiNoTc.Name = "VergiNoTc";
            this.VergiNoTc.Width = 91;
            // 
            // VergiD
            // 
            this.VergiD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.VergiD.HeaderText = "Vergi Dairesi";
            this.VergiD.Name = "VergiD";
            this.VergiD.Width = 91;
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlUst.Controls.Add(this.btnSil);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(804, 59);
            this.pnlUst.TabIndex = 0;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSil.Location = new System.Drawing.Point(10, 13);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(106, 40);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.Red;
            this.btnKapat.Location = new System.Drawing.Point(24, 434);
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
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(24, 10);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(106, 33);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // frmCariGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 481);
            this.Controls.Add(this.splitX);
            this.Name = "frmCariGiris";
            this.Text = "frmCariGiris";
            this.Load += new System.EventHandler(this.frmCariGiris_Load);
            this.splitX.Panel1.ResumeLayout(false);
            this.splitX.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitX)).EndInit();
            this.splitX.ResumeLayout(false);
            this.splitY.Panel1.ResumeLayout(false);
            this.splitY.Panel1.PerformLayout();
            this.splitY.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitY)).EndInit();
            this.splitY.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.pnlUst.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitX;
        private System.Windows.Forms.SplitContainer splitY;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.ComboBox txtIlceId;
        private System.Windows.Forms.ComboBox txtSehirId;
        private System.Windows.Forms.ComboBox txtCariTipId;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtVergiD;
        private System.Windows.Forms.TextBox txtVergiNoTc;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtCariAdi;
        private System.Windows.Forms.TextBox txtCariNo;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn VergiNoTc;
        private System.Windows.Forms.DataGridViewTextBoxColumn VergiD;
    }
}