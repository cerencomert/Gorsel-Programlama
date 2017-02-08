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

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime();
            dt = DateTime.Today;
            if (dt.DayOfWeek == DayOfWeek.Wednesday)
            { Gunyazi.Text = "Bugün günlerden Çarşamba form çalışman var."; }
            else
            { Gunyazi.Text = "Bugün çalışman yok."; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int number = rnd.Next(1,6);
            Ornekyazi.Text = "Bugün " + number.ToString() + " adet örnek yapacaksın.";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (evet.Checked)
            { MessageBox.Show("Tebrikler. Böyle devam et! ^^");}
            if (hayir.Checked)
            { MessageBox.Show("Yapabileceğini biliyorum. Sakın pes etme! ^^");}
        }
    }
}
