using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Örnek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "Dilek")
            {
                listBox1.Items.Add("İsim Doğru");
                button1.Enabled = true;
            }
               
            else
                listBox1.Items.Add("Hatalı");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
