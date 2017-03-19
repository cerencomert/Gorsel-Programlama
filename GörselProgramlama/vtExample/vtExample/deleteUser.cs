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
    public partial class deleteUser : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=vtExample.accdb");
        OleDbCommand sql;
        OleDbDataReader result;
        public deleteUser()
        {
            InitializeComponent();
        }

        private void deleteUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm mainF = new mainForm();
            mainF.Show();
        }

        private void deleteUser_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                sql = new OleDbCommand("delete from vtExample_users where username='"+comboBox1.Text+"'", conn);
                result = sql.ExecuteReader();
                MessageBox.Show("Kayıt başarıyla silindi...");
                comboBox1.SelectedIndex = -1;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message.ToString());
            }
            conn.Close();
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            conn.Open();
            try
            {
                sql = new OleDbCommand("select * from vtExample_users", conn);
                result = sql.ExecuteReader();
                while (result.Read())
                    comboBox1.Items.Add(result.GetValue(1).ToString());
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message.ToString());
            }
            conn.Close();
        }
    }
}
