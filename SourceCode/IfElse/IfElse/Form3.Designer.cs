namespace IfElse
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblRastgeleKarakterler = new System.Windows.Forms.Label();
            this.txtGiris = new System.Windows.Forms.TextBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKalanHak = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(723, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lütfen aşağıdaki gördüğünüz karakterleri ilgili yazı alanına geçiriniz";
            // 
            // lblRastgeleKarakterler
            // 
            this.lblRastgeleKarakterler.AutoSize = true;
            this.lblRastgeleKarakterler.Location = new System.Drawing.Point(12, 49);
            this.lblRastgeleKarakterler.Name = "lblRastgeleKarakterler";
            this.lblRastgeleKarakterler.Size = new System.Drawing.Size(56, 26);
            this.lblRastgeleKarakterler.TabIndex = 1;
            this.lblRastgeleKarakterler.Text = "* * *";
            // 
            // txtGiris
            // 
            this.txtGiris.Location = new System.Drawing.Point(11, 92);
            this.txtGiris.Name = "txtGiris";
            this.txtGiris.Size = new System.Drawing.Size(391, 32);
            this.txtGiris.TabIndex = 2;
            this.txtGiris.MouseHover += new System.EventHandler(this.txtGiris_MouseHover);
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(448, 61);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(286, 62);
            this.btnGirisYap.TabIndex = 3;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kalan Hatalı Giriş Hakkınız :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKalanHak
            // 
            this.lblKalanHak.AutoSize = true;
            this.lblKalanHak.ForeColor = System.Drawing.Color.Maroon;
            this.lblKalanHak.Location = new System.Drawing.Point(323, 160);
            this.lblKalanHak.Name = "lblKalanHak";
            this.lblKalanHak.Size = new System.Drawing.Size(25, 26);
            this.lblKalanHak.TabIndex = 4;
            this.lblKalanHak.Text = "5";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 213);
            this.Controls.Add(this.lblKalanHak);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.txtGiris);
            this.Controls.Add(this.lblRastgeleKarakterler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRastgeleKarakterler;
        private System.Windows.Forms.TextBox txtGiris;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKalanHak;
    }
}