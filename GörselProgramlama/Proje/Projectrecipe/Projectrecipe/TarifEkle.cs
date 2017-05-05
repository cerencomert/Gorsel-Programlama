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

namespace Projectrecipe
{
    public partial class TarifEkle : MaterialForm
    {
        public TarifEkle()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Lime900, Primary.Brown500, Primary.Indigo800, Accent.LightBlue200, TextShade.WHITE);
            materialDivider1.BackColor = System.Drawing.Color.BurlyWood;
        }

        private void TarifEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void yenitarifekle_Click(object sender, EventArgs e)
        {
            AnaEkran mainmenu = new AnaEkran();
            mainmenu.Show();
            Hide();
        }
    }
}
