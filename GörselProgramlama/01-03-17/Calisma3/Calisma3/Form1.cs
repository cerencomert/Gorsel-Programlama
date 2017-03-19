using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calisma3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[][] jaggedArray = new string[3][];
        int sayac = 0;

        private int say()
        {
            int sayac = 0;
            if (textBox1.Text != "")
                sayac++;
            if (textBox2.Text != "")
                sayac++;
            if (textBox3.Text != "")
                sayac++;
            if (textBox4.Text != "")
                sayac++;
            if (textBox5.Text != "")
                sayac++;
            return sayac;
        }

        private void addtoarray_Click(object sender, EventArgs e)
        {
            if (sayac < 3)
            {
                jaggedArray[sayac] = new string[say()];
                if (textBox1.Text != "")
                    jaggedArray[sayac][0] = textBox1.Text;
                if (textBox2.Text != "")
                    jaggedArray[sayac][1] = textBox2.Text;
                if (textBox3.Text != "")
                    jaggedArray[sayac][2] = textBox3.Text;
                if (textBox4.Text != "")
                    jaggedArray[sayac][3] = textBox4.Text;
                if (textBox5.Text != "")
                    jaggedArray[sayac][4] = textBox5.Text;
                sayac++;
            }
            else
                MessageBox.Show("Dizi Doldu!");
        }
        private void filllistbox_Click(object sender, EventArgs e)
        {
            string veri = "";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    veri += (jaggedArray[i][j]);
                }
                listBox1.Items.Add(veri);
                veri = "";
            }
        }
    }
}
