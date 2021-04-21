using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar) || (e.KeyChar=='\b') || (e.KeyChar=='\n') || (e.KeyChar =='\t'))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
                
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (e.KeyChar=='.') ||(char.IsWhiteSpace(e.KeyChar))||(e.KeyChar == '\b') || (e.KeyChar == '\n') || (e.KeyChar == '\t'))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar)|| (char.IsWhiteSpace(e.KeyChar)) || (e.KeyChar == '\b') || (e.KeyChar == '\n') || (e.KeyChar == '\t'))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }
    }
}
