namespace Arrays
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
            this.btnSonEleman = new System.Windows.Forms.Button();
            this.btnRastgele = new System.Windows.Forms.Button();
            this.btnListBox = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSonEleman
            // 
            this.btnSonEleman.Location = new System.Drawing.Point(22, 19);
            this.btnSonEleman.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSonEleman.Name = "btnSonEleman";
            this.btnSonEleman.Size = new System.Drawing.Size(592, 69);
            this.btnSonEleman.TabIndex = 0;
            this.btnSonEleman.Text = "Son Elemanı Göster";
            this.btnSonEleman.UseVisualStyleBackColor = true;
            this.btnSonEleman.Click += new System.EventHandler(this.btnSonEleman_Click);
            // 
            // btnRastgele
            // 
            this.btnRastgele.Location = new System.Drawing.Point(20, 97);
            this.btnRastgele.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRastgele.Name = "btnRastgele";
            this.btnRastgele.Size = new System.Drawing.Size(592, 69);
            this.btnRastgele.TabIndex = 0;
            this.btnRastgele.Text = "Rastgele Eleman Göster";
            this.btnRastgele.UseVisualStyleBackColor = true;
            this.btnRastgele.Click += new System.EventHandler(this.btnRastgele_Click);
            // 
            // btnListBox
            // 
            this.btnListBox.Location = new System.Drawing.Point(20, 175);
            this.btnListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListBox.Name = "btnListBox";
            this.btnListBox.Size = new System.Drawing.Size(592, 69);
            this.btnListBox.TabIndex = 0;
            this.btnListBox.Text = "Elemanları ListBox\'a at";
            this.btnListBox.UseVisualStyleBackColor = true;
            this.btnListBox.Click += new System.EventHandler(this.btnListBox_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(22, 267);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(586, 154);
            this.listBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 433);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnListBox);
            this.Controls.Add(this.btnRastgele);
            this.Controls.Add(this.btnSonEleman);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSonEleman;
        private System.Windows.Forms.Button btnRastgele;
        private System.Windows.Forms.Button btnListBox;
        private System.Windows.Forms.ListBox listBox1;
    }
}

