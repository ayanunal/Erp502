namespace UcakBiletiAlma
{
    partial class frmRezerve
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
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TcNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nereden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nereye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ucret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KoltukNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnkaydett = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // Liste
            // 
            this.Liste.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Liste.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.TcNo,
            this.Nereden,
            this.Nereye,
            this.Tarih,
            this.Saat,
            this.Ad,
            this.Telefon,
            this.Ucret,
            this.KoltukNo});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Liste.Location = new System.Drawing.Point(0, 265);
            this.Liste.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Liste.Name = "Liste";
            this.Liste.RowHeadersWidth = 51;
            this.Liste.Size = new System.Drawing.Size(1371, 315);
            this.Liste.TabIndex = 0;
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // TcNo
            // 
            this.TcNo.HeaderText = "Tc Numarası";
            this.TcNo.MinimumWidth = 6;
            this.TcNo.Name = "TcNo";
            this.TcNo.Width = 125;
            // 
            // Nereden
            // 
            this.Nereden.HeaderText = "Nereden";
            this.Nereden.MinimumWidth = 6;
            this.Nereden.Name = "Nereden";
            this.Nereden.Width = 125;
            // 
            // Nereye
            // 
            this.Nereye.HeaderText = "Nereye";
            this.Nereye.MinimumWidth = 6;
            this.Nereye.Name = "Nereye";
            this.Nereye.Width = 125;
            // 
            // Tarih
            // 
            this.Tarih.HeaderText = "Yolculuk Tarihi";
            this.Tarih.MinimumWidth = 6;
            this.Tarih.Name = "Tarih";
            this.Tarih.Width = 125;
            // 
            // Saat
            // 
            this.Saat.HeaderText = "Saat";
            this.Saat.MinimumWidth = 6;
            this.Saat.Name = "Saat";
            this.Saat.Width = 125;
            // 
            // Ad
            // 
            this.Ad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ad.HeaderText = "Ad Soyad";
            this.Ad.MinimumWidth = 6;
            this.Ad.Name = "Ad";
            // 
            // Telefon
            // 
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.MinimumWidth = 6;
            this.Telefon.Name = "Telefon";
            this.Telefon.Width = 125;
            // 
            // Ucret
            // 
            this.Ucret.HeaderText = "Ücret";
            this.Ucret.MinimumWidth = 6;
            this.Ucret.Name = "Ucret";
            this.Ucret.Width = 125;
            // 
            // KoltukNo
            // 
            this.KoltukNo.HeaderText = "Koltuk Numarası";
            this.KoltukNo.MinimumWidth = 6;
            this.KoltukNo.Name = "KoltukNo";
            this.KoltukNo.Width = 125;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(495, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(559, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "REZERVASYONLARIM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIptal
            // 
            this.btnIptal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnIptal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIptal.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIptal.Location = new System.Drawing.Point(609, 151);
            this.btnIptal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(264, 66);
            this.btnIptal.TabIndex = 3;
            this.btnIptal.Text = "Bileti İptal Et";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnKapat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKapat.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.btnKapat.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKapat.Location = new System.Drawing.Point(1232, 151);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(159, 57);
            this.btnKapat.TabIndex = 4;
            this.btnKapat.Text = "ÇIKIŞ";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnkaydett
            // 
            this.btnkaydett.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnkaydett.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnkaydett.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.btnkaydett.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnkaydett.Location = new System.Drawing.Point(23, 151);
            this.btnkaydett.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnkaydett.Name = "btnkaydett";
            this.btnkaydett.Size = new System.Drawing.Size(267, 66);
            this.btnkaydett.TabIndex = 5;
            this.btnkaydett.Text = "Bileti Onayla";
            this.btnkaydett.UseVisualStyleBackColor = false;
            this.btnkaydett.Click += new System.EventHandler(this.btnkaydett_Click);
            // 
            // frmRezerve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1371, 580);
            this.Controls.Add(this.btnkaydett);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Liste);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmRezerve";
            this.Text = "frmRezerve";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRezerve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TcNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nereden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nereye;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ucret;
        private System.Windows.Forms.DataGridViewTextBoxColumn KoltukNo;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnkaydett;
    }
}