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
    public partial class FrmLichChuyenBay : Form
    {
        public FrmLichChuyenBay()
        {
            InitializeComponent();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            //var strConn = @"Data Source=NBIN17\NBIN17;Initial Catalog=DEMO;Persist Security Info=True;User=sa;Password=Nhockbin1709";
            //var sqlConn = new SqlConnection(strConn);
            //sqlConn.Open();
            //var sqlInsCommand = new SqlCommand("INSERT dbo.ChuyenBay (machuyenbay,sanbaydi,sanbayden,ngay,thoigianbay) VALUES (@machuyenbay,@sanbaydi,@sanbayden,@ngay,@thoigian)  ", sqlConn);
            //sqlInsCommand.Parameters.Add("@machuyenbay", SqlDbType.NVarChar);
            //sqlInsCommand.Parameters["@machuyenbay"].Value = textBoxMaChuyenBay.Text;
            //sqlInsCommand.Parameters.Add("@sanbaydi", SqlDbType.NVarChar);
            //sqlInsCommand.Parameters["@sanbaydi"].Value = textBoxSanBayDi.Text;
            //sqlInsCommand.Parameters.Add("@sanbayden", SqlDbType.NVarChar);
            //sqlInsCommand.Parameters["@sanbayden"].Value = textBoxSanBayDen.Text;
            //sqlInsCommand.Parameters.Add("@ngay", SqlDbType.Date);
            //sqlInsCommand.Parameters["@ngay"].Value = textBoxNgayGio.Text;
            //sqlInsCommand.Parameters.Add("@thoigian", SqlDbType.Int);
            //sqlInsCommand.Parameters["@thoigian"].Value = textBoxThoiGianBay.Text;
            //sqlInsCommand.ExecuteNonQuery();
            //string sql = "select * from ChuyenBay";  // lay het du lieu trong bang sinh vien
            //SqlCommand com = new SqlCommand(sql, sqlConn); //bat dau truy van
            //com.CommandType = CommandType.Text;
            //SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            //DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            //da.Fill(dt);  // đổ dữ liệu vào kho
            //dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview

            //sqlConn.Close();
        }
    }
}
