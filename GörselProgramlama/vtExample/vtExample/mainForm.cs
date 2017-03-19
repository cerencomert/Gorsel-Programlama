using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vtExample
{
    public partial class mainForm : Form
    {
        addUser addU = new addUser();
        updateUser updateU = new updateUser();
        deleteUser deleteU = new deleteUser();

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addU.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateU.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            deleteU.Show();
            this.Hide();
        }
    }
}
