using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnek3
{
    class Class1
    {
        public string AdSoyad = "Ceren Cömert";
        private string Sehir = "Balıkesir";
        protected string son = "Protected String: Class1";
    }

    class Class2:Class1
    {
        protected string son = "Protected String: Class2";
        public string s1
        {
            get { return son; }
        }
    }

    class Yapıcı
    {
        public string olay;

        public Yapıcı(string isim)
        {
            olay = isim;
        }
        public Yapıcı()
        {
            olay = "Constructor";
        }
        ~Yapıcı()
        {
            System.Windows.Forms.MessageBox.Show("Bellekten siliniyor...");
        }
    }

    class getSetMethod
    {
        public string getSet = "Get-Set Örneği"; //14
        public string getSetOrnek
        {
            get { return getSet.Length.ToString(); }
            set { getSet = value; }
        }
    }

    class Method
    {
        public void Hesapla(params int[]sayilar)
        {
            int toplam = 0;
            foreach (int sayi in sayilar)
                toplam += sayi;
            System.Windows.Forms.MessageBox.Show(toplam.ToString());
        }
    }
}
