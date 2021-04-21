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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel1Collapsed = false;

        }

        private void Form4_Load(object sender, EventArgs e)
        {
           
            ColumnHeader ch = new ColumnHeader();
            ch.Text = "Forms";
            ch.Name = "Forms";
            listView1.Columns.Add(ch);
            listView1.Scrollable = true;
            listView1.View = System.Windows.Forms.View.Details;

            listView1.Items.Add("Form 1");
            listView1.Items.Add("Form 2");
            listView1.Items.Add("Form 3");



        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count>0)
            {
                Form f;
                String fname = listView1.SelectedItems[0].Text;
                if(fname=="Form 1")
                {
                    f = new Form1();
                    f.TopLevel = false;
                    splitContainer1.Panel2.Controls.Clear();
                    splitContainer1.Panel2.Controls.Add(f);
                    f.Show();

                }
                else if (fname == "Form 2")
                {
                    f = new Form2();
                    f.TopLevel = false;
                    splitContainer1.Panel2.Controls.Clear();
                    splitContainer1.Panel2.Controls.Add(f);
                    f.Show();

                }
                
            }
        }
    }
}
