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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "dkhoa1709" && textBoxPassWord.Text == "dkhoa1709")
            {
                new FormMain().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect!");
                textBoxUserName.Clear();
                textBoxPassWord.Clear();
            }
        }

        private void textBoxPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                buttonLogin.PerformClick();
            }    
        }

        private void linkLabelSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new FrmSignUp().Show();
            this.Hide();
        }
    }
}
