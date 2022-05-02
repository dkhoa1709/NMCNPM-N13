﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanVeChuyenBay
{
    public partial class FormMain : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        Form activeForm;

        public FormMain()
        {
            InitializeComponent();
            random = new Random();
            buttonCloseChildForm.Visible = false;
            this.Text = String.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitle.BackColor = color;
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColor(color, -0.5);
                    buttonCloseChildForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenchildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            activeForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;
        }

        private void buttonDashBoard_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Forms.FrmDashBoard(), sender);
        }

        private void buttonLichChuyenBay_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Forms.FrmLichChuyenBay(), sender);
        }

        private void buttonDatVeChuyenBay_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Forms.FrmDatCho(), sender);
        }

        private void buttonTraCuu_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Forms.FrmTraCuu(), sender);
        }

        private void buttonQuyDinh_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Forms.FrmQuyDinh(), sender);
        }

        private void buttonBaoCao_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Forms.FrmBaoCao(), sender);
        }

        private void buttonThongTin_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Forms.FrmThongTinDatVe(), sender);
        }

        private void buttonQuanLyNhanSu_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Forms.FrmQuanLyNhanSu(), sender);
        }

        private void buttonCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            labelTitle.Text = "QUẢN LÝ BÁN VÉ MÁY BAY";
            panelTitle.BackColor = Color.FromArgb(51, 51, 76);
            currentButton = null;
            buttonCloseChildForm.Visible = false;
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool CheckAccountManager(int x)
        {
            if (x % 2 == 0)
                return true;
            return false;
        }
        int a = 2;

        private void FormMain_Load(object sender, EventArgs e)
        {
            if(CheckAccountManager(a))
            {
                buttonDatVeChuyenBay.Visible = false;
                buttonTraCuu.Visible = false;
                buttonThongTin.Visible = false;
            }
            else
            {
                buttonDashBoard.Visible = false;
                buttonQuyDinh.Visible = false;
                buttonBaoCao.Visible = false;
                buttonQuanLyNhanSu.Visible = false;
            }
        }
    }
}