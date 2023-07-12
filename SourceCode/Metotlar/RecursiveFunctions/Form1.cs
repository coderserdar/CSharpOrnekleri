using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecursiveFunctions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Bir fonksiyonun içinde yine kendisinden bir parça bulunuyorsa bu fonksiyonlara özyineli(recursive) fonksiyon denilir. - Metot içerisinde kendisini tekrardan çağırma işlem
        #region Örnek 1
        int Faktoriyel(int sayi)
        {
            int fakt = 1;
            for (int i = 1; i <= sayi; i++) fakt *= i;
            return fakt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlem Sonucu : " + Faktoriyel(12));
        }
        #endregion
        #region Örnek 2
        int Faktoriyel_Recursive(int sayi)
        {
            if (sayi == 0) return 1;
            else return sayi * Faktoriyel_Recursive(sayi - 1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlem Sonucu : " + Faktoriyel_Recursive(12));

        }
        #endregion
        #region örnek 3
        void Clean(Control.ControlCollection cls)
        {
            foreach (Control control in cls)
            {
                if (control is TextBox)
                    ((TextBox)control).Clear(); 
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Clean(Controls);
            Clean(groupBox1.Controls);
            Clean(groupBox2.Controls);
            Clean(groupBox3.Controls);
        }
        #endregion
        void Temizle(Control.ControlCollection cls)
        {
            foreach (Control ctrl in cls)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Clear();
                else if (ctrl is GroupBox)
                {
                    GroupBox grb = (GroupBox)ctrl;
                    Temizle(ctrl.Controls);
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Temizle(Controls);
        }
    }
}
