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

        public enum Gunler
        {
            Pazartesi,
            Salı,
            Çarşamba,
            Perşembe,
            Cuma,
            Cumartesi,
            Pazar
        }
        private void doldur_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] Gun = Enum.GetNames(typeof(Gunler));

            foreach (string GelenGunler in Gun)
                listBox1.Items.Add(GelenGunler);
        }

        private void goster_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Gunler.Perşembe.ToString());
        }

        private void kontrol_Click(object sender, EventArgs e)
        {
            string gelenDeger = "Perşembe";
            //string gelenDeger= "Ocak";

            Gunler gunDeger = (Gunler)Enum.Parse(typeof(Gunler), gelenDeger);

            if (gunDeger==Gunler.Cuma)
                // if (gelenDeger == Gunler.Cuma.ToString())
                MessageBox.Show(gunDeger.ToString());
            else
                MessageBox.Show("Günler aynı değil");
        }
    }
}
