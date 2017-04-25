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
            //this.Size = new Size(1280, 720);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            /*Random rnd = new Random();
            Random rnd2 = new Random();

            int en = rnd.Next(0, this.Width - button1.Left);
            int boy = rnd2.Next(0, this.Height - button1.Top);

            button1.Left = en;
            button1.Top = boy; */
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.Visible = false;
            groupBox1.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
        }

        private void groupBox1_MouseHover(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            button2.Visible = true;
        }
    }
}
