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
        List<TextBox> textBoxList = new List<TextBox>();
        List<int> sayilar = new List<int>();

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 sınıf = new Class1();
            MessageBox.Show(sınıf.AdSoyad);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Class2 sınıf2 = new Class2();
            MessageBox.Show(sınıf2.AdSoyad);
            MessageBox.Show(sınıf2.s1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Yapıcı y1 = new Yapıcı(textBox1.Text);
            //Yapıcı y1 = new Yapıcı(); 
            MessageBox.Show(y1.olay);
            textBox1.Text = "";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            getSetMethod gsm = new getSetMethod();
            MessageBox.Show(gsm.getSetOrnek);
            gsm.getSetOrnek = textBox1.Text;
            MessageBox.Show(gsm.getSetOrnek);
        } 

        private void button5_Click(object sender, EventArgs e)
        {
            string errorMessage = "";
            for(int i=0; i<textBoxList.Count;i++)
            {
                try
                {
                    int.Parse(textBoxList[i].Text);
                    sayilar.Add(int.Parse(textBoxList[i].Text));
                }
                catch(Exception err)
                {
                    errorMessage += "Textbox" + (i + 1).ToString() + " için" + err.Message.ToString() + "\n";
                }
            }
            if(errorMessage!="")
            MessageBox.Show(errorMessage);

            Method m1 = new Method();
            m1.Hesapla(sayilar.ToArray());
            sayilar.Clear();
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox2.Focus();

            /* Method m1 = new Method();
            try
            {
                m1.Hesapla(Convert.ToInt32(textBox2.Text),
                          Convert.ToInt32(textBox3.Text),
                          Convert.ToInt32(textBox4.Text),
                          Convert.ToInt32(textBox5.Text));
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message.ToString());
            }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxList.Add(textBox2);
            textBoxList.Add(textBox3);
            textBoxList.Add(textBox4);
            textBoxList.Add(textBox5);
        }
    }
}
