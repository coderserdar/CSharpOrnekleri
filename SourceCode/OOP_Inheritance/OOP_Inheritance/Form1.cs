﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //BasePhone b = new BasePhone("Nokia", "Kablolu");
            //MobilePhone mp = new MobilePhone(true, true, "Samsung", "Wireless");
            SmartPhone iPhone = new SmartPhone("Apple", "Wireless", true, true, true);
        }
    }
}
