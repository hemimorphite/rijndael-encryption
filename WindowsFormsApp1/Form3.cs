using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text))
            {
                if (!string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    string encryptedstring = StringCipher.Encrypt(textBox2.Text, textBox1.Text);
                    richTextBox1.Text = encryptedstring;
                } 
            }
            else
            {
                MessageBox.Show("key string tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text))
            {
                if (!string.IsNullOrEmpty(richTextBox1.Text) && !string.IsNullOrWhiteSpace(richTextBox1.Text))
                {
                    try
                    {
                        string decryptedstring = StringCipher.Decrypt(richTextBox1.Text, textBox1.Text);
                        textBox2.Text = decryptedstring;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("key string dan encrypted string tidak cocok", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
            else
            {
                MessageBox.Show("key string tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
