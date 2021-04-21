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


namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
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

        private void Form1_Load(object sender, EventArgs e)
        {
            ColumnHeader ch = new ColumnHeader();
            ch.Text = "";
            ch.Name = "page";
            listView1.Columns.Add(ch);
            listView1.Scrollable = true;
            listView1.View = System.Windows.Forms.View.Details;
            DirectoryInfo d = new DirectoryInfo(Application.StartupPath);

            foreach(FileInfo f in d.GetFiles())
            {
                listView1.Items.Add(f.Name);
            }

            //listView1.Items.Add("ht1.htm");
            //listView1.Items.Add("ht2.htm");
            //listView1.Items.Add("ht3.htm");


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string urltext = Path.Combine(Application.StartupPath, listView1.SelectedItems[0].Text);
                webBrowser1.Navigate(urltext);
            }

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
