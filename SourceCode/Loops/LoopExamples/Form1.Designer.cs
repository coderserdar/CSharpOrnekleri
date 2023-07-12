namespace LoopExamples
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
            this.btnOrnek1 = new System.Windows.Forms.Button();
            this.btnOrnekIki = new System.Windows.Forms.Button();
            this.btnOrnekUc = new System.Windows.Forms.Button();
            this.btnOrnekDort = new System.Windows.Forms.Button();
            this.btnOrnekBes = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblYaziAlani = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOrnek1
            // 
            this.btnOrnek1.Location = new System.Drawing.Point(13, 14);
            this.btnOrnek1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOrnek1.Name = "btnOrnek1";
            this.btnOrnek1.Size = new System.Drawing.Size(374, 54);
            this.btnOrnek1.TabIndex = 0;
            this.btnOrnek1.Text = "YAN YANA X";
            this.btnOrnek1.UseVisualStyleBackColor = true;
            this.btnOrnek1.Click += new System.EventHandler(this.btnOrnek1_Click);
            // 
            // btnOrnekIki
            // 
            this.btnOrnekIki.Location = new System.Drawing.Point(13, 73);
            this.btnOrnekIki.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOrnekIki.Name = "btnOrnekIki";
            this.btnOrnekIki.Size = new System.Drawing.Size(374, 54);
            this.btnOrnekIki.TabIndex = 0;
            this.btnOrnekIki.Text = "ALT ALTA X";
            this.btnOrnekIki.UseVisualStyleBackColor = true;
            this.btnOrnekIki.Click += new System.EventHandler(this.btnOrnekIki_Click);
            // 
            // btnOrnekUc
            // 
            this.btnOrnekUc.Location = new System.Drawing.Point(13, 137);
            this.btnOrnekUc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOrnekUc.Name = "btnOrnekUc";
            this.btnOrnekUc.Size = new System.Drawing.Size(374, 54);
            this.btnOrnekUc.TabIndex = 0;
            this.btnOrnekUc.Text = "X İLE KARE";
            this.btnOrnekUc.UseVisualStyleBackColor = true;
            this.btnOrnekUc.Click += new System.EventHandler(this.btnOrnekUc_Click);
            // 
            // btnOrnekDort
            // 
            this.btnOrnekDort.Location = new System.Drawing.Point(13, 201);
            this.btnOrnekDort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOrnekDort.Name = "btnOrnekDort";
            this.btnOrnekDort.Size = new System.Drawing.Size(374, 54);
            this.btnOrnekDort.TabIndex = 0;
            this.btnOrnekDort.Text = "X İLE DİK KENAR ÜÇGEN";
            this.btnOrnekDort.UseVisualStyleBackColor = true;
            this.btnOrnekDort.Click += new System.EventHandler(this.btnOrnekDort_Click);
            // 
            // btnOrnekBes
            // 
            this.btnOrnekBes.Location = new System.Drawing.Point(13, 265);
            this.btnOrnekBes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOrnekBes.Name = "btnOrnekBes";
            this.btnOrnekBes.Size = new System.Drawing.Size(374, 54);
            this.btnOrnekBes.TabIndex = 0;
            this.btnOrnekBes.Text = "ÇARPIM TABLOSU";
            this.btnOrnekBes.UseVisualStyleBackColor = true;
            this.btnOrnekBes.Click += new System.EventHandler(this.btnOrnekBes_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(394, 17);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(270, 429);
            this.listBox1.TabIndex = 1;
            // 
            // lblYaziAlani
            // 
            this.lblYaziAlani.Location = new System.Drawing.Point(12, 335);
            this.lblYaziAlani.Name = "lblYaziAlani";
            this.lblYaziAlani.Size = new System.Drawing.Size(375, 111);
            this.lblYaziAlani.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 466);
            this.Controls.Add(this.lblYaziAlani);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnOrnekBes);
            this.Controls.Add(this.btnOrnekDort);
            this.Controls.Add(this.btnOrnekUc);
            this.Controls.Add(this.btnOrnekIki);
            this.Controls.Add(this.btnOrnek1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrnek1;
        private System.Windows.Forms.Button btnOrnekIki;
        private System.Windows.Forms.Button btnOrnekUc;
        private System.Windows.Forms.Button btnOrnekDort;
        private System.Windows.Forms.Button btnOrnekBes;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblYaziAlani;
    }
}

