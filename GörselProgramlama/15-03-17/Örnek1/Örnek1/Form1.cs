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
        List<object> lst = new List<object>();
        public Form1()
        {
            InitializeComponent();
        }
        private void ekle()
        {
            lst.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();

        }
        private void add_Click(object sender, EventArgs e)
        {
            ekle();
        }

        private void show_Click(object sender, EventArgs e)
        {
            foreach(object item in lst)
            listBox1.Items.Add(item);
            //listBox1.Items.AddRange(lst.ToArray());
        }

        private void showinmbox_Click(object sender, EventArgs e)
        {
            string txt = "";
            foreach (object item in lst)
                txt += item + "\n";
            MessageBox.Show(txt);
            MessageBox.Show(lst.ToArray().ToString());
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                ekle();
                #region Handle
                e.Handled = true;
                //Bildirim sesi!
                #endregion
            }
        }

        private void showinmbox2_Click(object sender, EventArgs e)
        {
            // ! Esc'ye tıklanana kadar yazılan ve entera basılanları yan yana yaz escye basıldığında satır atla
        }

        #region KeyCode
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ekle();
                e.Handled = true;
            }
        }
        #endregion
    }
}

