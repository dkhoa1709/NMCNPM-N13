using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanVeChuyenBay
{
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        Form activeForm;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }

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
            if(btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitle.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColor(color, -0.5);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColor(color, -0.5);
                }
            }
        }

        private void DisableButton()
            {
                foreach(Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }    
            }
        }

        private void OpenchildForm(Form childForm, object btnSender)
        {
            if(activeForm!=null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            activeForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            this.panelDesktop.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Forms.Formtab1(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Forms.Formtab2(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Forms.Formtab3(), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Forms.Formtab4(), sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenchildForm(new Forms.Formtab5(), sender);
        }
    }
} 