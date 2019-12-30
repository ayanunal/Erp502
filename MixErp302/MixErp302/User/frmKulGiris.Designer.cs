namespace MixErp302.User
{
    partial class frmKulGiris
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
            this.txtRole = new System.Windows.Forms.ComboBox();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.pnlUst = new System.Windows.Forms.Panel();
            this.txtBul = new System.Windows.Forms.TextBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtKulAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KullaniciAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sifre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.splitX.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.splitX.Panel2.Controls.Add(this.btnKapat);
            this.splitX.Panel2.Controls.Add(this.btnKaydet);
            this.splitX.Size = new System.Drawing.Size(920, 477);
            this.splitX.SplitterDistance = 765;
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
            this.splitY.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.splitY.Panel1.Controls.Add(this.txtSifre);
            this.splitY.Panel1.Controls.Add(this.txtKulAdi);
            this.splitY.Panel1.Controls.Add(this.txtRole);
            this.splitY.Panel1.Controls.Add(this.lbl7);
            this.splitY.Panel1.Controls.Add(this.lbl2);
            this.splitY.Panel1.Controls.Add(this.lbl1);
            // 
            // splitY.Panel2
            // 
            this.splitY.Panel2.Controls.Add(this.Liste);
            this.splitY.Panel2.Controls.Add(this.pnlUst);
            this.splitY.Size = new System.Drawing.Size(765, 477);
            this.splitY.SplitterDistance = 110;
            this.splitY.TabIndex = 0;
            // 
            // txtRole
            // 
            this.txtRole.FormattingEnabled = true;
            this.txtRole.Items.AddRange(new object[] {
            "0-Belirtilmemiş",
            "1-Admin",
            "2-Standart Kullanıcı",
            "3-Misafir"});
            this.txtRole.Location = new System.Drawing.Point(452, 35);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(166, 21);
            this.txtRole.TabIndex = 2;
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(391, 39);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(26, 13);
            this.lbl7.TabIndex = 0;
            this.lbl7.Text = "Rol:";
            this.lbl7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(91, 70);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(34, 13);
            this.lbl2.TabIndex = 0;
            this.lbl2.Text = "Şifre: ";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(55, 42);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(67, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Kullanıcı Adı:";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Liste
            // 
            this.Liste.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.KullaniciAdi,
            this.Sifre,
            this.Rol});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Top;
            this.Liste.Location = new System.Drawing.Point(0, 59);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(761, 299);
            this.Liste.TabIndex = 1;
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.SystemColors.GrayText;
            this.pnlUst.Controls.Add(this.txtBul);
            this.pnlUst.Controls.Add(this.btnBul);
            this.pnlUst.Controls.Add(this.btnSil);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(761, 59);
            this.pnlUst.TabIndex = 0;
            // 
            // txtBul
            // 
            this.txtBul.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBul.Location = new System.Drawing.Point(475, 18);
            this.txtBul.Name = "txtBul";
            this.txtBul.Size = new System.Drawing.Size(177, 20);
            this.txtBul.TabIndex = 2;
            // 
            // btnBul
            // 
            this.btnBul.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBul.BackColor = System.Drawing.Color.Lime;
            this.btnBul.Location = new System.Drawing.Point(671, 12);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(75, 31);
            this.btnBul.TabIndex = 1;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = false;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
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
            // btnKapat
            // 
            this.btnKapat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.Red;
            this.btnKapat.Location = new System.Drawing.Point(24, 430);
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
            // txtKulAdi
            // 
            this.txtKulAdi.Location = new System.Drawing.Point(144, 36);
            this.txtKulAdi.Name = "txtKulAdi";
            this.txtKulAdi.Size = new System.Drawing.Size(166, 20);
            this.txtKulAdi.TabIndex = 3;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(144, 67);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(166, 20);
            this.txtSifre.TabIndex = 3;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 41;
            // 
            // KullaniciAdi
            // 
            this.KullaniciAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KullaniciAdi.HeaderText = "Kullanıcı Adı";
            this.KullaniciAdi.Name = "KullaniciAdi";
            // 
            // Sifre
            // 
            this.Sifre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sifre.HeaderText = "Şifre";
            this.Sifre.Name = "Sifre";
            // 
            // Rol
            // 
            this.Rol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Rol.HeaderText = "Rol";
            this.Rol.Name = "Rol";
            // 
            // frmKulGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 477);
            this.Controls.Add(this.splitX);
            this.Name = "frmKulGiris";
            this.Text = "frmKulGiris";
            this.Load += new System.EventHandler(this.frmKulGiris_Load);
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
            this.pnlUst.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitX;
        private System.Windows.Forms.SplitContainer splitY;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKulAdi;
        private System.Windows.Forms.ComboBox txtRole;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.TextBox txtBul;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn KullaniciAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sifre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
    }
}