using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Çalışma2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        struct Bilgisayarlar
        {
            public string BilgisayarMarka;
            public string BilgisayarModel;
            public string BilgisayarFiyat;
            public string BilgisayarPuan;
           
        }

        private void Struct_Click(object sender, EventArgs e)
        {
            Bilgisayarlar bilgisayar = new Bilgisayarlar();
            bilgisayar.BilgisayarMarka = "Msi";
            bilgisayar.BilgisayarModel = "GP62 6QE";
            bilgisayar.BilgisayarFiyat = "x TL";
            bilgisayar.BilgisayarPuan = "4.3";
            if (radioButton1.Checked)
                label1.Text = bilgisayar.BilgisayarMarka;
            else if (radioButton2.Checked)
                label1.Text = bilgisayar.BilgisayarModel;
            else if (radioButton3.Checked)
                label1.Text = bilgisayar.BilgisayarFiyat;
            else if (radioButton4.Checked)
                label1.Text = bilgisayar.BilgisayarPuan;
        }
    }
}
