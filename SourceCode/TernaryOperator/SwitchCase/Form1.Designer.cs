namespace SwitchCase
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
            this.txtBirinciDeger = new System.Windows.Forms.TextBox();
            this.txtIkinciDeger = new System.Windows.Forms.TextBox();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.btnKullaniciGirisi = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.btnYedi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBirinciDeger
            // 
            this.txtBirinciDeger.Location = new System.Drawing.Point(13, 14);
            this.txtBirinciDeger.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBirinciDeger.Name = "txtBirinciDeger";
            this.txtBirinciDeger.Size = new System.Drawing.Size(405, 30);
            this.txtBirinciDeger.TabIndex = 0;
            // 
            // txtIkinciDeger
            // 
            this.txtIkinciDeger.Location = new System.Drawing.Point(13, 54);
            this.txtIkinciDeger.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIkinciDeger.Name = "txtIkinciDeger";
            this.txtIkinciDeger.Size = new System.Drawing.Size(405, 30);
            this.txtIkinciDeger.TabIndex = 0;
            // 
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(13, 101);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(404, 48);
            this.btnOnayla.TabIndex = 1;
            this.btnOnayla.Text = "ONAYLA";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // btnKullaniciGirisi
            // 
            this.btnKullaniciGirisi.Location = new System.Drawing.Point(13, 155);
            this.btnKullaniciGirisi.Name = "btnKullaniciGirisi";
            this.btnKullaniciGirisi.Size = new System.Drawing.Size(404, 48);
            this.btnKullaniciGirisi.TabIndex = 1;
            this.btnKullaniciGirisi.Text = "KULLANICI GİRİŞİ";
            this.btnKullaniciGirisi.UseVisualStyleBackColor = true;
            this.btnKullaniciGirisi.Click += new System.EventHandler(this.btnKullaniciGirisi_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(12, 207);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(404, 48);
            this.btnSwitch.TabIndex = 1;
            this.btnSwitch.Text = "İÇ İÇE SWİTCH";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // btnYedi
            // 
            this.btnYedi.Location = new System.Drawing.Point(12, 261);
            this.btnYedi.Name = "btnYedi";
            this.btnYedi.Size = new System.Drawing.Size(404, 48);
            this.btnYedi.TabIndex = 1;
            this.btnYedi.Text = "C# 7 ile Gelen Özellik";
            this.btnYedi.UseVisualStyleBackColor = true;
            this.btnYedi.Click += new System.EventHandler(this.btnYedi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 336);
            this.Controls.Add(this.btnYedi);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.btnKullaniciGirisi);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.txtIkinciDeger);
            this.Controls.Add(this.txtBirinciDeger);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBirinciDeger;
        private System.Windows.Forms.TextBox txtIkinciDeger;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button btnKullaniciGirisi;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Button btnYedi;
    }
}

