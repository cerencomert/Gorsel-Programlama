using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;  // Access bağlantısı kurabilmek için gerekli...

namespace vtExample
{
    public partial class loginForm : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=vtExample.accdb");
        OleDbCommand sql;
        OleDbDataReader result;
        public loginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                sql = new OleDbCommand("select * from vtExample_users where username='" + textBox1.Text + "' AND psswrd='" + textBox2.Text + "'", conn);
                result = sql.ExecuteReader();
                result.Read();
                if (result.HasRows)
                {
                    mainForm form = new mainForm();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kayıt Yok!");
                }
            }
            catch 
            {   }
            conn.Close();
        }
    }
}
