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
    public partial class addUser : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=vtExample.accdb");
        OleDbCommand sql;
        OleDbDataReader result;
        public addUser()
        {
            InitializeComponent();
        }

        private void addUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm mainF = new mainForm();
            mainF.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void addUser_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Erkek");
            comboBox1.Items.Add("Kadın");
            comboBox1.Items.Add("Diğer");
            comboBox1.Items.Add("Belirtmek İstemiyorum");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                sql = new OleDbCommand("select * from vtExample_users where username='" + textBox3.Text + "'", conn);
                result = sql.ExecuteReader();
                result.Read();
                if (result.HasRows)
                {
                    MessageBox.Show("Bu kullanıcı adı daha önceden alınmıştır.\nLütfen farklı bir kullanıcı adı giriniz...");
                }
                else
                {
                    string name = textBox1.Text;
                    string surname = textBox2.Text;
                    string birthdate = dateTimePicker1.Value.ToShortDateString();
                    string gender = comboBox1.SelectedItem.ToString();
                    string username = textBox3.Text;
                    string password = textBox4.Text;

                    sql = new OleDbCommand("insert into vtExample_users (name,surname,birthdate,gender,username,psswrd) values ('"+name+"','"+surname+"','"+birthdate+"','"+gender+"','"+username+"','"+password+"')",conn);
                    sql.ExecuteNonQuery();
                    MessageBox.Show("Kayıt başarıyla eklendi...");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                }
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message.ToString());
            }
            conn.Close();
        }
    }
}
