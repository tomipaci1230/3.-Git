using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = comboBox1.SelectedItem.ToString();
            int mocnina = Convert.ToInt32(comboBox1.SelectedItem), vysledek = 1, cislo;
            foreach(Control ctrl in panel1.Controls)
            {
                if(ctrl is TextBox)
                {
                    vysledek = 1;
                    cislo = Convert.ToInt32(ctrl.Text);
                    for(int i = 1; i <= mocnina; i++)
                    {
                        vysledek *= cislo;
                    }
                    ctrl.Text = vysledek.ToString();
                }
            }
        }
    }
}
