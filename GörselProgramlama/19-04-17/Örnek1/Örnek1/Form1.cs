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

        private void button1_Click(object sender, EventArgs e)
        {
            Bildirim b = new Bildirim();
            MessageBox.Show(b.Ad("Ali"));
            MessageBox.Show(b.Soyad());
            MessageBox.Show(b.Hesapla(10).ToString());
        }
    }
}
