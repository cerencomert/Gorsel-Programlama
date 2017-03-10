using System;
using System.Collections; //Deleting .General for ArrayList
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

        private void add_Click(object sender, EventArgs e)
        {
            ArrayList lst = new ArrayList();

            lst.Add(2);
            lst.Add(4);
            lst.Add(8);
            lst.Add(16);


            foreach (int a in lst)
                listBox1.Items.Add(a);
        }

        private void substract_Click(object sender, EventArgs e)
        {
            ArrayList lst2 = new ArrayList();

            for (int i = 0; i < listBox1.Items.Count; i++)
                lst2.Add(listBox1.Items[i]);

            listBox1.Items.Clear();

            lst2.Remove(8);
            lst2.Add(256);

            foreach (int a in lst2)
                listBox1.Items.Add(a);

            
        }

        private void arry_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            ArrayList lst3 = new ArrayList();
            lst3.Add("Ali");
            lst3.Add(false);
            lst3.Add(121);
            lst3.Add(52.8d);
            lst3.Add("r");

            foreach (object a in lst3)
                listBox1.Items.Add(a);
        }
    }
}
