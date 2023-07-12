namespace GenericList
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
            this.btnOrnekBir = new System.Windows.Forms.Button();
            this.btnOrnekIki = new System.Windows.Forms.Button();
            this.btnOrnekUc = new System.Windows.Forms.Button();
            this.btnOrnekDort = new System.Windows.Forms.Button();
            this.btnOrnek = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnElemanEkle = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnOrnekBir
            // 
            this.btnOrnekBir.Location = new System.Drawing.Point(12, 12);
            this.btnOrnekBir.Name = "btnOrnekBir";
            this.btnOrnekBir.Size = new System.Drawing.Size(533, 49);
            this.btnOrnekBir.TabIndex = 0;
            this.btnOrnekBir.Text = "Eleman ekle";
            this.btnOrnekBir.UseVisualStyleBackColor = true;
            this.btnOrnekBir.Click += new System.EventHandler(this.btnOrnekBir_Click);
            // 
            // btnOrnekIki
            // 
            this.btnOrnekIki.Location = new System.Drawing.Point(12, 67);
            this.btnOrnekIki.Name = "btnOrnekIki";
            this.btnOrnekIki.Size = new System.Drawing.Size(533, 49);
            this.btnOrnekIki.TabIndex = 0;
            this.btnOrnekIki.Text = "Döngü İle Kullanımı";
            this.btnOrnekIki.UseVisualStyleBackColor = true;
            this.btnOrnekIki.Click += new System.EventHandler(this.btnOrnekIki_Click);
            // 
            // btnOrnekUc
            // 
            this.btnOrnekUc.Location = new System.Drawing.Point(12, 125);
            this.btnOrnekUc.Name = "btnOrnekUc";
            this.btnOrnekUc.Size = new System.Drawing.Size(533, 49);
            this.btnOrnekUc.TabIndex = 0;
            this.btnOrnekUc.Text = "Sort";
            this.btnOrnekUc.UseVisualStyleBackColor = true;
            this.btnOrnekUc.Click += new System.EventHandler(this.btnOrnekUc_Click);
            // 
            // btnOrnekDort
            // 
            this.btnOrnekDort.Location = new System.Drawing.Point(12, 180);
            this.btnOrnekDort.Name = "btnOrnekDort";
            this.btnOrnekDort.Size = new System.Drawing.Size(533, 49);
            this.btnOrnekDort.TabIndex = 0;
            this.btnOrnekDort.Text = "Contains";
            this.btnOrnekDort.UseVisualStyleBackColor = true;
            this.btnOrnekDort.Click += new System.EventHandler(this.btnOrnekDort_Click);
            // 
            // btnOrnek
            // 
            this.btnOrnek.Location = new System.Drawing.Point(581, 14);
            this.btnOrnek.Name = "btnOrnek";
            this.btnOrnek.Size = new System.Drawing.Size(529, 47);
            this.btnOrnek.TabIndex = 1;
            this.btnOrnek.Text = "Örnek";
            this.btnOrnek.UseVisualStyleBackColor = true;
            this.btnOrnek.Click += new System.EventHandler(this.btnOrnek_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(581, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(529, 22);
            this.textBox1.TabIndex = 2;
            // 
            // btnElemanEkle
            // 
            this.btnElemanEkle.Location = new System.Drawing.Point(580, 95);
            this.btnElemanEkle.Name = "btnElemanEkle";
            this.btnElemanEkle.Size = new System.Drawing.Size(529, 47);
            this.btnElemanEkle.TabIndex = 1;
            this.btnElemanEkle.Text = "Eleman Ekle";
            this.btnElemanEkle.UseVisualStyleBackColor = true;
            this.btnElemanEkle.Click += new System.EventHandler(this.btnElemanEkle_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(581, 157);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(528, 164);
            this.listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 369);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnElemanEkle);
            this.Controls.Add(this.btnOrnek);
            this.Controls.Add(this.btnOrnekDort);
            this.Controls.Add(this.btnOrnekUc);
            this.Controls.Add(this.btnOrnekIki);
            this.Controls.Add(this.btnOrnekBir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrnekBir;
        private System.Windows.Forms.Button btnOrnekIki;
        private System.Windows.Forms.Button btnOrnekUc;
        private System.Windows.Forms.Button btnOrnekDort;
        private System.Windows.Forms.Button btnOrnek;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnElemanEkle;
        private System.Windows.Forms.ListBox listBox1;
    }
}

