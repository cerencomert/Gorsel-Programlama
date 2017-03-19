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
        /// <summary>
        ///     
        /// </summary>
        /// <param name="ad">Adınızı giriniz</param>
        /// <param name="soyad">Soyadınızı giriniz</param>
        
        private void loginmessage(string ad,string soyad)
        {
            MessageBox.Show("Hoşgeldin," +ad + "" +soyad);
        }

        private string login(string ad,string soyad)
        {
            return "Hoşgeldin," + ad + "" + soyad;
        }
        private void show_Click(object sender, EventArgs e)
        {
            loginmessage(textBox1.Text, textBox2.Text);
            MessageBox.Show(login(textBox1.Text,textBox2.Text));
        }

        private void outMethod(ref string a,out string b)
        {
            b = textBox2.Text;
        }
        private void outref_Click(object sender, EventArgs e)
        {
            string a, b;
            a = textBox1.Text;
            outMethod(ref a, out b);
            MessageBox.Show(a+" " +b);
        }
    }
}
