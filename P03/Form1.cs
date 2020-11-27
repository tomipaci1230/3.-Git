using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int soucet = 0, pocet = 0;
            foreach(Control ctrl in groupBox1.Controls)
            {
                if (ctrl is TextBox)
                {
                    soucet += (Convert.ToInt32(ctrl.Text));
                    pocet++;
                }
                if(ctrl is Label)
                {
                    ctrl.Text = listBox1.SelectedItem.ToString();
                }
            }
            double prumer = (double)soucet / pocet;
            MessageBox.Show("Prumer je: " + prumer);
        }
    }
}
