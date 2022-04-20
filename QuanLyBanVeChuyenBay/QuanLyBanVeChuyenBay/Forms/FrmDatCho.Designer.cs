
namespace QuanLyBanVeChuyenBay.Forms
{
    partial class FrmDatCho
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonThoat = new System.Windows.Forms.Button();
            this.labelMaChuyenBay = new System.Windows.Forms.Label();
            this.labelSanBayDi = new System.Windows.Forms.Label();
            this.labelNgayGio = new System.Windows.Forms.Label();
            this.labelMaKhach = new System.Windows.Forms.Label();
            this.labelGiaTien = new System.Windows.Forms.Label();
            this.labelSanBayDen = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonTaoMoi = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.textBoxSanBayDi = new System.Windows.Forms.TextBox();
            this.textBoxNgayGio = new System.Windows.Forms.TextBox();
            this.textBoxMaHanhKhach = new System.Windows.Forms.TextBox();
            this.textBoxSanBayDen = new System.Windows.Forms.TextBox();
            this.textBoxTinhTrangVe = new System.Windows.Forms.TextBox();
            this.textBoxCMND = new System.Windows.Forms.TextBox();
            this.textBoxTenHanhKhach = new System.Windows.Forms.TextBox();
            this.textBoxDienThoai = new System.Windows.Forms.TextBox();
            this.labelTenKhach = new System.Windows.Forms.Label();
            this.labelHangVe = new System.Windows.Forms.Label();
            this.labelNgayDatVe = new System.Windows.Forms.Label();
            this.textBoxGiaTien = new System.Windows.Forms.TextBox();
            this.comboBoxMaChuyenBay = new System.Windows.Forms.ComboBox();
            this.dateTimePickerNgayDatVe = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewPhieuDatCho = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxHangVe = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhieuDatCho)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonThoat
            // 
            this.buttonThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.Location = new System.Drawing.Point(772, 580);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(150, 40);
            this.buttonThoat.TabIndex = 0;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            // 
            // labelMaChuyenBay
            // 
            this.labelMaChuyenBay.AutoSize = true;
            this.labelMaChuyenBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaChuyenBay.Location = new System.Drawing.Point(45, 66);
            this.labelMaChuyenBay.Name = "labelMaChuyenBay";
            this.labelMaChuyenBay.Size = new System.Drawing.Size(126, 20);
            this.labelMaChuyenBay.TabIndex = 2;
            this.labelMaChuyenBay.Text = "Mã chuyến bay:";
            // 
            // labelSanBayDi
            // 
            this.labelSanBayDi.AutoSize = true;
            this.labelSanBayDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSanBayDi.Location = new System.Drawing.Point(45, 111);
            this.labelSanBayDi.Name = "labelSanBayDi";
            this.labelSanBayDi.Size = new System.Drawing.Size(98, 20);
            this.labelSanBayDi.TabIndex = 3;
            this.labelSanBayDi.Text = "Sân Bay Đi:";
            // 
            // labelNgayGio
            // 
            this.labelNgayGio.AutoSize = true;
            this.labelNgayGio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayGio.Location = new System.Drawing.Point(45, 156);
            this.labelNgayGio.Name = "labelNgayGio";
            this.labelNgayGio.Size = new System.Drawing.Size(94, 20);
            this.labelNgayGio.TabIndex = 4;
            this.labelNgayGio.Text = "Ngày - Giờ:";
            // 
            // labelMaKhach
            // 
            this.labelMaKhach.AutoSize = true;
            this.labelMaKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaKhach.Location = new System.Drawing.Point(520, 79);
            this.labelMaKhach.Name = "labelMaKhach";
            this.labelMaKhach.Size = new System.Drawing.Size(134, 20);
            this.labelMaKhach.TabIndex = 5;
            this.labelMaKhach.Text = "Mã Hành Khách:";
            // 
            // labelGiaTien
            // 
            this.labelGiaTien.AutoSize = true;
            this.labelGiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGiaTien.Location = new System.Drawing.Point(45, 381);
            this.labelGiaTien.Name = "labelGiaTien";
            this.labelGiaTien.Size = new System.Drawing.Size(72, 20);
            this.labelGiaTien.TabIndex = 6;
            this.labelGiaTien.Text = "Giá tiền:";
            // 
            // labelSanBayDen
            // 
            this.labelSanBayDen.AutoSize = true;
            this.labelSanBayDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSanBayDen.Location = new System.Drawing.Point(45, 201);
            this.labelSanBayDen.Name = "labelSanBayDen";
            this.labelSanBayDen.Size = new System.Drawing.Size(112, 20);
            this.labelSanBayDen.TabIndex = 7;
            this.labelSanBayDen.Text = "Sân Bay Đến:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Tình Trạng Vé:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(520, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "CMND:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(520, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Điện Thoại:";
            // 
            // buttonTaoMoi
            // 
            this.buttonTaoMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTaoMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTaoMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTaoMoi.Location = new System.Drawing.Point(572, 580);
            this.buttonTaoMoi.Name = "buttonTaoMoi";
            this.buttonTaoMoi.Size = new System.Drawing.Size(150, 40);
            this.buttonTaoMoi.TabIndex = 11;
            this.buttonTaoMoi.Text = "Tạo mới";
            this.buttonTaoMoi.UseVisualStyleBackColor = true;
            // 
            // buttonXoa
            // 
            this.buttonXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.Location = new System.Drawing.Point(372, 580);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(150, 40);
            this.buttonXoa.TabIndex = 12;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            // 
            // buttonThem
            // 
            this.buttonThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Location = new System.Drawing.Point(172, 580);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(150, 40);
            this.buttonThem.TabIndex = 13;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            // 
            // textBoxSanBayDi
            // 
            this.textBoxSanBayDi.Location = new System.Drawing.Point(205, 111);
            this.textBoxSanBayDi.Name = "textBoxSanBayDi";
            this.textBoxSanBayDi.Size = new System.Drawing.Size(260, 22);
            this.textBoxSanBayDi.TabIndex = 15;
            // 
            // textBoxNgayGio
            // 
            this.textBoxNgayGio.Location = new System.Drawing.Point(205, 156);
            this.textBoxNgayGio.Name = "textBoxNgayGio";
            this.textBoxNgayGio.Size = new System.Drawing.Size(260, 22);
            this.textBoxNgayGio.TabIndex = 16;
            // 
            // textBoxMaHanhKhach
            // 
            this.textBoxMaHanhKhach.Location = new System.Drawing.Point(681, 79);
            this.textBoxMaHanhKhach.Name = "textBoxMaHanhKhach";
            this.textBoxMaHanhKhach.Size = new System.Drawing.Size(260, 22);
            this.textBoxMaHanhKhach.TabIndex = 17;
            // 
            // textBoxSanBayDen
            // 
            this.textBoxSanBayDen.Location = new System.Drawing.Point(205, 201);
            this.textBoxSanBayDen.Name = "textBoxSanBayDen";
            this.textBoxSanBayDen.Size = new System.Drawing.Size(260, 22);
            this.textBoxSanBayDen.TabIndex = 18;
            // 
            // textBoxTinhTrangVe
            // 
            this.textBoxTinhTrangVe.Location = new System.Drawing.Point(205, 246);
            this.textBoxTinhTrangVe.Name = "textBoxTinhTrangVe";
            this.textBoxTinhTrangVe.Size = new System.Drawing.Size(260, 22);
            this.textBoxTinhTrangVe.TabIndex = 19;
            // 
            // textBoxCMND
            // 
            this.textBoxCMND.Location = new System.Drawing.Point(681, 169);
            this.textBoxCMND.Name = "textBoxCMND";
            this.textBoxCMND.Size = new System.Drawing.Size(260, 22);
            this.textBoxCMND.TabIndex = 20;
            // 
            // textBoxTenHanhKhach
            // 
            this.textBoxTenHanhKhach.Location = new System.Drawing.Point(681, 124);
            this.textBoxTenHanhKhach.Name = "textBoxTenHanhKhach";
            this.textBoxTenHanhKhach.Size = new System.Drawing.Size(260, 22);
            this.textBoxTenHanhKhach.TabIndex = 21;
            // 
            // textBoxDienThoai
            // 
            this.textBoxDienThoai.Location = new System.Drawing.Point(681, 214);
            this.textBoxDienThoai.Name = "textBoxDienThoai";
            this.textBoxDienThoai.Size = new System.Drawing.Size(260, 22);
            this.textBoxDienThoai.TabIndex = 22;
            // 
            // labelTenKhach
            // 
            this.labelTenKhach.AutoSize = true;
            this.labelTenKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenKhach.Location = new System.Drawing.Point(520, 124);
            this.labelTenKhach.Name = "labelTenKhach";
            this.labelTenKhach.Size = new System.Drawing.Size(139, 20);
            this.labelTenKhach.TabIndex = 23;
            this.labelTenKhach.Text = "Tên Hành Khách:";
            // 
            // labelHangVe
            // 
            this.labelHangVe.AutoSize = true;
            this.labelHangVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHangVe.Location = new System.Drawing.Point(45, 291);
            this.labelHangVe.Name = "labelHangVe";
            this.labelHangVe.Size = new System.Drawing.Size(76, 20);
            this.labelHangVe.TabIndex = 24;
            this.labelHangVe.Text = "Hạng vé:";
            // 
            // labelNgayDatVe
            // 
            this.labelNgayDatVe.AutoSize = true;
            this.labelNgayDatVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayDatVe.Location = new System.Drawing.Point(45, 336);
            this.labelNgayDatVe.Name = "labelNgayDatVe";
            this.labelNgayDatVe.Size = new System.Drawing.Size(108, 20);
            this.labelNgayDatVe.TabIndex = 25;
            this.labelNgayDatVe.Text = "Ngày Đặt Vé:";
            // 
            // textBoxGiaTien
            // 
            this.textBoxGiaTien.Location = new System.Drawing.Point(205, 381);
            this.textBoxGiaTien.Name = "textBoxGiaTien";
            this.textBoxGiaTien.ReadOnly = true;
            this.textBoxGiaTien.Size = new System.Drawing.Size(260, 22);
            this.textBoxGiaTien.TabIndex = 27;
            // 
            // comboBoxMaChuyenBay
            // 
            this.comboBoxMaChuyenBay.FormattingEnabled = true;
            this.comboBoxMaChuyenBay.Location = new System.Drawing.Point(205, 66);
            this.comboBoxMaChuyenBay.Name = "comboBoxMaChuyenBay";
            this.comboBoxMaChuyenBay.Size = new System.Drawing.Size(260, 24);
            this.comboBoxMaChuyenBay.TabIndex = 28;
            // 
            // dateTimePickerNgayDatVe
            // 
            this.dateTimePickerNgayDatVe.Location = new System.Drawing.Point(205, 336);
            this.dateTimePickerNgayDatVe.Name = "dateTimePickerNgayDatVe";
            this.dateTimePickerNgayDatVe.Size = new System.Drawing.Size(260, 22);
            this.dateTimePickerNgayDatVe.TabIndex = 29;
            // 
            // dataGridViewPhieuDatCho
            // 
            this.dataGridViewPhieuDatCho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPhieuDatCho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhieuDatCho.Location = new System.Drawing.Point(510, 257);
            this.dataGridViewPhieuDatCho.Name = "dataGridViewPhieuDatCho";
            this.dataGridViewPhieuDatCho.RowHeadersWidth = 51;
            this.dataGridViewPhieuDatCho.RowTemplate.Height = 24;
            this.dataGridViewPhieuDatCho.Size = new System.Drawing.Size(479, 297);
            this.dataGridViewPhieuDatCho.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(616, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Thông tin khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "Thông tin chuyến bay";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(82, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(295, 92);
            this.button1.TabIndex = 33;
            this.button1.Text = "Tạo vé";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBoxHangVe
            // 
            this.comboBoxHangVe.FormattingEnabled = true;
            this.comboBoxHangVe.Location = new System.Drawing.Point(205, 291);
            this.comboBoxHangVe.Name = "comboBoxHangVe";
            this.comboBoxHangVe.Size = new System.Drawing.Size(260, 24);
            this.comboBoxHangVe.TabIndex = 34;
            // 
            // FrmDatCho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 655);
            this.Controls.Add(this.comboBoxHangVe);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewPhieuDatCho);
            this.Controls.Add(this.dateTimePickerNgayDatVe);
            this.Controls.Add(this.comboBoxMaChuyenBay);
            this.Controls.Add(this.textBoxGiaTien);
            this.Controls.Add(this.labelNgayDatVe);
            this.Controls.Add(this.labelHangVe);
            this.Controls.Add(this.labelTenKhach);
            this.Controls.Add(this.textBoxDienThoai);
            this.Controls.Add(this.textBoxTenHanhKhach);
            this.Controls.Add(this.textBoxCMND);
            this.Controls.Add(this.textBoxTinhTrangVe);
            this.Controls.Add(this.textBoxSanBayDen);
            this.Controls.Add(this.textBoxMaHanhKhach);
            this.Controls.Add(this.textBoxNgayGio);
            this.Controls.Add(this.textBoxSanBayDi);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonTaoMoi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelSanBayDen);
            this.Controls.Add(this.labelGiaTien);
            this.Controls.Add(this.labelMaKhach);
            this.Controls.Add(this.labelNgayGio);
            this.Controls.Add(this.labelSanBayDi);
            this.Controls.Add(this.labelMaChuyenBay);
            this.Controls.Add(this.buttonThoat);
            this.Name = "FrmDatCho";
            this.Text = "ĐẶT CHỖ CHUYẾN BAY";
            this.Load += new System.EventHandler(this.Formtab3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhieuDatCho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Label labelMaChuyenBay;
        private System.Windows.Forms.Label labelSanBayDi;
        private System.Windows.Forms.Label labelNgayGio;
        private System.Windows.Forms.Label labelMaKhach;
        private System.Windows.Forms.Label labelGiaTien;
        private System.Windows.Forms.Label labelSanBayDen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonTaoMoi;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.TextBox textBoxSanBayDi;
        private System.Windows.Forms.TextBox textBoxNgayGio;
        private System.Windows.Forms.TextBox textBoxMaHanhKhach;
        private System.Windows.Forms.TextBox textBoxSanBayDen;
        private System.Windows.Forms.TextBox textBoxTinhTrangVe;
        private System.Windows.Forms.TextBox textBoxCMND;
        private System.Windows.Forms.TextBox textBoxTenHanhKhach;
        private System.Windows.Forms.TextBox textBoxDienThoai;
        private System.Windows.Forms.Label labelTenKhach;
        private System.Windows.Forms.Label labelHangVe;
        private System.Windows.Forms.Label labelNgayDatVe;
        private System.Windows.Forms.TextBox textBoxGiaTien;
        private System.Windows.Forms.ComboBox comboBoxMaChuyenBay;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayDatVe;
        private System.Windows.Forms.DataGridView dataGridViewPhieuDatCho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxHangVe;
    }
}