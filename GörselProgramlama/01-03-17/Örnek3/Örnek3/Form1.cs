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

        private void inttoarray_Click(object sender, EventArgs e)
        {
            int[] Sayilar = new int[] { 1, 2, 3, 4, 5, 6 };
            MessageBox.Show(Sayilar[3].ToString());
        }

        private void stringtoarray_Click(object sender, EventArgs e)
        {
            string[] Isimler = new string[] { "Ali", "Veli" , "Ahmet" , "Mehmet","Hasan" };
            MessageBox.Show(Isimler[1].ToString());
        }

        private void twodtoarray_Click(object sender, EventArgs e)
        {
            string[,] twoDimensionArray = new string[,] {
            { "Ali","15"},
            { "Veli","20"},
            { "Ahmet","25"},
            { "Mehmet","30"} };
            MessageBox.Show(twoDimensionArray[int.Parse(textBox1.Text),int.Parse(textBox2.Text)]);
        }
    }
}
