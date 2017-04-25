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
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Başlık1.Metin.icerik);
            MessageBox.Show(Başlık1.Başlık2.Metin.icerik);
            MessageBox.Show(Başlık1.Başlık2.Başlık3.Metin.icerik);
            MessageBox.Show(Başlık1.BaşlıkX.Metin.icerik);
        }
    }

        namespace Başlık1
    {
        class Metin
        {
            public static string icerik = "1";
        }
        namespace Başlık2
        {
            
                class Metin
                {
                    public static string icerik = "1.1";
                }
            namespace Başlık3
            {
                    class Metin
                    {
                        public static string icerik = "1.1.1";
                    }
                }
            }
        namespace BaşlıkX
        {
            class Metin
            {
                public static string icerik = "1.X";
            }
        }
        }
}

