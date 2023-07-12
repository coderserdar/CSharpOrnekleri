namespace HorseRacing
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFinish = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnSifirla = new System.Windows.Forms.Button();
            this.pcbBirinciAt = new System.Windows.Forms.PictureBox();
            this.pcbIkinciAt = new System.Windows.Forms.PictureBox();
            this.pcbUcuncuAt = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblBilgilendirme = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBirinciAt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIkinciAt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUcuncuAt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1085, 22);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1085, 22);
            this.label2.TabIndex = 0;
            // 
            // lblFinish
            // 
            this.lblFinish.BackColor = System.Drawing.Color.White;
            this.lblFinish.Location = new System.Drawing.Point(1081, 0);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(23, 480);
            this.lblFinish.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1085, 22);
            this.label4.TabIndex = 0;
            // 
            // btnBaslat
            // 
            this.btnBaslat.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnBaslat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaslat.ForeColor = System.Drawing.Color.Snow;
            this.btnBaslat.Location = new System.Drawing.Point(566, 517);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(266, 45);
            this.btnBaslat.TabIndex = 2;
            this.btnBaslat.Text = "YARIŞI BAŞLAT";
            this.btnBaslat.UseVisualStyleBackColor = false;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // btnSifirla
            // 
            this.btnSifirla.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnSifirla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSifirla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifirla.ForeColor = System.Drawing.Color.Snow;
            this.btnSifirla.Location = new System.Drawing.Point(838, 517);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(266, 45);
            this.btnSifirla.TabIndex = 2;
            this.btnSifirla.Text = "YARIŞI SIFIRLA";
            this.btnSifirla.UseVisualStyleBackColor = false;
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // pcbBirinciAt
            // 
            this.pcbBirinciAt.Image = ((System.Drawing.Image)(resources.GetObject("pcbBirinciAt.Image")));
            this.pcbBirinciAt.Location = new System.Drawing.Point(4, 0);
            this.pcbBirinciAt.Name = "pcbBirinciAt";
            this.pcbBirinciAt.Size = new System.Drawing.Size(141, 127);
            this.pcbBirinciAt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBirinciAt.TabIndex = 3;
            this.pcbBirinciAt.TabStop = false;
            // 
            // pcbIkinciAt
            // 
            this.pcbIkinciAt.Image = ((System.Drawing.Image)(resources.GetObject("pcbIkinciAt.Image")));
            this.pcbIkinciAt.Location = new System.Drawing.Point(4, 158);
            this.pcbIkinciAt.Name = "pcbIkinciAt";
            this.pcbIkinciAt.Size = new System.Drawing.Size(141, 127);
            this.pcbIkinciAt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbIkinciAt.TabIndex = 3;
            this.pcbIkinciAt.TabStop = false;
            // 
            // pcbUcuncuAt
            // 
            this.pcbUcuncuAt.Image = ((System.Drawing.Image)(resources.GetObject("pcbUcuncuAt.Image")));
            this.pcbUcuncuAt.Location = new System.Drawing.Point(4, 328);
            this.pcbUcuncuAt.Name = "pcbUcuncuAt";
            this.pcbUcuncuAt.Size = new System.Drawing.Size(141, 127);
            this.pcbUcuncuAt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbUcuncuAt.TabIndex = 3;
            this.pcbUcuncuAt.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1125, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(68, 400);
            this.panel1.TabIndex = 4;
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblBilgilendirme
            // 
            this.lblBilgilendirme.AutoSize = true;
            this.lblBilgilendirme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBilgilendirme.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBilgilendirme.Location = new System.Drawing.Point(21, 501);
            this.lblBilgilendirme.Name = "lblBilgilendirme";
            this.lblBilgilendirme.Size = new System.Drawing.Size(0, 25);
            this.lblBilgilendirme.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1220, 574);
            this.Controls.Add(this.lblBilgilendirme);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pcbUcuncuAt);
            this.Controls.Add(this.pcbIkinciAt);
            this.Controls.Add(this.pcbBirinciAt);
            this.Controls.Add(this.btnSifirla);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pcbBirinciAt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIkinciAt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUcuncuAt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button btnSifirla;
        private System.Windows.Forms.PictureBox pcbBirinciAt;
        private System.Windows.Forms.PictureBox pcbIkinciAt;
        private System.Windows.Forms.PictureBox pcbUcuncuAt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblBilgilendirme;
    }
}

