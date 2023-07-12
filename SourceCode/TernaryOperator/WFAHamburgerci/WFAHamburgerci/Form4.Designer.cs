namespace WFAHamburgerci
{
    partial class Form4
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
            this.lstSiparisler = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCiro = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSiparis = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblExtraMalzeme = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblSatisAdeti = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tüm Siparişler";
            // 
            // lstSiparisler
            // 
            this.lstSiparisler.FormattingEnabled = true;
            this.lstSiparisler.ItemHeight = 25;
            this.lstSiparisler.Location = new System.Drawing.Point(16, 61);
            this.lstSiparisler.Name = "lstSiparisler";
            this.lstSiparisler.Size = new System.Drawing.Size(390, 429);
            this.lstSiparisler.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCiro);
            this.groupBox1.Location = new System.Drawing.Point(442, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 74);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ciro";
            // 
            // lblCiro
            // 
            this.lblCiro.AutoSize = true;
            this.lblCiro.Location = new System.Drawing.Point(23, 36);
            this.lblCiro.Name = "lblCiro";
            this.lblCiro.Size = new System.Drawing.Size(0, 25);
            this.lblCiro.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSiparis);
            this.groupBox2.Location = new System.Drawing.Point(442, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 74);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Toplam Sipariş Sayısı";
            // 
            // lblSiparis
            // 
            this.lblSiparis.AutoSize = true;
            this.lblSiparis.Location = new System.Drawing.Point(23, 36);
            this.lblSiparis.Name = "lblSiparis";
            this.lblSiparis.Size = new System.Drawing.Size(0, 25);
            this.lblSiparis.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblExtraMalzeme);
            this.groupBox3.Location = new System.Drawing.Point(442, 290);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(356, 74);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Extra Malzeme Geliri";
            // 
            // lblExtraMalzeme
            // 
            this.lblExtraMalzeme.AutoSize = true;
            this.lblExtraMalzeme.Location = new System.Drawing.Point(23, 36);
            this.lblExtraMalzeme.Name = "lblExtraMalzeme";
            this.lblExtraMalzeme.Size = new System.Drawing.Size(0, 25);
            this.lblExtraMalzeme.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblSatisAdeti);
            this.groupBox4.Location = new System.Drawing.Point(442, 416);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(356, 74);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Satılan Ürün Adedi";
            // 
            // lblSatisAdeti
            // 
            this.lblSatisAdeti.AutoSize = true;
            this.lblSatisAdeti.Location = new System.Drawing.Point(23, 36);
            this.lblSatisAdeti.Name = "lblSatisAdeti";
            this.lblSatisAdeti.Size = new System.Drawing.Size(0, 25);
            this.lblSatisAdeti.TabIndex = 0;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 510);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstSiparisler);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstSiparisler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCiro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSiparis;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblExtraMalzeme;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblSatisAdeti;
    }
}