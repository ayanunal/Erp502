﻿namespace MixErp302.Bilgi
{
    partial class frmPersonelGiris
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
            this.split1 = new System.Windows.Forms.SplitContainer();
            this.split2 = new System.Windows.Forms.SplitContainer();
            this.txtDepartman = new System.Windows.Forms.ComboBox();
            this.txtİsSonTarih = new System.Windows.Forms.DateTimePicker();
            this.txtİsBasTarih = new System.Windows.Forms.DateTimePicker();
            this.txtDogumTarih = new System.Windows.Forms.DateTimePicker();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtPersonelNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonelAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlUst = new System.Windows.Forms.Panel();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.split1)).BeginInit();
            this.split1.Panel1.SuspendLayout();
            this.split1.Panel2.SuspendLayout();
            this.split1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split2)).BeginInit();
            this.split2.Panel1.SuspendLayout();
            this.split2.Panel2.SuspendLayout();
            this.split2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.pnlUst.SuspendLayout();
            this.SuspendLayout();
            // 
            // split1
            // 
            this.split1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.split1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.split1.Location = new System.Drawing.Point(0, 0);
            this.split1.Name = "split1";
            // 
            // split1.Panel1
            // 
            this.split1.Panel1.Controls.Add(this.split2);
            // 
            // split1.Panel2
            // 
            this.split1.Panel2.BackColor = System.Drawing.Color.Red;
            this.split1.Panel2.Controls.Add(this.btnKapat);
            this.split1.Panel2.Controls.Add(this.btnKaydet);
            this.split1.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.split1.Size = new System.Drawing.Size(985, 482);
            this.split1.SplitterDistance = 822;
            this.split1.TabIndex = 0;
            // 
            // split2
            // 
            this.split2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.split2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.split2.Location = new System.Drawing.Point(0, 0);
            this.split2.Name = "split2";
            this.split2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // split2.Panel1
            // 
            this.split2.Panel1.Controls.Add(this.txtDepartman);
            this.split2.Panel1.Controls.Add(this.txtİsSonTarih);
            this.split2.Panel1.Controls.Add(this.txtİsBasTarih);
            this.split2.Panel1.Controls.Add(this.txtDogumTarih);
            this.split2.Panel1.Controls.Add(this.txtAdres);
            this.split2.Panel1.Controls.Add(this.txtEmail);
            this.split2.Panel1.Controls.Add(this.txtTc);
            this.split2.Panel1.Controls.Add(this.txtTel);
            this.split2.Panel1.Controls.Add(this.txtAd);
            this.split2.Panel1.Controls.Add(this.txtPersonelNo);
            this.split2.Panel1.Controls.Add(this.label10);
            this.split2.Panel1.Controls.Add(this.label9);
            this.split2.Panel1.Controls.Add(this.label8);
            this.split2.Panel1.Controls.Add(this.label7);
            this.split2.Panel1.Controls.Add(this.label6);
            this.split2.Panel1.Controls.Add(this.label5);
            this.split2.Panel1.Controls.Add(this.label4);
            this.split2.Panel1.Controls.Add(this.label3);
            this.split2.Panel1.Controls.Add(this.label2);
            this.split2.Panel1.Controls.Add(this.label1);
            // 
            // split2.Panel2
            // 
            this.split2.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.split2.Panel2.Controls.Add(this.Liste);
            this.split2.Panel2.Controls.Add(this.pnlUst);
            this.split2.Size = new System.Drawing.Size(822, 482);
            this.split2.SplitterDistance = 252;
            this.split2.TabIndex = 0;
            // 
            // txtDepartman
            // 
            this.txtDepartman.FormattingEnabled = true;
            this.txtDepartman.Location = new System.Drawing.Point(441, 32);
            this.txtDepartman.Name = "txtDepartman";
            this.txtDepartman.Size = new System.Drawing.Size(144, 21);
            this.txtDepartman.TabIndex = 3;
            // 
            // txtİsSonTarih
            // 
            this.txtİsSonTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtİsSonTarih.Location = new System.Drawing.Point(441, 106);
            this.txtİsSonTarih.Name = "txtİsSonTarih";
            this.txtİsSonTarih.Size = new System.Drawing.Size(144, 20);
            this.txtİsSonTarih.TabIndex = 2;
            // 
            // txtİsBasTarih
            // 
            this.txtİsBasTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtİsBasTarih.Location = new System.Drawing.Point(441, 82);
            this.txtİsBasTarih.Name = "txtİsBasTarih";
            this.txtİsBasTarih.Size = new System.Drawing.Size(144, 20);
            this.txtİsBasTarih.TabIndex = 2;
            // 
            // txtDogumTarih
            // 
            this.txtDogumTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDogumTarih.Location = new System.Drawing.Point(441, 59);
            this.txtDogumTarih.Name = "txtDogumTarih";
            this.txtDogumTarih.Size = new System.Drawing.Size(144, 20);
            this.txtDogumTarih.TabIndex = 2;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(119, 162);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(466, 63);
            this.txtAdres.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(119, 136);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(119, 110);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(100, 20);
            this.txtTc.TabIndex = 1;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(119, 84);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 20);
            this.txtTel.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(119, 58);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 1;
            // 
            // txtPersonelNo
            // 
            this.txtPersonelNo.Location = new System.Drawing.Point(119, 32);
            this.txtPersonelNo.Name = "txtPersonelNo";
            this.txtPersonelNo.Size = new System.Drawing.Size(100, 20);
            this.txtPersonelNo.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(350, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Departman:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(345, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "İş Başlangıç:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(366, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "İş Sonu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(339, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Doğum Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Adres:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tc No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Personel Adi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel No:";
            // 
            // Liste
            // 
            this.Liste.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PersonelNo,
            this.PersonelAdi,
            this.Telefon,
            this.Departman});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 58);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(818, 164);
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
            // PersonelNo
            // 
            this.PersonelNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PersonelNo.HeaderText = "Personel No";
            this.PersonelNo.Name = "PersonelNo";
            this.PersonelNo.Width = 90;
            // 
            // PersonelAdi
            // 
            this.PersonelAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PersonelAdi.HeaderText = "Personel Adı";
            this.PersonelAdi.Name = "PersonelAdi";
            // 
            // Telefon
            // 
            this.Telefon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.Width = 68;
            // 
            // Departman
            // 
            this.Departman.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Departman.HeaderText = "Departman";
            this.Departman.Name = "Departman";
            this.Departman.Width = 84;
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.Color.Red;
            this.pnlUst.Controls.Add(this.btnSil);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(818, 58);
            this.pnlUst.TabIndex = 0;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(10, 6);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(103, 49);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Maroon;
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnKapat.Location = new System.Drawing.Point(0, 428);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(155, 50);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.Maroon;
            this.btnKaydet.Location = new System.Drawing.Point(0, 0);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(155, 47);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // frmPersonelGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 482);
            this.Controls.Add(this.split1);
            this.Name = "frmPersonelGiris";
            this.Text = "frmPersonelGiris";
            this.Load += new System.EventHandler(this.frmPersonelGiris_Load);
            this.split1.Panel1.ResumeLayout(false);
            this.split1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split1)).EndInit();
            this.split1.ResumeLayout(false);
            this.split2.Panel1.ResumeLayout(false);
            this.split2.Panel1.PerformLayout();
            this.split2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split2)).EndInit();
            this.split2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.pnlUst.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer split1;
        private System.Windows.Forms.SplitContainer split2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtDepartman;
        private System.Windows.Forms.DateTimePicker txtİsSonTarih;
        private System.Windows.Forms.DateTimePicker txtİsBasTarih;
        private System.Windows.Forms.DateTimePicker txtDogumTarih;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtPersonelNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonelAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departman;
        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnKaydet;
    }
}