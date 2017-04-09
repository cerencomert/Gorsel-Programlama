using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Örnek4
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class StaticMethodYapisi
        {
            public static void IsimYaz(string ad)
            {
                MessageBox.Show(ad);
            }
        }
        public class DonenMethod
        {
            public string BirimA(string ad)
            {
                string KisiAd = ad;
                return KisiAd;
            }
            public int Hesapla(int s1, int s2)
            {
                return s1 + s2;
            }
            public static string AdYaz()
            {
                return "STATIC FUNCTION";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StaticMethodYapisi.IsimYaz("Bilgisayar Mühendisliği");
            Class1.IsimYaz("Balıkesir");
            MessageBox.Show(DonenMethod.AdYaz());
            DonenMethod x = new DonenMethod();
            MessageBox.Show(x.BirimA("BAUN"));
            MessageBox.Show(x.Hesapla(15,25).ToString());

        }
    }
}
