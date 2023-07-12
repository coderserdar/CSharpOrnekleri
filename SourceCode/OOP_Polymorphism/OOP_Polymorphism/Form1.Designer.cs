namespace OOP_Polymorphism
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
            this.btnNokia = new System.Windows.Forms.Button();
            this.btnSamsung = new System.Windows.Forms.Button();
            this.btnIPhone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNokia
            // 
            this.btnNokia.Location = new System.Drawing.Point(14, 16);
            this.btnNokia.Name = "btnNokia";
            this.btnNokia.Size = new System.Drawing.Size(319, 62);
            this.btnNokia.TabIndex = 0;
            this.btnNokia.Text = "NOKİA";
            this.btnNokia.UseVisualStyleBackColor = true;
            this.btnNokia.Click += new System.EventHandler(this.btnNokia_Click);
            // 
            // btnSamsung
            // 
            this.btnSamsung.Location = new System.Drawing.Point(14, 84);
            this.btnSamsung.Name = "btnSamsung";
            this.btnSamsung.Size = new System.Drawing.Size(319, 62);
            this.btnSamsung.TabIndex = 0;
            this.btnSamsung.Text = "SAMSUNG";
            this.btnSamsung.UseVisualStyleBackColor = true;
            this.btnSamsung.Click += new System.EventHandler(this.btnSamsung_Click);
            // 
            // btnIPhone
            // 
            this.btnIPhone.Location = new System.Drawing.Point(14, 152);
            this.btnIPhone.Name = "btnIPhone";
            this.btnIPhone.Size = new System.Drawing.Size(319, 62);
            this.btnIPhone.TabIndex = 0;
            this.btnIPhone.Text = "iPhone";
            this.btnIPhone.UseVisualStyleBackColor = true;
            this.btnIPhone.Click += new System.EventHandler(this.btnIPhone_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 233);
            this.Controls.Add(this.btnIPhone);
            this.Controls.Add(this.btnSamsung);
            this.Controls.Add(this.btnNokia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNokia;
        private System.Windows.Forms.Button btnSamsung;
        private System.Windows.Forms.Button btnIPhone;
    }
}

