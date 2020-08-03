using System.Runtime.CompilerServices;

namespace rsa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_gen_base64 = new System.Windows.Forms.Button();
            this.button_gen_xml = new System.Windows.Forms.Button();
            this.richTextBox_pub = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox_pri = new System.Windows.Forms.RichTextBox();
            this.button_en_base64 = new System.Windows.Forms.Button();
            this.button_de_base64 = new System.Windows.Forms.Button();
            this.richTextBox_t = new System.Windows.Forms.RichTextBox();
            this.button_en_xml = new System.Windows.Forms.Button();
            this.button_de_xml = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_gen_base64
            // 
            this.button_gen_base64.Location = new System.Drawing.Point(47, 30);
            this.button_gen_base64.Name = "button_gen_base64";
            this.button_gen_base64.Size = new System.Drawing.Size(134, 23);
            this.button_gen_base64.TabIndex = 0;
            this.button_gen_base64.Text = "生成密钥base64";
            this.button_gen_base64.UseVisualStyleBackColor = true;
            this.button_gen_base64.Click += new System.EventHandler(this.button_gen_base64_Click);
            // 
            // button_gen_xml
            // 
            this.button_gen_xml.Location = new System.Drawing.Point(559, 30);
            this.button_gen_xml.Name = "button_gen_xml";
            this.button_gen_xml.Size = new System.Drawing.Size(128, 23);
            this.button_gen_xml.TabIndex = 1;
            this.button_gen_xml.Text = "生成密钥xml";
            this.button_gen_xml.UseVisualStyleBackColor = true;
            this.button_gen_xml.Click += new System.EventHandler(this.button_gen_xml_Click);
            // 
            // richTextBox_pub
            // 
            this.richTextBox_pub.Location = new System.Drawing.Point(12, 81);
            this.richTextBox_pub.Name = "richTextBox_pub";
            this.richTextBox_pub.Size = new System.Drawing.Size(1000, 105);
            this.richTextBox_pub.TabIndex = 2;
            this.richTextBox_pub.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "公钥";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "私钥";
            // 
            // richTextBox_pri
            // 
            this.richTextBox_pri.Location = new System.Drawing.Point(12, 222);
            this.richTextBox_pri.Name = "richTextBox_pri";
            this.richTextBox_pri.Size = new System.Drawing.Size(999, 304);
            this.richTextBox_pri.TabIndex = 5;
            this.richTextBox_pri.Text = "";
            // 
            // button_en_base64
            // 
            this.button_en_base64.Location = new System.Drawing.Point(13, 532);
            this.button_en_base64.Name = "button_en_base64";
            this.button_en_base64.Size = new System.Drawing.Size(104, 23);
            this.button_en_base64.TabIndex = 6;
            this.button_en_base64.Text = "加密base64";
            this.button_en_base64.UseVisualStyleBackColor = true;
            this.button_en_base64.Click += new System.EventHandler(this.button_en_base64_Click);
            // 
            // button_de_base64
            // 
            this.button_de_base64.Location = new System.Drawing.Point(123, 532);
            this.button_de_base64.Name = "button_de_base64";
            this.button_de_base64.Size = new System.Drawing.Size(98, 23);
            this.button_de_base64.TabIndex = 7;
            this.button_de_base64.Text = "解密base64";
            this.button_de_base64.UseVisualStyleBackColor = true;
            this.button_de_base64.Click += new System.EventHandler(this.button_de_base64_Click);
            // 
            // richTextBox_t
            // 
            this.richTextBox_t.Location = new System.Drawing.Point(13, 578);
            this.richTextBox_t.Name = "richTextBox_t";
            this.richTextBox_t.Size = new System.Drawing.Size(999, 178);
            this.richTextBox_t.TabIndex = 8;
            this.richTextBox_t.Text = "";
            // 
            // button_en_xml
            // 
            this.button_en_xml.Location = new System.Drawing.Point(540, 532);
            this.button_en_xml.Name = "button_en_xml";
            this.button_en_xml.Size = new System.Drawing.Size(75, 23);
            this.button_en_xml.TabIndex = 9;
            this.button_en_xml.Text = "加密xml";
            this.button_en_xml.UseVisualStyleBackColor = true;
            this.button_en_xml.Click += new System.EventHandler(this.button_en_xml_Click);
            // 
            // button_de_xml
            // 
            this.button_de_xml.Location = new System.Drawing.Point(621, 531);
            this.button_de_xml.Name = "button_de_xml";
            this.button_de_xml.Size = new System.Drawing.Size(75, 23);
            this.button_de_xml.TabIndex = 10;
            this.button_de_xml.Text = "解密xml";
            this.button_de_xml.UseVisualStyleBackColor = true;
            this.button_de_xml.Click += new System.EventHandler(this.button_de_xml_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.button_de_xml);
            this.Controls.Add(this.button_en_xml);
            this.Controls.Add(this.richTextBox_t);
            this.Controls.Add(this.button_de_base64);
            this.Controls.Add(this.button_en_base64);
            this.Controls.Add(this.richTextBox_pri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox_pub);
            this.Controls.Add(this.button_gen_xml);
            this.Controls.Add(this.button_gen_base64);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_gen_base64;
        private System.Windows.Forms.Button button_gen_xml;
        private System.Windows.Forms.RichTextBox richTextBox_pub;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox_pri;
        private System.Windows.Forms.Button button_en_base64;
        private System.Windows.Forms.Button button_de_base64;
        private System.Windows.Forms.RichTextBox richTextBox_t;
        private System.Windows.Forms.Button button_en_xml;
        private System.Windows.Forms.Button button_de_xml;
    }
}

