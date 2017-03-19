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
    public partial class updateUser : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=vtExample.accdb");
        OleDbCommand sql;
        OleDbDataReader result;
        public updateUser()
        {
            InitializeComponent();
        }

        private void updateUser_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Erkek");
            comboBox1.Items.Add("Kadın");
            comboBox1.Items.Add("Diğer");
            comboBox1.Items.Add("Belirtmek İstemiyorum");

            conn.Open();
            try
            {
                sql = new OleDbCommand("select * from vtExample_users", conn);
                result = sql.ExecuteReader();
                while (result.Read())
                    comboBox2.Items.Add(result.GetValue(1).ToString());
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message.ToString());
            }
            conn.Close();
        }

        private void updateUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm mainF = new mainForm();
            mainF.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                sql = new OleDbCommand("select * from vtExample_users where username='"+comboBox2.Text+"'", conn);
                result = sql.ExecuteReader();
                while (result.Read())
                {
                    textBox1.Text = result.GetValue(3).ToString();
                    textBox2.Text = result.GetValue(4).ToString();
                    textBox3.Text = result.GetValue(1).ToString();
                    textBox4.Text = result.GetValue(2).ToString();
                    comboBox1.SelectedIndex = comboBox1.FindString(result.GetValue(5).ToString());
                    dateTimePicker1.Value = Convert.ToDateTime(result.GetValue(6));
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message.ToString());
            }
            conn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            dateTimePicker1.Value = DateTime.Today;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                string name = textBox1.Text;
                string surname = textBox2.Text;
                string birthdate = dateTimePicker1.Value.ToShortDateString();
                string gender = comboBox1.SelectedItem.ToString();
                string username = textBox3.Text;
                string password = textBox4.Text;

                sql = new OleDbCommand("UPDATE vtExample_users SET name='"+name+"', surname='"+surname+"', birthdate='"+birthdate+"', gender='"+gender+"', psswrd='"+password+"' WHERE username='"+username+"'", conn);
                sql.ExecuteNonQuery();
                MessageBox.Show("Kayıt başarıyla güncellendi...");
                
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message.ToString());
            }
            conn.Close();
        }
    }
}
