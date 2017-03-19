using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calisma1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum Katilimci
        {
            Ceren=100,
            Çağatay=150,
            Rana=200,
            Uğur=250,
        }

        private void ara_Click(object sender, EventArgs e)
        {
            try
            {
                string KatilimciAd = textBox1.Text;
                Katilimci katilimcilar = (Katilimci)Enum.Parse(typeof(Katilimci), KatilimciAd);
                // Katilimci enumunun içinden katilimcilar diye bir nesne yarattık sonra bunu katilimci adi ve sayi olarak diye kullanabilmek için ayırdık
                MessageBox.Show("Öğrenci Adı: " +katilimcilar.ToString());
                MessageBox.Show("Öğrenci Numarası: "+(int)katilimcilar);

            }

            catch(Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }

            //Bu programı kullanıcı kendisi adı ve sayıyı girdikten sonra enum aratma şekline nasıl getirebilirsin?
            //Try catch ilk defa yapıldı
        }
    }
}
