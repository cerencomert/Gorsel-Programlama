using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnek1
{
    interface IBildirim
    {
        string Ad(string isim);
        string Soyad();
        int Hesapla(int s1);
    }
}
