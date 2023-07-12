using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAHamburgerci
{
    public static class Fonksiyon
    {
        public static void Temizle(this Control.ControlCollection kontroller)
        {
            foreach (Control control in kontroller)
            {
                if (control is TextBox)
                {
                    TextBox txt = (TextBox)control;
                    txt.Clear();
                }
                else if(control is CheckBox)
                {
                    CheckBox chk = (CheckBox)control;
                    chk.Checked = false;
                }
                else if(control is RadioButton)
                {
                    RadioButton rdb = (RadioButton)control;
                    if (rdb.Name == "rbKucuk") rdb.Checked = true;
                    else rdb.Checked = false;
                }
                else if (control is NumericUpDown)
                {
                    NumericUpDown nmr = (NumericUpDown)control;
                    nmr.Value = 1;
                }
                else if(control is FlowLayoutPanel)
                {
                    FlowLayoutPanel flp = (FlowLayoutPanel)control;
                    Temizle(flp.Controls);
                }
                else if (control is GroupBox)
                {
                    GroupBox grb = (GroupBox)control;
                    Temizle(grb.Controls);
                }
                else if (control is ComboBox)
                {
                    ComboBox cmb = (ComboBox)control;
                    cmb.SelectedIndex = 0;
                }
            }
        }
    }
}
