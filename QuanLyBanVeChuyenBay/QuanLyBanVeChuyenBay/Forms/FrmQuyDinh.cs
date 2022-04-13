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
    public partial class FrmQuyDinh : Form
    {
        public FrmQuyDinh()
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
            ChangeColor(groupBox1);
            ChangeColor(groupBox2);
            ChangeColor(groupBox3);
        }

        private void Formtab2_Load(object sender, EventArgs e)
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

        private void ChangeColor(GroupBox x)
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
            x.ForeColor = Color.Red;
        }

        private void buttonChinhSua_Click(object sender, EventArgs e)
        {
            AllowEditting(groupBox1);
            AllowEditting(groupBox2);
            AllowEditting(groupBox3);
        }

        private void AllowEditting(GroupBox x)
        {
            foreach(Control btns in x.Controls)
            {
                if(btns.GetType() == typeof(TextBox))
                {
                    TextBox txt = (TextBox)btns;
                    txt.ReadOnly = false;
                }
                if (btns.GetType() == typeof(ComboBox))
                {
                    ComboBox cb = (ComboBox)btns;
                    cb.Enabled = true;
                }
            }
        }

        private void Reset(GroupBox x)
        {
            foreach (Control btns in x.Controls)
            {
                if (btns.GetType() == typeof(TextBox))
                {
                    TextBox txt = (TextBox)btns;
                    txt.ReadOnly = true;
                }
                if (btns.GetType() == typeof(ComboBox))
                {
                    ComboBox cb = (ComboBox)btns;
                    cb.Enabled = false;
                }
            }
        }

        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            Reset(groupBox1);
            Reset(groupBox2);
            Reset(groupBox3);
        }
    }
}
