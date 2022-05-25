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

        FrmDatCho frm = new FrmDatCho();

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
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            if (!String.IsNullOrEmpty(textBoxSanBayDi.Text) && !String.IsNullOrEmpty(textBoxSanBayDen.Text))
            {
                var strConn = @"Data Source=NBIN17\NBIN17;Initial Catalog=QUANLYBANVECHUYENBAY;Persist Security Info=True;User=sa;Password=12345";
                var sqlConn = new SqlConnection(strConn);
                sqlConn.Open();
                string sql = "SELECT CB.MaCBay 'Mã chuyến bay', CB.KhoiHanh 'Thời gian khởi hành', SB2.Tensb 'Tên sân bay đi', " +
                             "SB1.Tensb 'Tên sân bay đến', SB.Tensb 'Tên sân bay trung gian', " +
                             "(SELECT(SUM(S1.SoLuongGhe) - SUM(S1.SoGheDat)) FROM SOLUONGHANGVE S1 WHERE S1.MaCBay = CB.MaCBay) 'Số ghế trống', CB.Dongia 'Đơn giá' " +
                             "FROM CHUYENBAY CB LEFT JOIN THONGTINSANBAYTRUNGGIAN TT ON CB.MaCBay = TT.MaCBay " +
                             "LEFT JOIN SANBAY SB2 ON CB.MaSanBayDi = SB2.MaSBay " +
                             "LEFT JOIN SANBAY SB1 ON CB.MaSanBayDen = SB1.MaSBay " +
                             "LEFT JOIN SANBAY SB ON TT.MaSBayTrungGian = SB.MaSBay " +
                             "WHERE SB2.Tensb = '" + textBoxSanBayDi.Text + "' AND SB1.Tensb = '" + textBoxSanBayDen.Text + "'";// lay het du lieu trong bang sinh vien
                DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu 
                SqlCommand com = new SqlCommand(sql, sqlConn); //bat dau truy van
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
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
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tìm kiếm", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                string MaCB = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                string SBDi = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                string Ngay = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                string SBDen = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(); 
                this.Controls.Add(panelShow);
                panelShow.Size = this.Size;
                panelShow.Location = new Point(0, 0);
                panelShow.Visible = true;
                frm.SetData(MaCB, SBDi, Ngay, SBDen);
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
            frm.ResetData();
        }

    }
}
