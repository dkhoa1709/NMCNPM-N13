using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanVeChuyenBay.Forms
{
    public partial class FrmDashBoard : Form
    {
        public FrmDashBoard()
        {
            InitializeComponent();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
                if (btns.GetType() == typeof(Label))
                {
                    Label lbl = (Label)btns;
                    lbl.ForeColor = ThemeColor.PrimaryColor;
                }
            }

            ChangeColor(panel2);
            ChangeColor(panel1);
        }

        private void Formtab5_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void ChangeColor(Panel x)
        {
            foreach (Control btns in x.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
                if (btns.GetType() == typeof(Label))
                {
                    Label lbl = (Label)btns;
                    lbl.ForeColor = ThemeColor.PrimaryColor;
                }
            }
        }
    }
}
