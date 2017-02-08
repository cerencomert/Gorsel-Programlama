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

        private void button1_Click(object sender, EventArgs e)
        {
            sbyte Sayi = 110;
            MessageBox.Show(Sayi.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Mehmet") 
                MessageBox.Show("Merhaba Mehmet");
            else if (textBox1.Text == "Ahmet") 
                MessageBox.Show("Merhaba Ahmet");
            else if (textBox1.Text=="Ali")
                MessageBox.Show("Merhaba Ali");
            else MessageBox.Show("İsim farklı");
            textBox1.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Ad = textBox2.Text;
            textBox2.Text = "";
            switch(Ad)
            {
                case "Ömer":
                    MessageBox.Show(Ad+"İsim seçtiniz");
                    break;
                case "Mustafa":
                    MessageBox.Show(Ad+"İsim seçtiniz");
                    break;
                default:
                    MessageBox.Show("Seçtiğiniz isim listede yok.");
                    break;
            }
        }
    }
}
