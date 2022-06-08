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
    public partial class FrmQuyDinh : Form
    {
        public FrmQuyDinh()
        {
            InitializeComponent();
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            UpdateDataQuyDinh();
            ChangeReadOnly(groupBox3);
        }

        private void UpdateDataQuyDinh()
        {
            var strConn = @"Data Source=LAPTOP-NKLEA02K\TRUONGGIANG15;Initial Catalog = QUANLYBANVECHUYENBAY; Integrated Security = True";
            var sqlConn = new SqlConnection(strConn);
            sqlConn.Open();
            try
            {
                var sqlCommand = new SqlCommand("Update THAMSO set Thoigianbaytt = @TGBayTT, SLSbayTGtoida = @SLSBayToiDa, Tgiandungtoithieu = @TGDungTT, " +
                    "Tgiandungtoida = @TGDungToiDa, Thoihandatve = @THDatVe, Thoihanhuyve = @THHuyVe"
                    , sqlConn);
                sqlCommand.Parameters.Add("@TGBayTT", SqlDbType.Time).Value = TimeSpan.Parse(textBoxTGBayToiThieu.Text);
                sqlCommand.Parameters.Add("@SLSBayToiDa", SqlDbType.Int).Value = Int32.Parse(textBoxSoSBTG.Text);
                sqlCommand.Parameters.Add("@TGDungTT", SqlDbType.Time).Value = TimeSpan.Parse(textBoxTGDungToiThieu.Text);
                sqlCommand.Parameters.Add("@TGDungToiDa", SqlDbType.Time).Value = TimeSpan.Parse(textBoxTGDungToiDa.Text);
                sqlCommand.Parameters.Add("@THDatVe", SqlDbType.Time).Value = TimeSpan.Parse(textBoxTGChamNhatKhiDatVe.Text);
                sqlCommand.Parameters.Add("@THHuyVe", SqlDbType.Time).Value = TimeSpan.Parse(textBoxTGHuyDatVe.Text);
                int rowCount = sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Cập nhật quy định thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi quy định nhập vào không đúng kiểu dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConn.Close();
                sqlConn.Dispose();
            }
            //Console.Read();
        }

        private void LoadDataQuyDinh()
        {
            var strConn = @"Data Source=LAPTOP-NKLEA02K\TRUONGGIANG15;Initial Catalog = QUANLYBANVECHUYENBAY; Integrated Security = True";
            var sqlConn = new SqlConnection(strConn);
            sqlConn.Open();
            var sqlCommand = new SqlCommand("SELECT * FROM [dbo].[THAMSO]", sqlConn);
            var reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                textBoxTGBayToiThieu.Text = reader.GetValue(0).ToString();
                textBoxSoSBTG.Text = reader.GetValue(1).ToString();
                textBoxTGDungToiThieu.Text = reader.GetValue(2).ToString();
                textBoxTGDungToiDa.Text = reader.GetValue(3).ToString();
                textBoxTGChamNhatKhiDatVe.Text = reader.GetValue(4).ToString();
                textBoxTGHuyDatVe.Text = reader.GetValue(5).ToString();
            }
            reader.Close();
            sqlCommand.Dispose();
        }

        private void LoadDataDSSB()
        {
            var strConn = @"Data Source=LAPTOP-NKLEA02K\TRUONGGIANG15;Initial Catalog = QUANLYBANVECHUYENBAY; Integrated Security = True";
            var sqlConn = new SqlConnection(strConn);
            sqlConn.Open();
            string sql = "SELECT MaSBay 'Mã sân bay', Tensb 'Tên sân bay' FROM SANBAY";
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu 
            SqlCommand com = new SqlCommand(sql, sqlConn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            da.Fill(dt);  // đổ dữ liệu vào kho
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
        }

        private void LoadDataDSHV()
        {
            var strConn = @"Data Source=LAPTOP-NKLEA02K\TRUONGGIANG15;Initial Catalog = QUANLYBANVECHUYENBAY; Integrated Security = True";
            var sqlConn = new SqlConnection(strConn);
            sqlConn.Open();
            string sql = "SELECT MaHangVe 'Mã hạng vé', TenHangVe 'Tên hạng vé', TiLe 'Tỷ lệ' FROM HANGVE";
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu 
            SqlCommand com = new SqlCommand(sql, sqlConn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            da.Fill(dt);  // đổ dữ liệu vào kho
            dataGridView2.DataSource = dt; //đổ dữ liệu vào datagridview
        }

        private void FrmQuyDinh_Load(object sender, EventArgs e)
        {
            LoadDataQuyDinh();
            LoadDataDSSB();
            LoadDataDSHV();
        }

        private void ChangeReadOnly(GroupBox x)
        {
            foreach (Control btns in x.Controls)
            {
                if (btns.GetType() == typeof(TextBox))
                {
                    TextBox txb = (TextBox)btns;
                    if (txb.ReadOnly == true)
                        txb.ReadOnly = false;
                    else
                        txb.ReadOnly = true;
                }
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            ChangeReadOnly(groupBox3);
        }

        private void InsertDataSB()
        {
            var strConn = @"Data Source=LAPTOP-NKLEA02K\TRUONGGIANG15;Initial Catalog = QUANLYBANVECHUYENBAY; Integrated Security = True";
            var sqlConn = new SqlConnection(strConn);
            sqlConn.Open();
            try
            {
                var sqlCommand = new SqlCommand("Insert into SANBAY(MaSBay, Tensb) values (@MaSB, @TenSB)", sqlConn);
                sqlCommand.Parameters.Add("@MaSB", SqlDbType.VarChar).Value = textBoxMaSB.Text;
                sqlCommand.Parameters.Add("@TenSB", SqlDbType.VarChar).Value = textBoxTenSB.Text;
                int rowCount = sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Thêm sân bay thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Thêm sân bay không thành công! Mã sân bay phải khác các mã đã có", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConn.Close();
                sqlConn.Dispose();
            }
        }

        private void buttonThemSB_Click(object sender, EventArgs e)
        {
            InsertDataSB();
            LoadDataDSSB();
        }

        private void buttonXoaSB_Click(object sender, EventArgs e)
        {

        }

        private void buttonSuaSB_Click(object sender, EventArgs e)
        {

        }

        private void InsertDataHV()
        {
            var strConn = @"Data Source=LAPTOP-NKLEA02K\TRUONGGIANG15;Initial Catalog = QUANLYBANVECHUYENBAY; Integrated Security = True";
            var sqlConn = new SqlConnection(strConn);
            sqlConn.Open();
            try
            {
                var sqlCommand = new SqlCommand("Insert into HANGVE(MaHangVe, TenHangVe, TiLe) values (@MaHV, @TenHV, @TiLe)", sqlConn);
                sqlCommand.Parameters.Add("@MaHV", SqlDbType.VarChar).Value = textBoxMaHangVe.Text;
                sqlCommand.Parameters.Add("@TenHV", SqlDbType.VarChar).Value = textBoxTenHangVe.Text;
                sqlCommand.Parameters.Add("@TiLe", SqlDbType.VarChar).Value = textBoxTyLe.Text;
                int rowCount = sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Thêm hạng vé thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Thêm hạng vé không thành công! Mã hạng vé phải khác các mã đã có", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConn.Close();
                sqlConn.Dispose();
            }
        }

        private void buttonThemHV_Click(object sender, EventArgs e)
        {
            InsertDataHV();
            LoadDataDSHV();
        }
    }
}
