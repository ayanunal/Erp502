namespace UcakBiletiAlma
{
    partial class frmHavale
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
            this.btnHavale = new System.Windows.Forms.Button();
            this.txtCvc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGecerlilik = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKartNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHavale
            // 
            this.btnHavale.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHavale.Location = new System.Drawing.Point(665, 262);
            this.btnHavale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHavale.Name = "btnHavale";
            this.btnHavale.Size = new System.Drawing.Size(115, 57);
            this.btnHavale.TabIndex = 13;
            this.btnHavale.Text = "Ödeme Yap";
            this.btnHavale.UseVisualStyleBackColor = true;
            this.btnHavale.Click += new System.EventHandler(this.btnHavale_Click);
            // 
            // txtCvc
            // 
            this.txtCvc.Location = new System.Drawing.Point(595, 156);
            this.txtCvc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCvc.Name = "txtCvc";
            this.txtCvc.Size = new System.Drawing.Size(140, 22);
            this.txtCvc.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(616, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "CVC";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGecerlilik
            // 
            this.txtGecerlilik.Location = new System.Drawing.Point(323, 156);
            this.txtGecerlilik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGecerlilik.Name = "txtGecerlilik";
            this.txtGecerlilik.Size = new System.Drawing.Size(201, 22);
            this.txtGecerlilik.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(320, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "SON GEÇERLİLİK TARİHİ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtKartNo
            // 
            this.txtKartNo.Location = new System.Drawing.Point(21, 156);
            this.txtKartNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKartNo.Name = "txtKartNo";
            this.txtKartNo.Size = new System.Drawing.Size(188, 22);
            this.txtKartNo.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(32, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "KART NUMARANIZ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmHavale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(898, 536);
            this.Controls.Add(this.btnHavale);
            this.Controls.Add(this.txtCvc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGecerlilik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKartNo);
            this.Controls.Add(this.label1);
            this.Name = "frmHavale";
            this.Text = "frmHavale";
            this.Load += new System.EventHandler(this.frmHavale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHavale;
        private System.Windows.Forms.TextBox txtCvc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGecerlilik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKartNo;
        private System.Windows.Forms.Label label1;
    }
}