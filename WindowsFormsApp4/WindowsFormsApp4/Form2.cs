using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;



namespace WindowsFormsApp4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void email()
        {
            try
            {
                MailMessage m = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                m.From = new MailAddress("nklsobana@gmail.com");
                m.To.Add(new MailAddress(textBox1.Text));
                m.Subject = textBox2.Text;
                m.IsBodyHtml = true;
                m.Body = textBox3.Text;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("nklsobana@gmail.com", "sobsmuthu");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(m);

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }
        public void emailwithattachment()
        {
            try
            {
                MailMessage m = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                m.From = new MailAddress("nklsobana@gmail.com");
                m.To.Add(new MailAddress(textBox1.Text));
                m.Subject = textBox2.Text;
                m.IsBodyHtml = true;
                m.Body = textBox3.Text;

                OpenFileDialog db = new OpenFileDialog();
                db.ShowDialog();
                MessageBox.Show(db.FileName);

                System.Net.Mail.Attachment attachment;
                attachment = new System.Net.Mail.Attachment(db.FileName);
                m.Attachments.Add(attachment);

            

                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("nklsobana@gmail.com", "sobsmuthu");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(m);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

            private void button1_Click(object sender, EventArgs e)
        {
            emailwithattachment();
            MessageBox.Show("email sent");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
