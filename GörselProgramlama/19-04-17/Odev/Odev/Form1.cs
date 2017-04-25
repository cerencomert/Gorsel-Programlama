using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        int a = 0;
        int b = 0;
        int c = 0;

        private void label7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi!");
        }

        private void label8_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("I can see you!");
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
            label1.Text = (e.KeyValue.ToString() +" key DOWNED") ;
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            label2.Text = (e.KeyValue.ToString() + " key DOWNED");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label3.Text = textBox3.Text;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            a++;
            label4.Text = a.ToString();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            b++;
            label5.Text = b.ToString();
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            c++;
            label6.Text = c.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
