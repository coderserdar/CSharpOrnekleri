using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAHamburgerci
{
    public partial class MyMDIForm : Form
    {
        public MyMDIForm()
        {
            InitializeComponent();
        }
        void ChildForm(Form _childForm)
        {
            Width = _childForm.Width + 22;
            Height = _childForm.Height + 68;

            bool durum = false;

            foreach (Form form in MdiChildren)
            {
                if (form.Text == _childForm.Text)
                {
                    durum = true;
                    form.Activate();
                }
                else
                {
                    form.Close();
                }
            }
            if (durum == false)
            {
                _childForm.MdiParent = this;
                _childForm.Show();
            }
        }
        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Form1());
        }

        private void siparişBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Form4());
        }

        private void hamburgerEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Form2());
        }

        private void extraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Form3());
        }

        private void MyMDIForm_Load(object sender, EventArgs e)
        {
            ChildForm(new Form1());
        }
    }
}
