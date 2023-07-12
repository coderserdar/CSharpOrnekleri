namespace ForLoop
{
    partial class Form2
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnOrnekYedi = new System.Windows.Forms.Button();
            this.btnOrnekAlti = new System.Windows.Forms.Button();
            this.btnOrnekDort = new System.Windows.Forms.Button();
            this.btnOrnekBes = new System.Windows.Forms.Button();
            this.btnOrnekUc = new System.Windows.Forms.Button();
            this.btnOrnekıki = new System.Windows.Forms.Button();
            this.btnOrnekBir = new System.Windows.Forms.Button();
            this.txtGirisAlani = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(394, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(318, 529);
            this.listBox1.TabIndex = 9;
            // 
            // btnOrnekYedi
            // 
            this.btnOrnekYedi.Location = new System.Drawing.Point(19, 488);
            this.btnOrnekYedi.Name = "btnOrnekYedi";
            this.btnOrnekYedi.Size = new System.Drawing.Size(352, 67);
            this.btnOrnekYedi.TabIndex = 2;
            this.btnOrnekYedi.Text = "Toplama Yap";
            this.btnOrnekYedi.UseVisualStyleBackColor = true;
            this.btnOrnekYedi.Click += new System.EventHandler(this.btnOrnekYedi_Click);
            // 
            // btnOrnekAlti
            // 
            this.btnOrnekAlti.Location = new System.Drawing.Point(19, 377);
            this.btnOrnekAlti.Name = "btnOrnekAlti";
            this.btnOrnekAlti.Size = new System.Drawing.Size(352, 67);
            this.btnOrnekAlti.TabIndex = 3;
            this.btnOrnekAlti.Text = "Butonların Stilini Değiştir";
            this.btnOrnekAlti.UseVisualStyleBackColor = true;
            this.btnOrnekAlti.Click += new System.EventHandler(this.btnOrnekAlti_Click);
            // 
            // btnOrnekDort
            // 
            this.btnOrnekDort.Location = new System.Drawing.Point(19, 229);
            this.btnOrnekDort.Name = "btnOrnekDort";
            this.btnOrnekDort.Size = new System.Drawing.Size(352, 67);
            this.btnOrnekDort.TabIndex = 4;
            this.btnOrnekDort.Text = "İsmini Tersten Yazdır";
            this.btnOrnekDort.UseVisualStyleBackColor = true;
            this.btnOrnekDort.Click += new System.EventHandler(this.btnOrnekDort_Click);
            // 
            // btnOrnekBes
            // 
            this.btnOrnekBes.Location = new System.Drawing.Point(19, 304);
            this.btnOrnekBes.Name = "btnOrnekBes";
            this.btnOrnekBes.Size = new System.Drawing.Size(352, 67);
            this.btnOrnekBes.TabIndex = 5;
            this.btnOrnekBes.Text = "Karmaşık Sayıları ListBox\'a At";
            this.btnOrnekBes.UseVisualStyleBackColor = true;
            this.btnOrnekBes.Click += new System.EventHandler(this.btnOrnekBes_Click);
            // 
            // btnOrnekUc
            // 
            this.btnOrnekUc.Location = new System.Drawing.Point(19, 156);
            this.btnOrnekUc.Name = "btnOrnekUc";
            this.btnOrnekUc.Size = new System.Drawing.Size(352, 67);
            this.btnOrnekUc.TabIndex = 6;
            this.btnOrnekUc.Text = "Teklerin ve Çiftlerin Sayısı";
            this.btnOrnekUc.UseVisualStyleBackColor = true;
            this.btnOrnekUc.Click += new System.EventHandler(this.btnOrnekUc_Click);
            // 
            // btnOrnekıki
            // 
            this.btnOrnekıki.Location = new System.Drawing.Point(19, 83);
            this.btnOrnekıki.Name = "btnOrnekıki";
            this.btnOrnekıki.Size = new System.Drawing.Size(352, 67);
            this.btnOrnekıki.TabIndex = 7;
            this.btnOrnekıki.Text = "En Büyüğü Göster";
            this.btnOrnekıki.UseVisualStyleBackColor = true;
            this.btnOrnekıki.Click += new System.EventHandler(this.btnOrnekıki_Click);
            // 
            // btnOrnekBir
            // 
            this.btnOrnekBir.Location = new System.Drawing.Point(19, 10);
            this.btnOrnekBir.Name = "btnOrnekBir";
            this.btnOrnekBir.Size = new System.Drawing.Size(352, 67);
            this.btnOrnekBir.TabIndex = 8;
            this.btnOrnekBir.Text = "Takımları Listeye Ekle";
            this.btnOrnekBir.UseVisualStyleBackColor = true;
            this.btnOrnekBir.Click += new System.EventHandler(this.btnOrnekBir_Click);
            // 
            // txtGirisAlani
            // 
            this.txtGirisAlani.Location = new System.Drawing.Point(19, 452);
            this.txtGirisAlani.Name = "txtGirisAlani";
            this.txtGirisAlani.Size = new System.Drawing.Size(352, 30);
            this.txtGirisAlani.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 568);
            this.Controls.Add(this.txtGirisAlani);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnOrnekYedi);
            this.Controls.Add(this.btnOrnekAlti);
            this.Controls.Add(this.btnOrnekDort);
            this.Controls.Add(this.btnOrnekBes);
            this.Controls.Add(this.btnOrnekUc);
            this.Controls.Add(this.btnOrnekıki);
            this.Controls.Add(this.btnOrnekBir);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnOrnekYedi;
        private System.Windows.Forms.Button btnOrnekAlti;
        private System.Windows.Forms.Button btnOrnekDort;
        private System.Windows.Forms.Button btnOrnekBes;
        private System.Windows.Forms.Button btnOrnekUc;
        private System.Windows.Forms.Button btnOrnekıki;
        private System.Windows.Forms.Button btnOrnekBir;
        private System.Windows.Forms.TextBox txtGirisAlani;
    }
}