using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Örnek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = true;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.Visible = false;
            button4.Visible = true;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.Visible = false;
            button3.Visible = true;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.Visible = false;
            button1.Visible = true;
        }
    }
}
