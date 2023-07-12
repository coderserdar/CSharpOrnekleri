namespace WFAHamburgerci
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMalzemeEkle = new System.Windows.Forms.Button();
            this.nmrFiyat = new System.Windows.Forms.NumericUpDown();
            this.txtMalzemeAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMalzemeEkle);
            this.groupBox1.Controls.Add(this.nmrFiyat);
            this.groupBox1.Controls.Add(this.txtMalzemeAdi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.groupBox1.Size = new System.Drawing.Size(500, 263);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Extra Malzeme Bilgileri";
            // 
            // btnMalzemeEkle
            // 
            this.btnMalzemeEkle.Location = new System.Drawing.Point(152, 152);
            this.btnMalzemeEkle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMalzemeEkle.Name = "btnMalzemeEkle";
            this.btnMalzemeEkle.Size = new System.Drawing.Size(320, 83);
            this.btnMalzemeEkle.TabIndex = 3;
            this.btnMalzemeEkle.Text = "Kaydet";
            this.btnMalzemeEkle.UseVisualStyleBackColor = true;
            this.btnMalzemeEkle.Click += new System.EventHandler(this.btnMalzemeEkle_Click);
            // 
            // nmrFiyat
            // 
            this.nmrFiyat.DecimalPlaces = 2;
            this.nmrFiyat.Location = new System.Drawing.Point(152, 100);
            this.nmrFiyat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nmrFiyat.Name = "nmrFiyat";
            this.nmrFiyat.Size = new System.Drawing.Size(320, 30);
            this.nmrFiyat.TabIndex = 2;
            // 
            // txtMalzemeAdi
            // 
            this.txtMalzemeAdi.Location = new System.Drawing.Point(152, 51);
            this.txtMalzemeAdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMalzemeAdi.Name = "txtMalzemeAdi";
            this.txtMalzemeAdi.Size = new System.Drawing.Size(319, 30);
            this.txtMalzemeAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fiyat : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı :";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 303);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form3";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFiyat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMalzemeEkle;
        private System.Windows.Forms.NumericUpDown nmrFiyat;
        private System.Windows.Forms.TextBox txtMalzemeAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}