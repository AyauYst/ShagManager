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
    public partial class Registration : MaterialForm
    {
        bool extended = false;
        private readonly MaterialSkinManager ma;
        public Registration()
        {
            InitializeComponent();

        }

        private void materialLabel17_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            var data = DateTime.Now.Year-bday.Value.Year;
            //this.Text = data.ToString();

            if (data < 15)
            {
                if (!extended)
                {
                    extended = true;
                    groupBox1.Height = groupBox1.Height + 364;
                    this.Height = this.Height + 364;
                    panel1.Top = panel1.Top + 364;
                }
               
            }
            else
            {
                if (extended)
                {
                    groupBox1.Height = groupBox1.Height - 364;
                    this.Height = this.Height - 364;
                    panel1.Top = panel1.Top - 364;
                }
              

            }

        }
    }
}
