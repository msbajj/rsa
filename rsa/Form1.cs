using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rsa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_gen_base64_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            this.richTextBox_pub.Text = Convert.ToBase64String(RSA.ExportCspBlob(false));
            this.richTextBox_pri.Text = Convert.ToBase64String(RSA.ExportCspBlob(true));
        }

        private void button_gen_xml_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            this.richTextBox_pub.Text = RSA.ToXmlString(false);
            this.richTextBox_pri.Text = RSA.ToXmlString(true);
        }

        private void button_en_base64_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.ImportCspBlob(Convert.FromBase64String(this.richTextBox_pub.Text));
            byte[] cipherbytes = rsa.Encrypt(Encoding.UTF8.GetBytes(this.richTextBox_t.Text), false);
            this.richTextBox_t.Text += "\n加密：\n" + Convert.ToBase64String(cipherbytes); 
        }

        private void button_de_base64_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.ImportCspBlob(Convert.FromBase64String(this.richTextBox_pri.Text));            
            byte[] cipherbytes = rsa.Decrypt(Convert.FromBase64String(this.richTextBox_t.Text), false);
            UTF8Encoding utf = new UTF8Encoding();
            this.richTextBox_t.Text += "\n解密：\n" + utf.GetString(cipherbytes);
        }

        private void button_en_xml_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(this.richTextBox_pub.Text);
            byte[] cipherbytes = rsa.Encrypt(Encoding.UTF8.GetBytes(this.richTextBox_t.Text), false);
            this.richTextBox_t.Text += "\n加密：\n" + Convert.ToBase64String(cipherbytes);
        }

        private void button_de_xml_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(this.richTextBox_pri.Text);
            byte[] cipherbytes = rsa.Decrypt(Convert.FromBase64String(this.richTextBox_t.Text), false);
            UTF8Encoding utf = new UTF8Encoding();
            this.richTextBox_t.Text += "\n解密：\n" + utf.GetString(cipherbytes);
        }
    }
}
