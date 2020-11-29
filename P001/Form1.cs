using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string abeceda = "QWERTZUIOPASDFGHJKLYXCVBNM .,!?";
            int counting = 0;
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is Button) (ctrl as Button).Text = abeceda[counting].ToString();
                {
                    counting++;
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = " ";
            foreach (char wr in textBox1.Text)
            {
                if (wr != '!' && wr != '?' && wr != '.' && wr != ',' && wr != ' ')
                {
                    msg = msg + (char)(wr + 3);
                }
                else
                {
                    msg = msg + wr;
                }

            }
            MessageBox.Show(msg);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }
    }
}
