namespace ArrayListClass
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
            this.btnElemanEkle = new System.Windows.Forms.Button();
            this.btnMetotlar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnElemanEkle
            // 
            this.btnElemanEkle.Location = new System.Drawing.Point(14, 16);
            this.btnElemanEkle.Name = "btnElemanEkle";
            this.btnElemanEkle.Size = new System.Drawing.Size(312, 69);
            this.btnElemanEkle.TabIndex = 0;
            this.btnElemanEkle.Text = "Eleman Ekle";
            this.btnElemanEkle.UseVisualStyleBackColor = true;
            this.btnElemanEkle.Click += new System.EventHandler(this.btnElemanEkle_Click);
            // 
            // btnMetotlar
            // 
            this.btnMetotlar.Location = new System.Drawing.Point(14, 91);
            this.btnMetotlar.Name = "btnMetotlar";
            this.btnMetotlar.Size = new System.Drawing.Size(312, 69);
            this.btnMetotlar.TabIndex = 0;
            this.btnMetotlar.Text = "Metotları Göster";
            this.btnMetotlar.UseVisualStyleBackColor = true;
            this.btnMetotlar.Click += new System.EventHandler(this.btnMetotlar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 186);
            this.Controls.Add(this.btnMetotlar);
            this.Controls.Add(this.btnElemanEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnElemanEkle;
        private System.Windows.Forms.Button btnMetotlar;
    }
}

