using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoopExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < Controls.Count; i++)
            {
                Controls[i].BackColor = Color.Black;
                Controls[i].ForeColor = Color.White;

            }
        }

        private void btnOrnek1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
                lblYaziAlani.Text += "X ";
        }

        private void btnOrnekIki_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
                lblYaziAlani.Text += "X\n";
        }

        private void btnOrnekUc_Click(object sender, EventArgs e)
        {
            lblYaziAlani.Text = "";
            //Kare çizelim(içi dolu)
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    lblYaziAlani.Text += " X ";
                }
                lblYaziAlani.Text += "\n";
            }
        }

        private void btnOrnekDort_Click(object sender, EventArgs e)
        {
            lblYaziAlani.Text = string.Empty;
            //Dik kenar üçgen çizelim
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    lblYaziAlani.Text += " X ";
                }
                lblYaziAlani.Text += "\n";
            }
        }

        private void btnOrnekBes_Click(object sender, EventArgs e)
        {
            lblYaziAlani.Text = "";
            //Çarpım tablosu oluşturulım (10'a kadar kafi)
            // 1 x 1 = 1
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    listBox1.Items.Add($"{i} X {j} = {i * j}");
                }
                listBox1.Items.Add("------------------------------");
            }
        }
    }
}
