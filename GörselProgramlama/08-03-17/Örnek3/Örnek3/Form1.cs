using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Örnek3
{
    public partial class Form1 : Form
    {
        ListBox bilgi = new ListBox();
        ArrayList liste = new ArrayList();
        public Form1()
        {
            InitializeComponent();
            bilgi.Items.Add("Aydın");
            bilgi.Items.Add("İzmir");
            bilgi.Items.Add("İstanbul");
            bilgi.Items.Add("Ankara");
            bilgi.Items.Add("Antalya");
        }

        private void addrange_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            liste.AddRange(bilgi.Items); // --> Bu satırdan dolayı 10 gösterir mbox
            listBox1.Items.AddRange(bilgi.Items);
        }

        private void capacity_Click(object sender, EventArgs e)
        {
            liste.AddRange(bilgi.Items);
            MessageBox.Show(liste.Capacity.ToString());
        }

        private void clear_Click(object sender, EventArgs e)
        {
            liste.Clear();
            //MessageBox.Show(liste[1].ToString());
            MessageBox.Show(liste.Capacity.ToString());
        }

        private void contains_Click(object sender, EventArgs e)
        {
            liste.AddRange(bilgi.Items);
           
        }

        private void sort_Click(object sender, EventArgs e)
        {

        }
    }
}
