namespace ForLoop
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnOrnekıki = new System.Windows.Forms.Button();
            this.btnOrnekUc = new System.Windows.Forms.Button();
            this.btnOrnekDort = new System.Windows.Forms.Button();
            this.btnOrnekBes = new System.Windows.Forms.Button();
            this.btnOrnekAlti = new System.Windows.Forms.Button();
            this.btnOrnekYedi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrnekBir
            // 
            this.btnOrnekBir.Location = new System.Drawing.Point(12, 12);
            this.btnOrnekBir.Name = "btnOrnekBir";
            this.btnOrnekBir.Size = new System.Drawing.Size(352, 67);
            this.btnOrnekBir.TabIndex = 0;
            this.btnOrnekBir.Text = "1 - 1000";
            this.btnOrnekBir.UseVisualStyleBackColor = true;
            this.btnOrnekBir.Click += new System.EventHandler(this.btnOrnekBir_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(387, 14);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(318, 504);
            this.listBox1.TabIndex = 1;
            // 
            // btnOrnekıki
            // 
            this.btnOrnekıki.Location = new System.Drawing.Point(12, 85);
            this.btnOrnekıki.Name = "btnOrnekıki";
            this.btnOrnekıki.Size = new System.Drawing.Size(352, 67);
            this.btnOrnekıki.TabIndex = 0;
            this.btnOrnekıki.Text = "1000 - 1";
            this.btnOrnekıki.UseVisualStyleBackColor = true;
            this.btnOrnekıki.Click += new System.EventHandler(this.btnOrnekıki_Click);
            // 
            // btnOrnekUc
            // 
            this.btnOrnekUc.Location = new System.Drawing.Point(12, 158);
            this.btnOrnekUc.Name = "btnOrnekUc";
            this.btnOrnekUc.Size = new System.Drawing.Size(352, 67);
            this.btnOrnekUc.TabIndex = 0;
            this.btnOrnekUc.Text = "1 - 1000 Çift Sayılar";
            this.btnOrnekUc.UseVisualStyleBackColor = true;
            this.btnOrnekUc.Click += new System.EventHandler(this.btnOrnekUc_Click);
            // 
            // btnOrnekDort
            // 
            this.btnOrnekDort.Location = new System.Drawing.Point(12, 231);
            this.btnOrnekDort.Name = "btnOrnekDort";
            this.btnOrnekDort.Size = new System.Drawing.Size(352, 67);
            this.btnOrnekDort.TabIndex = 0;
            this.btnOrnekDort.Text = "A-Z\'ye Alfabe";
            this.btnOrnekDort.UseVisualStyleBackColor = true;
            this.btnOrnekDort.Click += new System.EventHandler(this.btnOrnekDort_Click);
            // 
            // btnOrnekBes
            // 
            this.btnOrnekBes.Location = new System.Drawing.Point(12, 306);
            this.btnOrnekBes.Name = "btnOrnekBes";
            this.btnOrnekBes.Size = new System.Drawing.Size(352, 67);
            this.btnOrnekBes.TabIndex = 0;
            this.btnOrnekBes.Text = "1 - 100 Toplamı";
            this.btnOrnekBes.UseVisualStyleBackColor = true;
            this.btnOrnekBes.Click += new System.EventHandler(this.btnOrnekBes_Click);
            // 
            // btnOrnekAlti
            // 
            this.btnOrnekAlti.Location = new System.Drawing.Point(12, 379);
            this.btnOrnekAlti.Name = "btnOrnekAlti";
            this.btnOrnekAlti.Size = new System.Drawing.Size(352, 67);
            this.btnOrnekAlti.TabIndex = 0;
            this.btnOrnekAlti.Text = "İşlem Yap";
            this.btnOrnekAlti.UseVisualStyleBackColor = true;
            this.btnOrnekAlti.Click += new System.EventHandler(this.btnOrnekAlti_Click);
            // 
            // btnOrnekYedi
            // 
            this.btnOrnekYedi.Location = new System.Drawing.Point(12, 452);
            this.btnOrnekYedi.Name = "btnOrnekYedi";
            this.btnOrnekYedi.Size = new System.Drawing.Size(352, 67);
            this.btnOrnekYedi.TabIndex = 0;
            this.btnOrnekYedi.Text = "Yılları ListBox\'a Ekle";
            this.btnOrnekYedi.UseVisualStyleBackColor = true;
            this.btnOrnekYedi.Click += new System.EventHandler(this.btnOrnekYedi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 537);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrnekBir;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnOrnekıki;
        private System.Windows.Forms.Button btnOrnekUc;
        private System.Windows.Forms.Button btnOrnekDort;
        private System.Windows.Forms.Button btnOrnekBes;
        private System.Windows.Forms.Button btnOrnekAlti;
        private System.Windows.Forms.Button btnOrnekYedi;
    }
}

