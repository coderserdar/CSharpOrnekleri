namespace ParametreliMetot
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnOrnekBir = new System.Windows.Forms.Button();
            this.btnOrnekIki = new System.Windows.Forms.Button();
            this.btnOrnekUc = new System.Windows.Forms.Button();
            this.btnOrnekDort = new System.Windows.Forms.Button();
            this.btnOrnekBes = new System.Windows.Forms.Button();
            this.btnOrnek6 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 22);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 30);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(232, 22);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 30);
            this.textBox2.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(466, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(261, 454);
            this.listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 25;
            this.listBox2.Location = new System.Drawing.Point(733, 22);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(261, 454);
            this.listBox2.TabIndex = 1;
            // 
            // btnOrnekBir
            // 
            this.btnOrnekBir.Location = new System.Drawing.Point(15, 60);
            this.btnOrnekBir.Name = "btnOrnekBir";
            this.btnOrnekBir.Size = new System.Drawing.Size(426, 59);
            this.btnOrnekBir.TabIndex = 2;
            this.btnOrnekBir.Text = "Kadar Saydır";
            this.btnOrnekBir.UseVisualStyleBackColor = true;
            this.btnOrnekBir.Click += new System.EventHandler(this.btnOrnekBir_Click);
            // 
            // btnOrnekIki
            // 
            this.btnOrnekIki.Location = new System.Drawing.Point(15, 125);
            this.btnOrnekIki.Name = "btnOrnekIki";
            this.btnOrnekIki.Size = new System.Drawing.Size(426, 59);
            this.btnOrnekIki.TabIndex = 2;
            this.btnOrnekIki.Text = "Toplamın Küpü";
            this.btnOrnekIki.UseVisualStyleBackColor = true;
            this.btnOrnekIki.Click += new System.EventHandler(this.btnOrnekIki_Click);
            // 
            // btnOrnekUc
            // 
            this.btnOrnekUc.Location = new System.Drawing.Point(12, 188);
            this.btnOrnekUc.Name = "btnOrnekUc";
            this.btnOrnekUc.Size = new System.Drawing.Size(426, 59);
            this.btnOrnekUc.TabIndex = 2;
            this.btnOrnekUc.Text = "Son 3 Harfi Kırp";
            this.btnOrnekUc.UseVisualStyleBackColor = true;
            this.btnOrnekUc.Click += new System.EventHandler(this.btnOrnekUc_Click);
            // 
            // btnOrnekDort
            // 
            this.btnOrnekDort.Location = new System.Drawing.Point(12, 253);
            this.btnOrnekDort.Name = "btnOrnekDort";
            this.btnOrnekDort.Size = new System.Drawing.Size(426, 59);
            this.btnOrnekDort.TabIndex = 2;
            this.btnOrnekDort.Text = "Girilen Mailleri Ayrıştıralım";
            this.btnOrnekDort.UseVisualStyleBackColor = true;
            this.btnOrnekDort.Click += new System.EventHandler(this.btnOrnekDort_Click);
            // 
            // btnOrnekBes
            // 
            this.btnOrnekBes.Location = new System.Drawing.Point(15, 317);
            this.btnOrnekBes.Name = "btnOrnekBes";
            this.btnOrnekBes.Size = new System.Drawing.Size(426, 59);
            this.btnOrnekBes.TabIndex = 2;
            this.btnOrnekBes.Text = "Seslileri Göster";
            this.btnOrnekBes.UseVisualStyleBackColor = true;
            this.btnOrnekBes.Click += new System.EventHandler(this.btnOrnekBes_Click);
            // 
            // btnOrnek6
            // 
            this.btnOrnek6.Location = new System.Drawing.Point(15, 424);
            this.btnOrnek6.Name = "btnOrnek6";
            this.btnOrnek6.Size = new System.Drawing.Size(426, 59);
            this.btnOrnek6.TabIndex = 2;
            this.btnOrnek6.Text = "Arka Plan Değiştir";
            this.btnOrnek6.UseVisualStyleBackColor = true;
            this.btnOrnek6.Click += new System.EventHandler(this.btnOrnek6_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Black",
            "DarkBlue",
            "Yellow",
            "White",
            "Maroon",
            "Green",
            "Lime",
            "Tan"});
            this.comboBox1.Location = new System.Drawing.Point(18, 383);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(422, 33);
            this.comboBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 500);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnOrnek6);
            this.Controls.Add(this.btnOrnekBes);
            this.Controls.Add(this.btnOrnekDort);
            this.Controls.Add(this.btnOrnekUc);
            this.Controls.Add(this.btnOrnekIki);
            this.Controls.Add(this.btnOrnekBir);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnOrnekBir;
        private System.Windows.Forms.Button btnOrnekIki;
        private System.Windows.Forms.Button btnOrnekUc;
        private System.Windows.Forms.Button btnOrnekDort;
        private System.Windows.Forms.Button btnOrnekBes;
        private System.Windows.Forms.Button btnOrnek6;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

