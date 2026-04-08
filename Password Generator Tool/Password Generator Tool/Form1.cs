using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Generator_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

     
            private void btnGenerate_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        
        {
            if (txtPassword.Text != "")
            {
                Clipboard.SetText(txtPassword.Text);
                MessageBox.Show("Password copied to clipboard ✅");
            }
        }

        private void btnGenerate_Click_1(object sender, EventArgs e)     
       {
            int length = (int)numLength.Value;

            string chars =
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "abcdefghijklmnopqrstuvwxyz" +
                "0123456789" +
                "!@#$%^&*()";

            Random random = new Random();

            string password = "";

            for (int i = 0; i < length; i++)
            {
                password += chars[random.Next(chars.Length)];
            }

            txtPassword.Text = password;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    
}
