namespace DoWhileLoop
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnOrnekBir
            // 
            this.btnOrnekBir.Location = new System.Drawing.Point(7, 19);
            this.btnOrnekBir.Name = "btnOrnekBir";
            this.btnOrnekBir.Size = new System.Drawing.Size(357, 74);
            this.btnOrnekBir.TabIndex = 0;
            this.btnOrnekBir.Text = "WHILE";
            this.btnOrnekBir.UseVisualStyleBackColor = true;
            this.btnOrnekBir.Click += new System.EventHandler(this.btnOrnekBir_Click);
            // 
            // btnOrnekIki
            // 
            this.btnOrnekIki.Location = new System.Drawing.Point(7, 109);
            this.btnOrnekIki.Name = "btnOrnekIki";
            this.btnOrnekIki.Size = new System.Drawing.Size(357, 74);
            this.btnOrnekIki.TabIndex = 0;
            this.btnOrnekIki.Text = "DO WHILE";
            this.btnOrnekIki.UseVisualStyleBackColor = true;
            this.btnOrnekIki.Click += new System.EventHandler(this.btnOrnekIki_Click);
            // 
            // btnOrnekUc
            // 
            this.btnOrnekUc.Location = new System.Drawing.Point(7, 198);
            this.btnOrnekUc.Name = "btnOrnekUc";
            this.btnOrnekUc.Size = new System.Drawing.Size(357, 74);
            this.btnOrnekUc.TabIndex = 0;
            this.btnOrnekUc.Text = "WHILE - 2";
            this.btnOrnekUc.UseVisualStyleBackColor = true;
            this.btnOrnekUc.Click += new System.EventHandler(this.btnOrnekUc_Click);
            // 
            // btnOrnekDort
            // 
            this.btnOrnekDort.Location = new System.Drawing.Point(7, 291);
            this.btnOrnekDort.Name = "btnOrnekDort";
            this.btnOrnekDort.Size = new System.Drawing.Size(357, 74);
            this.btnOrnekDort.TabIndex = 0;
            this.btnOrnekDort.Text = "DO WHILE - 2";
            this.btnOrnekDort.UseVisualStyleBackColor = true;
            this.btnOrnekDort.Click += new System.EventHandler(this.btnOrnekDort_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(384, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(295, 329);
            this.listBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 383);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnOrnekDort);
            this.Controls.Add(this.btnOrnekUc);
            this.Controls.Add(this.btnOrnekIki);
            this.Controls.Add(this.btnOrnekBir);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrnekBir;
        private System.Windows.Forms.Button btnOrnekIki;
        private System.Windows.Forms.Button btnOrnekUc;
        private System.Windows.Forms.Button btnOrnekDort;
        private System.Windows.Forms.ListBox listBox1;
    }
}

