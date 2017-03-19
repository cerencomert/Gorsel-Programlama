using System;
using System.Collections;
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

        private void add_Click(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();

            list.Add(2);
            list.Add(4);
            list.Add(6);
            list.Add(8);

            foreach (int a in list)
                listBox1.Items.Add(a);
        }

        private void substract_Click(object sender, EventArgs e)
        {
            ArrayList list2 = new ArrayList();

            for (int i = 0; i < listBox1.Items.Count; i++)
                list2.Add(listBox1.Items[i]);

            listBox1.Items.Clear();

           
            list2.Remove(8);
            list2.Add(10);

            foreach (int a in list2)
                listBox1.Items.Add(a);


            /* if (listBox1.Items.Contains (8))
             {
                 list2.Remove(8);
                 list2.Add(10);
             }
             else
             {

             }*/
        }
        private void arraylist_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            ArrayList list3 = new ArrayList();
            list3.Add("London");
            list3.Add(true);
            list3.Add(121);
            list3.Add(52.8d);
            list3.Add("r");

            foreach (object a in list3)
                listBox1.Items.Add(a);
        }
    }
}
