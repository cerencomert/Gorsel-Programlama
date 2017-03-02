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
        struct Arabalar
            /*Class'ın ilkel versiyonudur. Class'ın çağrıldığı gibi çağrılır ve aynı şekilde nesne oluşturulur. 
            Küçük kod blokları için kullanılır.*/
        {
            public string ArabaMarka;
            public string ArabaModel;
        }

        private void Strct_Click(object sender, EventArgs e)
        {
            Arabalar StructOrnek = new Arabalar();
            StructOrnek.ArabaMarka = "Volkswagen";
            StructOrnek.ArabaModel = "Polo";
            MessageBox.Show(StructOrnek.ArabaMarka+" / " +StructOrnek.ArabaModel);
        }
    }
}
