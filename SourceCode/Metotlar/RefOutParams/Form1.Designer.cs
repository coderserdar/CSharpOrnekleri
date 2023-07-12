namespace RefOutParams
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
            this.btnOut = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnOutIki = new System.Windows.Forms.Button();
            this.btnParams = new System.Windows.Forms.Button();
            this.btnRef = new System.Windows.Forms.Button();
            this.txtMailAdresleri = new System.Windows.Forms.TextBox();
            this.btnOut3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(24, 28);
            this.btnOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(414, 91);
            this.btnOut.TabIndex = 0;
            this.btnOut.Text = "OUT KEYWORD";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(459, 34);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(492, 704);
            this.listBox1.TabIndex = 1;
            // 
            // btnOutIki
            // 
            this.btnOutIki.Location = new System.Drawing.Point(24, 128);
            this.btnOutIki.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOutIki.Name = "btnOutIki";
            this.btnOutIki.Size = new System.Drawing.Size(414, 91);
            this.btnOutIki.TabIndex = 0;
            this.btnOutIki.Text = "OUT KEYWORD(2)";
            this.btnOutIki.UseVisualStyleBackColor = true;
            this.btnOutIki.Click += new System.EventHandler(this.btnOutIki_Click);
            // 
            // btnParams
            // 
            this.btnParams.Location = new System.Drawing.Point(24, 333);
            this.btnParams.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnParams.Name = "btnParams";
            this.btnParams.Size = new System.Drawing.Size(414, 91);
            this.btnParams.TabIndex = 0;
            this.btnParams.Text = "PARAMS KEYWORD";
            this.btnParams.UseVisualStyleBackColor = true;
            this.btnParams.Click += new System.EventHandler(this.btnParams_Click);
            // 
            // btnRef
            // 
            this.btnRef.Location = new System.Drawing.Point(20, 650);
            this.btnRef.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(414, 91);
            this.btnRef.TabIndex = 0;
            this.btnRef.Text = "REF KEYWORD";
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // txtMailAdresleri
            // 
            this.txtMailAdresleri.Location = new System.Drawing.Point(24, 444);
            this.txtMailAdresleri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMailAdresleri.Multiline = true;
            this.txtMailAdresleri.Name = "txtMailAdresleri";
            this.txtMailAdresleri.Size = new System.Drawing.Size(410, 181);
            this.txtMailAdresleri.TabIndex = 2;
            // 
            // btnOut3
            // 
            this.btnOut3.Location = new System.Drawing.Point(24, 229);
            this.btnOut3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOut3.Name = "btnOut3";
            this.btnOut3.Size = new System.Drawing.Size(414, 91);
            this.btnOut3.TabIndex = 0;
            this.btnOut3.Text = "OUT KEYWORD(3)";
            this.btnOut3.UseVisualStyleBackColor = true;
            this.btnOut3.Click += new System.EventHandler(this.btnOut3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 786);
            this.Controls.Add(this.txtMailAdresleri);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnRef);
            this.Controls.Add(this.btnParams);
            this.Controls.Add(this.btnOut3);
            this.Controls.Add(this.btnOutIki);
            this.Controls.Add(this.btnOut);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnOutIki;
        private System.Windows.Forms.Button btnParams;
        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.TextBox txtMailAdresleri;
        private System.Windows.Forms.Button btnOut3;
    }
}

