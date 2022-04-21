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
    public partial class FrmThongTin : Form
    {
        public FrmThongTin()
        {
            InitializeComponent();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            foreach (Control i in groupBox1.Controls)
            {
                if (i.GetType() == typeof(TextBox))
                {
                    (i as TextBox).ReadOnly = false;
                }
            }
            foreach (Control i in groupBox2.Controls)
            {
                if (i.GetType() == typeof(TextBox))
                {
                    if (!i.Name.Equals("textBoxGia"))
                    {
                        (i as TextBox).ReadOnly = false;
                    }
                }
            }
        }
    }
}
