using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;


namespace WindowsFormsApp4
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            InstalledFontCollection fonts = new InstalledFontCollection();
            foreach (FontFamily family in fonts.Families)
            {
                cmdfont.DropDown.Items.Add(family.Name);
            }
            cmdcolors.DropDown.Items.Add("Red");
            cmdcolors.DropDown.Items.Add("Blue");
            cmdcolors.DropDown.Items.Add("Green");



            cmdfontsize.DropDown.Items.Add("8");
            cmdfontsize.DropDown.Items.Add("10");
            cmdfontsize.DropDown.Items.Add("12");

            cmdzoom.DropDown.Items.Add("300%");
            cmdzoom.DropDown.Items.Add("200%");
            cmdzoom.DropDown.Items.Add("100%");




        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                String s = File.ReadAllText(fd.FileName);
                richTextBox1.Text = s;
            }
            
        }

        private void cmdBold_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont == null)
            {
                return;
            }
            FontStyle style = richTextBox1.SelectionFont.Style;
            if(richTextBox1.SelectionFont.Bold)
            {
                style &= ~FontStyle.Bold;
            }
            else
            {
                style |= FontStyle.Bold;
            }
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
        }

        private void cmditalic_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont == null)
            {
                return;
            }
            FontStyle style = richTextBox1.SelectionFont.Style;
            if (richTextBox1.SelectionFont.Italic)
            {
                style &= ~FontStyle.Italic;
            }
            else
            {
                style |= FontStyle.Italic;
            }
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);

        }

        private void cmdunderline_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont == null)
            {
                return;
            }
            FontStyle style = richTextBox1.SelectionFont.Style;
            if (richTextBox1.SelectionFont.Underline)
            {
                style &= ~FontStyle.Underline;
            }
            else
            {
                style |= FontStyle.Underline;
            }
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, style);
        }

        private void cmdfont_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (richTextBox1.SelectionFont == null)
            {
                return;
            }
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, Convert.ToInt32(e.ClickedItem.Text), richTextBox1.SelectionFont.Style);

        }

        private void cmdfontsize_Click(object sender, EventArgs e)
        {

           
        }

        private void cmdfontsize_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           

        }

        private void cmdzoom_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            float zoomPercentage = Convert.ToSingle(e.ClickedItem.Text.Trim('%'));
            richTextBox1.ZoomFactor = zoomPercentage / 100;

        }

        private void cmdcolors_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            KnownColor selectedColor;
            selectedColor = (KnownColor)System.Enum.Parse(typeof(KnownColor), e.ClickedItem.Text);
            richTextBox1.SelectionColor = Color.FromKnownColor(selectedColor);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            ColorDialog d = new ColorDialog();
            d.ShowDialog();
            richTextBox1.ForeColor = d.Color;

        }
    }
}
