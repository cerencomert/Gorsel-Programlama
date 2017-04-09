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
        public class ABC
        {
            public string AdSoyad = "Çağatay Karahan";
            private string Sehir = "İzmir";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EncapsulationUygulama nesne = new EncapsulationUygulama();
            MessageBox.Show(nesne.AdSoyad);
            ABC x = new ABC();
            MessageBox.Show(x.AdSoyad);
        }
    }
}
