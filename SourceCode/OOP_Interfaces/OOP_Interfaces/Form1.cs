using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Interfaces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Kaleci volkan = new Kaleci
        {
            AdiSoyadi = "Volkan Demirel",
            Agresiflik = 99,
            FormaNumarasi = "1",
            MilliMi = true,
            Refleks = 89,
            SutGucu = 6,
            Boyu = 198,
            ElleTopKontrolu = 92
        };
        Defans sabri = new Defans
        {
            AdiSoyadi = "Sabri Sarıoğlu",
            Agresiflik = 75,
            FormaNumarasi = "55",
            MilliMi = true,
            Refleks = 2,
            SutGucu = 36,
            Boyu = 155
        };
        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add(volkan);
            listBox1.Items.Add(sabri);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            //if (listBox1.SelectedItem.GetType() == typeof(Kaleci))
            //{
            //    Kaleci k = listBox1.SelectedItem as Kaleci;
            //    foreach (PropertyInfo item in k.GetType().GetProperties())
            //    {
            //        Label lbl = new Label();
            //        lbl.Text = string.Format(item.Name + " : " + item.GetValue(k));
            //        lbl.AutoSize = false;
            //        lbl.Width = flowLayoutPanel1.Width;
            //        flowLayoutPanel1.Controls.Add(lbl);
            //    }
            //}
            //else if (listBox1.SelectedItem.GetType() == typeof(Defans))
            //{
            //    Defans d = listBox1.SelectedItem as Defans;
            //    foreach (PropertyInfo item in d.GetType().GetProperties())
            //    {
            //        Label lbl = new Label();
            //        lbl.Text = string.Format(item.Name + " : " + item.GetValue(d));
            //        lbl.AutoSize = false;
            //        lbl.Width = flowLayoutPanel1.Width;
            //        flowLayoutPanel1.Controls.Add(lbl);
            //    }
            //}

            if (listBox1.SelectedItem != null && listBox1.SelectedItem.GetType().GetInterface("IFutbolcu") != null)
            {
                IFutbolcu gelen = (IFutbolcu)listBox1.SelectedItem;
                foreach (PropertyInfo item in gelen.GetType().GetProperties())
                {
                    Label lbl = new Label();
                    lbl.Text = string.Format(item.Name + " : " + item.GetValue(gelen));
                    lbl.AutoSize = false;
                    lbl.Width = flowLayoutPanel1.Width;
                    flowLayoutPanel1.Controls.Add(lbl);
                }
            }
        }
    }
}
