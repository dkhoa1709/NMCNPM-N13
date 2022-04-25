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
    public partial class FrmThemNhanVien : Form
    {
        public FrmThemNhanVien()
        {
            InitializeComponent();
            Shown += OnShown;
        }

        private void OnShown(object sender, EventArgs e)
        {
            ActiveControl = pictureBoxNgaySinh;
        }

        private void pictureBoxNgaySinh_Click(object sender, EventArgs e)
        {
            FrmCalendar calendarForm = null;

            try
            {
                // decide to pass a date time or not
                calendarForm = DateTime.TryParse(textBox1.Text, out var currentDateTime) ?
                    new FrmCalendar(currentDateTime) :
                    new FrmCalendar();

                // reposition to be next to calendar button
                calendarForm.Location = new Point(Left + (Width - 100), Bottom - 80);

                calendarForm.DateTimeHandler += CalendarFormOnDateTimeHandler;
                calendarForm.ShowDialog();

            }
            finally
            {
                calendarForm.DateTimeHandler -= CalendarFormOnDateTimeHandler;
                calendarForm.Dispose();
            }
        }

        private void CalendarFormOnDateTimeHandler(DateTime sender)
        {
            textBoxNgaySinh.Text = $"{sender.ToString("MM-dd-yyyy")}";
        }
    }
}
