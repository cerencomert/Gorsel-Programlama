using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnek1
{
    class Bildirim:IBildirim
    {
        public string Ad(string isim)
        {
            return isim;
        }
        public string Soyad()
        {
            return "Demir";
        }
        public int Hesapla(int s1)
        {
            return 25 * s1;
        }
    }
}
