using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calisma1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Random rnd2 = new Random();

            int en = rnd.Next(0, this.Width );
            int boy = rnd2.Next(0, this.Height - button1.Top);

            button1.Left = en;
            button1.Top = boy;
        }
    }
}
