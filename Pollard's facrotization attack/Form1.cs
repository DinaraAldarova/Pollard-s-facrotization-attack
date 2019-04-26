using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pollard_s_facrotization_attack
{
    public partial class Form1 : Form
    {
        Culculate culculate;
        public Form1()
        {
            InitializeComponent();
            culculate = new Culculate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            culculate.NewFact(textBox1.Text, Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value));
            richTextBox1.Text = culculate.report;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!(Char.IsDigit(number) || number == 8)) // only digit or backspace
            {
                e.Handled = true;
            }
        }
    }
}
