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

        private void errorcolor_Click(object sender, EventArgs e)
        {
            int a, kullanilmayan;
            //a = "Yeni";
        }

        private void debugmode_Click(object sender, EventArgs e)
        {
             int gelenSayi, toplam = 0;
             gelenSayi = int.Parse(textBox1.Text);
             for (int i = gelenSayi; i >= 1; i--)
                 toplam += i;
             MessageBox.Show(toplam.ToString()); 

         /*   int values, f = 0;
            values = int.Parse(textBox1.Text);
            for (int i = values; i >= 1; i++)
            {
                f = f * (f - 1);
            }
            MessageBox.Show(f.ToString());*/
        }
    }
}
