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
    public partial class FrmSignUp : Form
    {
        public FrmSignUp()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "dkhoa1709")
            {
                labelWarning.Text = "This account is exist";
                labelWarning.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FrmLogin().Show();
            this.Close();
        }
    }
}
