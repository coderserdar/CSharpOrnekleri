namespace DateTimeMetotlar
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnDateTime = new System.Windows.Forms.Button();
            this.btnTimeSpan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // btnDateTime
            // 
            this.btnDateTime.Location = new System.Drawing.Point(8, 39);
            this.btnDateTime.Name = "btnDateTime";
            this.btnDateTime.Size = new System.Drawing.Size(357, 66);
            this.btnDateTime.TabIndex = 1;
            this.btnDateTime.Text = "DateTime";
            this.btnDateTime.UseVisualStyleBackColor = true;
            this.btnDateTime.Click += new System.EventHandler(this.btnDateTime_Click);
            // 
            // btnTimeSpan
            // 
            this.btnTimeSpan.Location = new System.Drawing.Point(8, 111);
            this.btnTimeSpan.Name = "btnTimeSpan";
            this.btnTimeSpan.Size = new System.Drawing.Size(357, 66);
            this.btnTimeSpan.TabIndex = 1;
            this.btnTimeSpan.Text = "TimeSpan";
            this.btnTimeSpan.UseVisualStyleBackColor = true;
            this.btnTimeSpan.Click += new System.EventHandler(this.btnTimeSpan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 191);
            this.Controls.Add(this.btnTimeSpan);
            this.Controls.Add(this.btnDateTime);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDateTime;
        private System.Windows.Forms.Button btnTimeSpan;
    }
}

