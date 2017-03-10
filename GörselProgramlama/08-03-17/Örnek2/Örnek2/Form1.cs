using System;
using System.Collections;
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

        private void fill_Click(object sender, EventArgs e)
        {
            ListBox bilgi = new ListBox();
            bilgi.Items.Add("Paris");
            bilgi.Items.Add("Tokyo");
            bilgi.Items.Add("New York City");
            bilgi.Items.Add("Berlin");
            bilgi.Items.Add("Lizbon");

            ArrayList liste = new ArrayList();
            liste.AddRange(bilgi.Items);

            listBox1.Items.AddRange(bilgi.Items);
            MessageBox.Show(liste.Capacity.ToString());
        }

        private void itemcount_Click(object sender, EventArgs e)
        {
            ListBox bilgi = new ListBox();
            bilgi.Items.Add("Paris");
            bilgi.Items.Add("Tokyo");
            bilgi.Items.Add("New York City");
            bilgi.Items.Add("Berlin");
            bilgi.Items.Add("Lizbon");

            ArrayList liste = new ArrayList();
            liste.AddRange(bilgi.Items);

            MessageBox.Show(listBox1.Items.Count.ToString());
        }
    }
}
