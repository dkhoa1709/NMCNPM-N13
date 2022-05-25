using System;
using System.Collections;
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
    public partial class FrmDatCho : Form
    {
        public FrmDatCho()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();

        private void pictureBoxNgayDatVe_Click(object sender, EventArgs e)
        {
            FrmCalendar calendarForm = null;

            try
            {
                // decide to pass a date time or not
                calendarForm = DateTime.TryParse(textBoxNgayDatVe.Text, out var currentDateTime) ?
                    new FrmCalendar(currentDateTime) :
                    new FrmCalendar();

                // reposition to be next to calendar button
                calendarForm.Location = new Point(Left + (Width - 100), Bottom - 80);

                calendarForm.DateTimeHandler += CalendarFormOnDateTimeHandlerNgayDatVe;
                calendarForm.ShowDialog();
            }
            finally
            {
                calendarForm.DateTimeHandler -= CalendarFormOnDateTimeHandlerNgayDatVe;
                calendarForm.Dispose();
            }
        }

        private void CalendarFormOnDateTimeHandlerNgayDatVe(DateTime sender)
        {
            textBoxNgayDatVe.Text = $"{sender.ToString("dd-MM-yyyy")}";
        }

        private void buttonTaoMoi_Click(object sender, EventArgs e)
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(TextBox))
                {
                    TextBox txb = (TextBox)btns;
                    txb.Text = "";
                }
            }
        }

        private void pictureBoxNgayBay_Click(object sender, EventArgs e)
        {
            FrmCalendar calendarForm = null;

            try
            {
                // decide to pass a date time or not
                calendarForm = DateTime.TryParse(textBoxNgay.Text, out var currentDateTime) ?
                    new FrmCalendar(currentDateTime) :
                    new FrmCalendar();

                // reposition to be next to calendar button
                calendarForm.Location = new Point(Left + (Width - 100), Bottom - 80);

                calendarForm.DateTimeHandler += CalendarFormOnDateTimeHandlerNgayBay;
                calendarForm.ShowDialog();

            }
            finally
            {
                calendarForm.DateTimeHandler -= CalendarFormOnDateTimeHandlerNgayBay;
                calendarForm.Dispose();
            }
        }

        private void CalendarFormOnDateTimeHandlerNgayBay(DateTime sender)
        {
            textBoxNgay.Text = $"{sender.ToString("dd-MM-yyyy")}";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmCalendar calendarForm = null;

            try
            {
                // decide to pass a date time or not
                calendarForm = DateTime.TryParse(textBoxNgay.Text, out var currentDateTime) ?
                    new FrmCalendar(currentDateTime) :
                    new FrmCalendar();

                // reposition to be next to calendar button
                calendarForm.Location = new Point(Left + (Width - 100), Bottom - 80);

                calendarForm.DateTimeHandler += CalendarFormOnDateTimeHandlerNgaySinh;
                calendarForm.ShowDialog();

            }
            finally
            {
                calendarForm.DateTimeHandler -= CalendarFormOnDateTimeHandlerNgaySinh;
                calendarForm.Dispose();
            }
        }

        private void CalendarFormOnDateTimeHandlerNgaySinh(DateTime sender)
        {
            textBoxNgaySinh.Text = $"{sender.ToString("dd-MM-yyyy")}";
        }

        public void SetData(string MaCB, string SBDi, string Ngay, string SBDen)
        {
            textBoxMaChuyenBay.Text = MaCB;
            textBoxSanBayDi.Text = SBDi;
            textBoxSanBayDen.Text = SBDen;
            textBoxNgay.Text = Ngay;
            textBoxNgayDatVe.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        public void ResetData()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(TextBox))
                {
                    TextBox txb = (TextBox)btns;
                    txb.Text = "";
                }
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            table.Rows.Add(textBoxMaChuyenBay.Text, textBoxTenHanhKhach.Text, textBoxNgay.Text, textBoxSanBayDi.Text, textBoxSanBayDen.Text);
            dataGridViewPhieuDatCho.DataSource = table;
        }

        private void FrmDatCho_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Mã chuyến bay", typeof(string));
            table.Columns.Add("Tên hành khách", typeof(string));
            table.Columns.Add("Ngày - giờ", typeof(string));
            table.Columns.Add("Sân bay đi", typeof(string));
            table.Columns.Add("Sân bay đến", typeof(string));
            dataGridViewPhieuDatCho.DataSource = table;
        }
    }
}