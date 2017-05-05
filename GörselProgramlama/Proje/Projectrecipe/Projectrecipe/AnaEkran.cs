using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Projectrecipe
{
    public partial class AnaEkran : MaterialForm
    {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=tarif.accdb");
        public AnaEkran()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Lime900, Primary.Brown500, Primary.Indigo800, Accent.LightBlue200, TextShade.WHITE);
            materialDivider1.BackColor= System.Drawing.Color.BurlyWood;
            yenitarifekle.ForeColor = System.Drawing.Color.Sienna;
        }

        private void yenitarifekle_Click(object sender, EventArgs e)
        {
            TarifEkle recipeadd = new TarifEkle();
            recipeadd.Show();
            Hide();
        }

        private void AnaEkran_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void aperatif_Click(object sender, EventArgs e)
        {
           
             
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            conn.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = conn;
            komut.CommandText = ("SELECT * from tarifler");
            OleDbDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["tarif_isim"].ToString();
                ekle.SubItems.Add(oku["tarif_kategori"].ToString());
                listView1.Items.Add(ekle);

            }
            conn.Close();
        }
    }
}
