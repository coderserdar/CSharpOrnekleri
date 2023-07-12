namespace ArraySinifiMetotlari
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
            this.txtGirisAlani = new System.Windows.Forms.TextBox();
            this.btnOrnekBir = new System.Windows.Forms.Button();
            this.btnOrnekIki = new System.Windows.Forms.Button();
            this.btnOrnekUc = new System.Windows.Forms.Button();
            this.btnOrnekBes = new System.Windows.Forms.Button();
            this.btnOrnekAlti = new System.Windows.Forms.Button();
            this.btnOrnekYedi = new System.Windows.Forms.Button();
            this.btnOrnekDort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGirisAlani
            // 
            this.txtGirisAlani.Location = new System.Drawing.Point(12, 12);
            this.txtGirisAlani.Name = "txtGirisAlani";
            this.txtGirisAlani.Size = new System.Drawing.Size(434, 30);
            this.txtGirisAlani.TabIndex = 0;
            // 
            // btnOrnekBir
            // 
            this.btnOrnekBir.Location = new System.Drawing.Point(14, 57);
            this.btnOrnekBir.Name = "btnOrnekBir";
            this.btnOrnekBir.Size = new System.Drawing.Size(431, 49);
            this.btnOrnekBir.TabIndex = 1;
            this.btnOrnekBir.Text = "Array Clear()";
            this.btnOrnekBir.UseVisualStyleBackColor = true;
            this.btnOrnekBir.Click += new System.EventHandler(this.btnOrnekBir_Click);
            // 
            // btnOrnekIki
            // 
            this.btnOrnekIki.Location = new System.Drawing.Point(14, 110);
            this.btnOrnekIki.Name = "btnOrnekIki";
            this.btnOrnekIki.Size = new System.Drawing.Size(431, 49);
            this.btnOrnekIki.TabIndex = 1;
            this.btnOrnekIki.Text = "Array Copy()";
            this.btnOrnekIki.UseVisualStyleBackColor = true;
            this.btnOrnekIki.Click += new System.EventHandler(this.btnOrnekIki_Click);
            // 
            // btnOrnekUc
            // 
            this.btnOrnekUc.Location = new System.Drawing.Point(14, 165);
            this.btnOrnekUc.Name = "btnOrnekUc";
            this.btnOrnekUc.Size = new System.Drawing.Size(431, 49);
            this.btnOrnekUc.TabIndex = 1;
            this.btnOrnekUc.Text = "Array IndexOf()";
            this.btnOrnekUc.UseVisualStyleBackColor = true;
            this.btnOrnekUc.Click += new System.EventHandler(this.btnOrnekUc_Click);
            // 
            // btnOrnekBes
            // 
            this.btnOrnekBes.Location = new System.Drawing.Point(14, 277);
            this.btnOrnekBes.Name = "btnOrnekBes";
            this.btnOrnekBes.Size = new System.Drawing.Size(431, 49);
            this.btnOrnekBes.TabIndex = 1;
            this.btnOrnekBes.Text = "Array Resize()";
            this.btnOrnekBes.UseVisualStyleBackColor = true;
            this.btnOrnekBes.Click += new System.EventHandler(this.btnOrnekBes_Click);
            // 
            // btnOrnekAlti
            // 
            this.btnOrnekAlti.Location = new System.Drawing.Point(14, 332);
            this.btnOrnekAlti.Name = "btnOrnekAlti";
            this.btnOrnekAlti.Size = new System.Drawing.Size(431, 49);
            this.btnOrnekAlti.TabIndex = 1;
            this.btnOrnekAlti.Text = "Array Sort()";
            this.btnOrnekAlti.UseVisualStyleBackColor = true;
            this.btnOrnekAlti.Click += new System.EventHandler(this.btnOrnekAlti_Click);
            // 
            // btnOrnekYedi
            // 
            this.btnOrnekYedi.Location = new System.Drawing.Point(15, 387);
            this.btnOrnekYedi.Name = "btnOrnekYedi";
            this.btnOrnekYedi.Size = new System.Drawing.Size(431, 49);
            this.btnOrnekYedi.TabIndex = 1;
            this.btnOrnekYedi.Text = "Array Reverse()";
            this.btnOrnekYedi.UseVisualStyleBackColor = true;
            this.btnOrnekYedi.Click += new System.EventHandler(this.btnOrnekYedi_Click);
            // 
            // btnOrnekDort
            // 
            this.btnOrnekDort.Location = new System.Drawing.Point(14, 222);
            this.btnOrnekDort.Name = "btnOrnekDort";
            this.btnOrnekDort.Size = new System.Drawing.Size(431, 49);
            this.btnOrnekDort.TabIndex = 1;
            this.btnOrnekDort.Text = "Array LastIndexOf()";
            this.btnOrnekDort.UseVisualStyleBackColor = true;
            this.btnOrnekDort.Click += new System.EventHandler(this.btnOrnekDort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 449);
            this.Controls.Add(this.btnOrnekYedi);
            this.Controls.Add(this.btnOrnekAlti);
            this.Controls.Add(this.btnOrnekBes);
            this.Controls.Add(this.btnOrnekDort);
            this.Controls.Add(this.btnOrnekUc);
            this.Controls.Add(this.btnOrnekIki);
            this.Controls.Add(this.btnOrnekBir);
            this.Controls.Add(this.txtGirisAlani);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGirisAlani;
        private System.Windows.Forms.Button btnOrnekBir;
        private System.Windows.Forms.Button btnOrnekIki;
        private System.Windows.Forms.Button btnOrnekUc;
        private System.Windows.Forms.Button btnOrnekBes;
        private System.Windows.Forms.Button btnOrnekAlti;
        private System.Windows.Forms.Button btnOrnekYedi;
        private System.Windows.Forms.Button btnOrnekDort;
    }
}

