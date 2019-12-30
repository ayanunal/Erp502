namespace UcakBiletiAlma
{
    partial class frmTcGiris
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
            this.txtTcGir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnAna = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTcGir
            // 
            this.txtTcGir.Location = new System.Drawing.Point(273, 111);
            this.txtTcGir.Name = "txtTcGir";
            this.txtTcGir.Size = new System.Drawing.Size(264, 22);
            this.txtTcGir.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(148, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(569, 92);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(100, 61);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "GETİR";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnAna
            // 
            this.btnAna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAna.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAna.Location = new System.Drawing.Point(35, 356);
            this.btnAna.Name = "btnAna";
            this.btnAna.Size = new System.Drawing.Size(132, 57);
            this.btnAna.TabIndex = 3;
            this.btnAna.Text = "ANA SAYFA";
            this.btnAna.UseVisualStyleBackColor = true;
            this.btnAna.Click += new System.EventHandler(this.btnAna_Click);
            // 
            // frmTcGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAna);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTcGir);
            this.Name = "frmTcGiris";
            this.Text = "frmTcGiris";
            this.Load += new System.EventHandler(this.frmTcGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTcGir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnAna;
    }
}