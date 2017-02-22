using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Örnek_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void String_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
        }

        private void Int_Click(object sender, EventArgs e)
        {
            int sayi = 3;
            MessageBox.Show(sayi.ToString());
            //MessageBox.Show(Convert.ToString(sayi));
        }

        private void strtoint_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox2.Text + textBox3.Text);
        }

        private void intoint_Click(object sender, EventArgs e)
        {
            MessageBox.Show((int.Parse(textBox2.Text) + int.Parse(textBox3.Text)).ToString());
        }
    }
}
