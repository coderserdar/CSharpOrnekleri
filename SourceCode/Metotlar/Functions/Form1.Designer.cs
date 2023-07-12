namespace Functions
{
    partial class Form1
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
            this.btnToplama = new System.Windows.Forms.Button();
            this.btnCiftTek = new System.Windows.Forms.Button();
            this.btnMetinselDegisiklik = new System.Windows.Forms.Button();
            this.btnDizi = new System.Windows.Forms.Button();
            this.btnRengiYakala = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnToplama
            // 
            this.btnToplama.Location = new System.Drawing.Point(12, 17);
            this.btnToplama.Name = "btnToplama";
            this.btnToplama.Size = new System.Drawing.Size(439, 61);
            this.btnToplama.TabIndex = 0;
            this.btnToplama.Text = "TOPLAMA YAP";
            this.btnToplama.UseVisualStyleBackColor = true;
            this.btnToplama.Click += new System.EventHandler(this.btnToplama_Click);
            // 
            // btnCiftTek
            // 
            this.btnCiftTek.Location = new System.Drawing.Point(12, 120);
            this.btnCiftTek.Name = "btnCiftTek";
            this.btnCiftTek.Size = new System.Drawing.Size(439, 61);
            this.btnCiftTek.TabIndex = 0;
            this.btnCiftTek.Text = "ÇİFT Mİ TEK Mİ";
            this.btnCiftTek.UseVisualStyleBackColor = true;
            this.btnCiftTek.Click += new System.EventHandler(this.btnCiftTek_Click);
            // 
            // btnMetinselDegisiklik
            // 
            this.btnMetinselDegisiklik.Location = new System.Drawing.Point(12, 269);
            this.btnMetinselDegisiklik.Name = "btnMetinselDegisiklik";
            this.btnMetinselDegisiklik.Size = new System.Drawing.Size(439, 61);
            this.btnMetinselDegisiklik.TabIndex = 0;
            this.btnMetinselDegisiklik.Text = "METİNSEL DEĞİŞİKLİK";
            this.btnMetinselDegisiklik.UseVisualStyleBackColor = true;
            this.btnMetinselDegisiklik.Click += new System.EventHandler(this.btnMetinselDegisiklik_Click);
            // 
            // btnDizi
            // 
            this.btnDizi.Location = new System.Drawing.Point(12, 336);
            this.btnDizi.Name = "btnDizi";
            this.btnDizi.Size = new System.Drawing.Size(439, 61);
            this.btnDizi.TabIndex = 0;
            this.btnDizi.Text = "DİZİ İŞLEME";
            this.btnDizi.UseVisualStyleBackColor = true;
            this.btnDizi.Click += new System.EventHandler(this.btnDizi_Click);
            // 
            // btnRengiYakala
            // 
            this.btnRengiYakala.BackColor = System.Drawing.Color.LimeGreen;
            this.btnRengiYakala.Location = new System.Drawing.Point(12, 403);
            this.btnRengiYakala.Name = "btnRengiYakala";
            this.btnRengiYakala.Size = new System.Drawing.Size(439, 61);
            this.btnRengiYakala.TabIndex = 0;
            this.btnRengiYakala.Text = "RENGİ YAKALA";
            this.btnRengiYakala.UseVisualStyleBackColor = false;
            this.btnRengiYakala.Click += new System.EventHandler(this.btnRengiYakala_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(439, 30);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 223);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(439, 30);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 187);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(439, 30);
            this.textBox3.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 480);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnRengiYakala);
            this.Controls.Add(this.btnDizi);
            this.Controls.Add(this.btnMetinselDegisiklik);
            this.Controls.Add(this.btnCiftTek);
            this.Controls.Add(this.btnToplama);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToplama;
        private System.Windows.Forms.Button btnCiftTek;
        private System.Windows.Forms.Button btnMetinselDegisiklik;
        private System.Windows.Forms.Button btnDizi;
        private System.Windows.Forms.Button btnRengiYakala;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

