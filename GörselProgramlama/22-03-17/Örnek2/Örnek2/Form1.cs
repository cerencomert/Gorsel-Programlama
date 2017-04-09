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

        private void falseadd_Click(object sender, EventArgs e)
        {
            int s1, s2;
            s1 = int.Parse(textBox1.Text);
            s2 = int.Parse(textBox2.Text);
            MessageBox.Show((s1+s2).ToString());
        }

        private void hatayakalama_Click(object sender, EventArgs e)
        {
            try
            {
                int s1, s2;
                s1 = int.Parse(textBox1.Text);
                s2 = int.Parse(textBox2.Text);
                MessageBox.Show((s1 + s2).ToString());
            }
            catch 
            {
                MessageBox.Show("Hata oluştu.");
            }
        }

        private void hatagosterme_Click(object sender, EventArgs e)
        {
            try
            {
                int s1, s2;
                s1 = int.Parse(textBox1.Text);
                s2 = int.Parse(textBox2.Text);
                MessageBox.Show((s1 + s2).ToString());
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString()); //BUNU KOD YAZARKEN KULLANMA
                MessageBox.Show(error.Message.ToString());
            }
        }
    }
}
