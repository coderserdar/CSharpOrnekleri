namespace IfElse
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
            this.btnSatis = new System.Windows.Forms.Button();
            this.btnMarket = new System.Windows.Forms.Button();
            this.btnNot = new System.Windows.Forms.Button();
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtBirinciDeger = new System.Windows.Forms.TextBox();
            this.txtIkinciDeger = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSatis
            // 
            this.btnSatis.Location = new System.Drawing.Point(20, 369);
            this.btnSatis.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(637, 73);
            this.btnSatis.TabIndex = 3;
            this.btnSatis.Text = "Satış Kontrolü";
            this.btnSatis.UseVisualStyleBackColor = true;
            this.btnSatis.Click += new System.EventHandler(this.btnSatis_Click);
            // 
            // btnMarket
            // 
            this.btnMarket.Location = new System.Drawing.Point(20, 286);
            this.btnMarket.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnMarket.Name = "btnMarket";
            this.btnMarket.Size = new System.Drawing.Size(637, 73);
            this.btnMarket.TabIndex = 4;
            this.btnMarket.Text = "Market Kontrolü";
            this.btnMarket.UseVisualStyleBackColor = true;
            this.btnMarket.Click += new System.EventHandler(this.btnMarket_Click);
            // 
            // btnNot
            // 
            this.btnNot.Location = new System.Drawing.Point(20, 203);
            this.btnNot.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnNot.Name = "btnNot";
            this.btnNot.Size = new System.Drawing.Size(637, 73);
            this.btnNot.TabIndex = 5;
            this.btnNot.Text = "Not Kontrolü";
            this.btnNot.UseVisualStyleBackColor = true;
            this.btnNot.Click += new System.EventHandler(this.btnNot_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(20, 120);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(637, 73);
            this.btnGiris.TabIndex = 6;
            this.btnGiris.Text = "Giriş Kontrolü";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtBirinciDeger
            // 
            this.txtBirinciDeger.Location = new System.Drawing.Point(16, 26);
            this.txtBirinciDeger.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtBirinciDeger.Name = "txtBirinciDeger";
            this.txtBirinciDeger.Size = new System.Drawing.Size(638, 32);
            this.txtBirinciDeger.TabIndex = 2;
            // 
            // txtIkinciDeger
            // 
            this.txtIkinciDeger.Location = new System.Drawing.Point(16, 74);
            this.txtIkinciDeger.Margin = new System.Windows.Forms.Padding(8);
            this.txtIkinciDeger.Name = "txtIkinciDeger";
            this.txtIkinciDeger.Size = new System.Drawing.Size(638, 32);
            this.txtIkinciDeger.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 477);
            this.Controls.Add(this.btnSatis);
            this.Controls.Add(this.btnMarket);
            this.Controls.Add(this.btnNot);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtIkinciDeger);
            this.Controls.Add(this.txtBirinciDeger);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSatis;
        private System.Windows.Forms.Button btnMarket;
        private System.Windows.Forms.Button btnNot;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txtBirinciDeger;
        private System.Windows.Forms.TextBox txtIkinciDeger;
    }
}