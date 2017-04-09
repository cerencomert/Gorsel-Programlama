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

        private void sinirasimi_Click(object sender, EventArgs e)
        {
            try
            {
                int a, b;
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                MessageBox.Show((a+b).ToString());
            }
            catch (OverflowException err)
            {
                MessageBox.Show("Hata: " + err.Message.ToString());
                
            }
        }

        private void formatuyusmazligi_Click(object sender, EventArgs e)
        {
            try
            {
                int a, b;
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                MessageBox.Show((a + b).ToString());
            }
            catch (FormatException err)
            {
                MessageBox.Show("Hata: " + err.Message.ToString());

            }
        }

        private void sifirabolunme_Click(object sender, EventArgs e)
        {
            try
            {
                int a, b;
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                MessageBox.Show((a / b).ToString());
            }
            catch (DivideByZeroException err)
            {
                MessageBox.Show("Hata: " + err.Message.ToString());
            }
            
        }

        private void sbfinally_Click(object sender, EventArgs e)
        {
            try
            {
                int a, b;
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                MessageBox.Show((a / b).ToString());
            }
            catch (DivideByZeroException err)
            {
                MessageBox.Show("Hata: " + err.Message.ToString());
            }
            finally
            {
                textBox1.Text = "";
                textBox2.Text = String.Empty;
            }
        }

        private void outofrange_Click(object sender, EventArgs e)
        {
            try
            {
                int[] c = new int[1];
                int a, b;
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                c[0] = a;
                c[1] = b;

            }
            catch (IndexOutOfRangeException err)
            {
                //Dizi sınır aşımı
                MessageBox.Show("Hata: " + err.Message.ToString());
            }

            finally
            {
                textBox1.Text = "";
                textBox2.Text = String.Empty;
            }
        }

        private void tekbutondakontrol_Click(object sender, EventArgs e)
        {
            try
            {
                int a, b, sonuc;
                int[] c = new int[2];
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                c[0] = a;
                c[1] = b;
                sonuc = a / b;

            }
            catch (OverflowException err)
            {
                MessageBox.Show("Hata: " + err.Message.ToString());
            }
            catch (FormatException err)
            {
                MessageBox.Show("Hata: " + err.Message.ToString());
            }
            catch (DivideByZeroException err)
            {
                MessageBox.Show("Hata: " + err.Message.ToString());
            }
            catch (IndexOutOfRangeException err)
            {
                //Dizi sınır aşımı
                MessageBox.Show("Hata: " + err.Message.ToString());
            }
            finally
            {
                textBox1.Text = "";
                textBox2.Text = String.Empty;
                textBox1.Focus();
            }
        }

        private void manuelex_Click(object sender, EventArgs e)
        {
            try
            {
                throw new DivideByZeroException();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata: " + err.Message.ToString());
            }
        }
    }
}
