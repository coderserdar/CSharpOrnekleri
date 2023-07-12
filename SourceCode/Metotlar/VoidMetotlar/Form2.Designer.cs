namespace VoidMetotlar
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
            this.btnMetot = new System.Windows.Forms.Button();
            this.btnTamirci = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnMetot
            // 
            this.btnMetot.Location = new System.Drawing.Point(12, 12);
            this.btnMetot.Name = "btnMetot";
            this.btnMetot.Size = new System.Drawing.Size(245, 63);
            this.btnMetot.TabIndex = 0;
            this.btnMetot.Text = "Metotlu Döngü";
            this.btnMetot.UseVisualStyleBackColor = true;
            this.btnMetot.Click += new System.EventHandler(this.btnMetot_Click);
            // 
            // btnTamirci
            // 
            this.btnTamirci.Location = new System.Drawing.Point(12, 81);
            this.btnTamirci.Name = "btnTamirci";
            this.btnTamirci.Size = new System.Drawing.Size(245, 63);
            this.btnTamirci.TabIndex = 0;
            this.btnTamirci.Text = "Tamirci";
            this.btnTamirci.UseVisualStyleBackColor = true;
            this.btnTamirci.Click += new System.EventHandler(this.btnTamirci_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 150);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(245, 228);
            this.listBox1.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 410);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnTamirci);
            this.Controls.Add(this.btnMetot);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMetot;
        private System.Windows.Forms.Button btnTamirci;
        private System.Windows.Forms.ListBox listBox1;
    }
}