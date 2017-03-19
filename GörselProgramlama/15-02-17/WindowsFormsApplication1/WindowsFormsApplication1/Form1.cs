using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(1280, 720);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            /* Random rnd = new Random();
             Random rnd2 = new Random();

             int en = rnd.Next(0, this.Width - button1.Left);
             int boy = rnd2.Next(0, this.Height - button1.Top);

             button1.Left = en;
             button1.Top = boy;
             */
            //Bu kod öğretmenin istediği mousedan kaçan fare uygulaması için yazıldı.Sonrasında proje internet tarayıcısına döndü.Nedeni belli.
            //http://s2.quickmeme.com/img/18/18c0aae775daa798d9f685ad3b4cc50b67da0751e585be5428ab92b1368f0e7e.jpg
        }



        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void ileri_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void yenile_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void git_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(richTextBox1.Text);
        }

        private void kaynak_Click(object sender, EventArgs e)
        {
            richTextBox2.Visible = true;
            richTextBox2.Text = webBrowser1.DocumentText;
        }

        private void richTextBox2_DoubleClick(object sender, EventArgs e)
        {
            richTextBox2.Visible = false;
        }

        private void anasayfa_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://s2.quickmeme.com/img/18/18c0aae775daa798d9f685ad3b4cc50b67da0751e585be5428ab92b1368f0e7e.jpg");

        }

        private void yazdir_Click(object sender, EventArgs e)
        {
            webBrowser1.Print();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://s2.quickmeme.com/img/18/18c0aae775daa798d9f685ad3b4cc50b67da0751e585be5428ab92b1368f0e7e.jpg");
        }
    }
}
