using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialDesignThemes;
using MaterialDesignColors;
using MaterialSkin.Controls;

namespace ForManager
{
    public partial class Form1 : MaterialForm
    {
        //public 
        private readonly MaterialSkinManager ma;
        public Form1()
        {
            InitializeComponent();
            ma = MaterialSkinManager.Instance;
            ma.AddFormToManage(this);
            ma.Theme = MaterialSkinManager.Themes.LIGHT;
            ma.ColorScheme = new ColorScheme(Primary.BlueGrey500, Primary.BlueGrey600, Primary.BlueGrey700, Accent.LightBlue400, TextShade.WHITE);

        }

        private void регистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Registration reg = new Registration();
            reg.Show();

        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okbutton_Click(object sender, EventArgs e)
        {

        }

        private void Check(object sender, EventArgs e)
        {
 
        }
    }
}
