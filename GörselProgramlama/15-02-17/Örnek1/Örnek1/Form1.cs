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

        #region Degistir
        private void Degistir_Click(object sender, EventArgs e)
        {
            string tmp = textBox2.Text;
            textBox2.Text = textBox1.Text;
            textBox1.Text = tmp;
        }
        #endregion

        #region MultiLine
        private void TekrarYaz_Click(object sender, EventArgs e)
        {
            mltextb.Text = "";
            //mltextb.Clear();
            for (int i = 0; i < int.Parse(tekrartxb.Text); i++)
                mltextb.AppendText(metintxb.Text + "\n");
            
        }
        #endregion
        #region Hesap Makinesi
        private void topla_Click(object sender, EventArgs e)
        {
            sonuc.Text = (double.Parse(sayi1.Text) + double.Parse(sayi2.Text)).ToString();
        }

        private void cikar_Click(object sender, EventArgs e)
        {
            //cikar.Enabled=false;
            sonuc.Text = (double.Parse(sayi1.Text) - double.Parse(sayi2.Text)).ToString();
        }

        private void carp_Click(object sender, EventArgs e)
        {
            sonuc.Text = (double.Parse(sayi1.Text) * double.Parse(sayi2.Text)).ToString();
        }

        private void bol_Click(object sender, EventArgs e)
        {
            sonuc.Text = (double.Parse(sayi1.Text) / double.Parse(sayi2.Text)).ToString();
        }
        #endregion

        private void Hesapla_Click(object sender, EventArgs e)
        {
            Asonuc.Text = (Math.Pow(double.Parse(r.Text), 2) * Math.PI).ToString();
        }
    }
}
