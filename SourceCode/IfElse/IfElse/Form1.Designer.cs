namespace IfElse
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
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnNot = new System.Windows.Forms.Button();
            this.btnCiftTek = new System.Windows.Forms.Button();
            this.btnDeger = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGirisAlani
            // 
            this.txtGirisAlani.Location = new System.Drawing.Point(14, 24);
            this.txtGirisAlani.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtGirisAlani.Name = "txtGirisAlani";
            this.txtGirisAlani.Size = new System.Drawing.Size(394, 32);
            this.txtGirisAlani.TabIndex = 0;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(16, 82);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(392, 45);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "Admin Kontrolü";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnNot
            // 
            this.btnNot.Location = new System.Drawing.Point(16, 133);
            this.btnNot.Name = "btnNot";
            this.btnNot.Size = new System.Drawing.Size(392, 45);
            this.btnNot.TabIndex = 1;
            this.btnNot.Text = "Not Kontrolü";
            this.btnNot.UseVisualStyleBackColor = true;
            this.btnNot.Click += new System.EventHandler(this.btnNot_Click);
            // 
            // btnCiftTek
            // 
            this.btnCiftTek.Location = new System.Drawing.Point(16, 184);
            this.btnCiftTek.Name = "btnCiftTek";
            this.btnCiftTek.Size = new System.Drawing.Size(392, 45);
            this.btnCiftTek.TabIndex = 1;
            this.btnCiftTek.Text = "Çift-Tek Kontrolü";
            this.btnCiftTek.UseVisualStyleBackColor = true;
            this.btnCiftTek.Click += new System.EventHandler(this.btnCiftTek_Click);
            // 
            // btnDeger
            // 
            this.btnDeger.Location = new System.Drawing.Point(16, 235);
            this.btnDeger.Name = "btnDeger";
            this.btnDeger.Size = new System.Drawing.Size(392, 45);
            this.btnDeger.TabIndex = 1;
            this.btnDeger.Text = "Değer Kontrolü";
            this.btnDeger.UseVisualStyleBackColor = true;
            this.btnDeger.Click += new System.EventHandler(this.btnDeger_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 304);
            this.Controls.Add(this.btnDeger);
            this.Controls.Add(this.btnCiftTek);
            this.Controls.Add(this.btnNot);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.txtGirisAlani);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGirisAlani;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnNot;
        private System.Windows.Forms.Button btnCiftTek;
        private System.Windows.Forms.Button btnDeger;
    }
}

