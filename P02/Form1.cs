using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i = 1;
            Random nh = new Random();
            listBox1.Items.Clear();
            while (i <= 10)
            {
                int x = nh.Next(0, 11);
                listBox1.Items.Add(x);
                i++;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int s = 0;

            foreach(int y in listBox1.SelectedItems)
            {
                s = s + y;
            }

            label1.Text = "Počet je " + listBox1.SelectedItems.Count.ToString() + ".";
            label2.Text = "Součet je " + s.ToString() + ".";
        }
    }
}
