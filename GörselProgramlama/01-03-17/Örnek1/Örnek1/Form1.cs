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
        public enum Ogrenci
        {
            Ahmet=100,
            Şahin =227,
            Murat=232,
            Ecenur=332,
        }

        private void Enm_Click(object sender, EventArgs e)
        {
            
             string OgrenciAd = textBox1.Text;
                Ogrenci ogrenciler = (Ogrenci)Enum.Parse(typeof(Ogrenci), OgrenciAd);
                MessageBox.Show("Öğrenci Adı : " + ogrenciler.ToString());
                MessageBox.Show("Öğrenci No : " + (int)ogrenciler); 

            catch (Exception sorun)
            {
                MessageBox.Show("Error: "+sorun.Message);
            }

        }
           
    }
}
