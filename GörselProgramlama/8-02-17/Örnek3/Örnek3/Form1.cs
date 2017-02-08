using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Örnek3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            for (int i=0; i<20; i+=3)
            {
                label1.Text += i.ToString() + " ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] Dizi = new int[] { 0, 5, 9, 7, 8, 2, 9, 1, 34 };
            foreach(int i in Dizi)
            {
                label2.Text += i.ToString() + " ";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (char karakter in textBox1.Text)
            {
                listBox1.Items.Add(karakter);
            }
            //listBox2.Items.Add(textBox1.Text);
        }
    }
}
