using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanVeChuyenBay.Forms
{
    public partial class FrmTraCuu : Form
    {
        public FrmTraCuu()
        {
            InitializeComponent();
        }

        private void pictureBoxNgayBay_Click(object sender, EventArgs e)
        {
            FrmCalendar calendarForm = null;

            try
            {
                // decide to pass a date time or not
                calendarForm = DateTime.TryParse(textBoxNgaySinh.Text, out var currentDateTime) ?
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
            textBoxNgaySinh.Text = $"{sender.ToString("dd-MM-yyyy")}";
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            var strConn = @"Data Source=NBIN17\NBIN17;Initial Catalog=DEMO;Persist Security Info=True;User=sa;Password=Nhockbin1709";
            var sqlConn = new SqlConnection(strConn);
            sqlConn.Open();
            string sql = "select * from ChuyenBay";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, sqlConn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.FlatStyle = FlatStyle.Popup;
            btn.CellTemplate.Style.BackColor = System.Drawing.ColorTranslator.FromHtml("#49CC9A");
            btn.Text = "Đặt vé";
            btn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn);
            sqlConn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 5)
            {
                this.Controls.Add(panelShow);
                panelShow.Size = this.Size;
                panelShow.Location = new Point(0, 0);
                panelShow.Visible = true;
                FrmDatCho frm = new FrmDatCho();
                frm.SetData("10");
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                frm.Visible = true;
                panelShow.Controls.Add(frm);
                panelShow.BringToFront();
                frm.pictureBox2.Click += Click;
            }    
        }

        public void Click(object sender, EventArgs e)
        {
            panelShow.Visible = false;
        }
    }
}
