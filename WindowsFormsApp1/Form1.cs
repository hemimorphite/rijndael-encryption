using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string content = File.ReadAllText(@"userpass.txt");
            string[] arr = content.Split(';');

            if(textBox1.Text == arr[0] && textBox2.Text == arr[1])
            {
                this.Hide();
                Form2 frm = new Form2();
                frm.username = arr[0];
                frm.Show();
            }
            else
            {
                MessageBox.Show("Namapengguna atau Kata sandi anda salah", "Pesan kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
