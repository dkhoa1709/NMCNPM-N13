
namespace QuanLyBanVeChuyenBay.Forms
{
    partial class FrmLichChuyenBay
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelThoiGianBay = new System.Windows.Forms.Label();
            this.labelSanBayDen = new System.Windows.Forms.Label();
            this.labelNgayGio = new System.Windows.Forms.Label();
            this.labelSanBayDi = new System.Windows.Forms.Label();
            this.labelMaChuyenBay = new System.Windows.Forms.Label();
            this.textBoxThoiGianBay = new System.Windows.Forms.TextBox();
            this.panelThoiGIanBay = new System.Windows.Forms.Panel();
            this.textBoxSanBayDen = new System.Windows.Forms.TextBox();
            this.panelNgayGio = new System.Windows.Forms.Panel();
            this.textBoxNgayGio = new System.Windows.Forms.TextBox();
            this.panelSanBayDen = new System.Windows.Forms.Panel();
            this.textBoxSanBayDi = new System.Windows.Forms.TextBox();
            this.panelSanBayDi = new System.Windows.Forms.Panel();
            this.textBoxMaChuyenBay = new System.Windows.Forms.TextBox();
            this.panelMaChuyenBay = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.groupBox2);
            this.panelMain.Controls.Add(this.groupBox1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMain.ForeColor = System.Drawing.Color.Black;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1044, 435);
            this.panelMain.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.buttonSua);
            this.groupBox2.Controls.Add(this.buttonXoa);
            this.groupBox2.Controls.Add(this.buttonThem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(170, 311);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(704, 98);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // buttonSua
            // 
            this.buttonSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSua.Location = new System.Drawing.Point(527, 29);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(150, 40);
            this.buttonSua.TabIndex = 8;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            // 
            // buttonXoa
            // 
            this.buttonXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.Location = new System.Drawing.Point(277, 29);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(150, 40);
            this.buttonXoa.TabIndex = 7;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            // 
            // buttonThem
            // 
            this.buttonThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Location = new System.Drawing.Point(27, 29);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(150, 40);
            this.buttonThem.TabIndex = 6;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.labelThoiGianBay);
            this.groupBox1.Controls.Add(this.labelSanBayDen);
            this.groupBox1.Controls.Add(this.labelNgayGio);
            this.groupBox1.Controls.Add(this.labelSanBayDi);
            this.groupBox1.Controls.Add(this.labelMaChuyenBay);
            this.groupBox1.Controls.Add(this.textBoxThoiGianBay);
            this.groupBox1.Controls.Add(this.panelThoiGIanBay);
            this.groupBox1.Controls.Add(this.textBoxSanBayDen);
            this.groupBox1.Controls.Add(this.panelNgayGio);
            this.groupBox1.Controls.Add(this.textBoxNgayGio);
            this.groupBox1.Controls.Add(this.panelSanBayDen);
            this.groupBox1.Controls.Add(this.textBoxSanBayDi);
            this.groupBox1.Controls.Add(this.panelSanBayDi);
            this.groupBox1.Controls.Add(this.textBoxMaChuyenBay);
            this.groupBox1.Controls.Add(this.panelMaChuyenBay);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(170, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 279);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // labelThoiGianBay
            // 
            this.labelThoiGianBay.AutoSize = true;
            this.labelThoiGianBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThoiGianBay.Location = new System.Drawing.Point(145, 217);
            this.labelThoiGianBay.Name = "labelThoiGianBay";
            this.labelThoiGianBay.Size = new System.Drawing.Size(113, 20);
            this.labelThoiGianBay.TabIndex = 34;
            this.labelThoiGianBay.Text = "Thời gian bay:";
            // 
            // labelSanBayDen
            // 
            this.labelSanBayDen.AutoSize = true;
            this.labelSanBayDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSanBayDen.Location = new System.Drawing.Point(152, 172);
            this.labelSanBayDen.Name = "labelSanBayDen";
            this.labelSanBayDen.Size = new System.Drawing.Size(106, 20);
            this.labelSanBayDen.TabIndex = 30;
            this.labelSanBayDen.Text = "Sân bay đến:";
            // 
            // labelNgayGio
            // 
            this.labelNgayGio.AutoSize = true;
            this.labelNgayGio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayGio.Location = new System.Drawing.Point(164, 127);
            this.labelNgayGio.Name = "labelNgayGio";
            this.labelNgayGio.Size = new System.Drawing.Size(94, 20);
            this.labelNgayGio.TabIndex = 31;
            this.labelNgayGio.Text = "Ngày - Giờ:";
            // 
            // labelSanBayDi
            // 
            this.labelSanBayDi.AutoSize = true;
            this.labelSanBayDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSanBayDi.Location = new System.Drawing.Point(166, 82);
            this.labelSanBayDi.Name = "labelSanBayDi";
            this.labelSanBayDi.Size = new System.Drawing.Size(92, 20);
            this.labelSanBayDi.TabIndex = 32;
            this.labelSanBayDi.Text = "Sân bay đi:";
            // 
            // labelMaChuyenBay
            // 
            this.labelMaChuyenBay.AutoSize = true;
            this.labelMaChuyenBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaChuyenBay.Location = new System.Drawing.Point(132, 37);
            this.labelMaChuyenBay.Name = "labelMaChuyenBay";
            this.labelMaChuyenBay.Size = new System.Drawing.Size(126, 20);
            this.labelMaChuyenBay.TabIndex = 33;
            this.labelMaChuyenBay.Text = "Mã chuyến bay:";
            // 
            // textBoxThoiGianBay
            // 
            this.textBoxThoiGianBay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxThoiGianBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxThoiGianBay.Location = new System.Drawing.Point(305, 217);
            this.textBoxThoiGianBay.Multiline = true;
            this.textBoxThoiGianBay.Name = "textBoxThoiGianBay";
            this.textBoxThoiGianBay.Size = new System.Drawing.Size(260, 24);
            this.textBoxThoiGianBay.TabIndex = 5;
            // 
            // panelThoiGIanBay
            // 
            this.panelThoiGIanBay.BackColor = System.Drawing.Color.Black;
            this.panelThoiGIanBay.Location = new System.Drawing.Point(305, 241);
            this.panelThoiGIanBay.Name = "panelThoiGIanBay";
            this.panelThoiGIanBay.Size = new System.Drawing.Size(260, 1);
            this.panelThoiGIanBay.TabIndex = 20;
            // 
            // textBoxSanBayDen
            // 
            this.textBoxSanBayDen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSanBayDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSanBayDen.Location = new System.Drawing.Point(305, 172);
            this.textBoxSanBayDen.Multiline = true;
            this.textBoxSanBayDen.Name = "textBoxSanBayDen";
            this.textBoxSanBayDen.Size = new System.Drawing.Size(260, 24);
            this.textBoxSanBayDen.TabIndex = 4;
            // 
            // panelNgayGio
            // 
            this.panelNgayGio.BackColor = System.Drawing.Color.Black;
            this.panelNgayGio.Location = new System.Drawing.Point(305, 151);
            this.panelNgayGio.Name = "panelNgayGio";
            this.panelNgayGio.Size = new System.Drawing.Size(260, 1);
            this.panelNgayGio.TabIndex = 21;
            // 
            // textBoxNgayGio
            // 
            this.textBoxNgayGio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNgayGio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNgayGio.Location = new System.Drawing.Point(305, 127);
            this.textBoxNgayGio.Multiline = true;
            this.textBoxNgayGio.Name = "textBoxNgayGio";
            this.textBoxNgayGio.Size = new System.Drawing.Size(260, 24);
            this.textBoxNgayGio.TabIndex = 3;
            // 
            // panelSanBayDen
            // 
            this.panelSanBayDen.BackColor = System.Drawing.Color.Black;
            this.panelSanBayDen.Location = new System.Drawing.Point(305, 197);
            this.panelSanBayDen.Name = "panelSanBayDen";
            this.panelSanBayDen.Size = new System.Drawing.Size(260, 1);
            this.panelSanBayDen.TabIndex = 22;
            // 
            // textBoxSanBayDi
            // 
            this.textBoxSanBayDi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSanBayDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSanBayDi.Location = new System.Drawing.Point(305, 82);
            this.textBoxSanBayDi.Multiline = true;
            this.textBoxSanBayDi.Name = "textBoxSanBayDi";
            this.textBoxSanBayDi.Size = new System.Drawing.Size(260, 24);
            this.textBoxSanBayDi.TabIndex = 2;
            // 
            // panelSanBayDi
            // 
            this.panelSanBayDi.BackColor = System.Drawing.Color.Black;
            this.panelSanBayDi.Location = new System.Drawing.Point(305, 107);
            this.panelSanBayDi.Name = "panelSanBayDi";
            this.panelSanBayDi.Size = new System.Drawing.Size(260, 1);
            this.panelSanBayDi.TabIndex = 23;
            // 
            // textBoxMaChuyenBay
            // 
            this.textBoxMaChuyenBay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMaChuyenBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaChuyenBay.Location = new System.Drawing.Point(305, 37);
            this.textBoxMaChuyenBay.Multiline = true;
            this.textBoxMaChuyenBay.Name = "textBoxMaChuyenBay";
            this.textBoxMaChuyenBay.Size = new System.Drawing.Size(260, 24);
            this.textBoxMaChuyenBay.TabIndex = 1;
            // 
            // panelMaChuyenBay
            // 
            this.panelMaChuyenBay.BackColor = System.Drawing.Color.Black;
            this.panelMaChuyenBay.Location = new System.Drawing.Point(305, 61);
            this.panelMaChuyenBay.Name = "panelMaChuyenBay";
            this.panelMaChuyenBay.Size = new System.Drawing.Size(260, 1);
            this.panelMaChuyenBay.TabIndex = 24;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1044, 227);
            this.dataGridView1.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 435);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1044, 227);
            this.panel3.TabIndex = 17;
            // 
            // FrmLichChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1044, 662);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelMain);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmLichChuyenBay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NHẬN LỊCH CHUYẾN BAY";
            this.panelMain.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxThoiGianBay;
        private System.Windows.Forms.Panel panelThoiGIanBay;
        private System.Windows.Forms.TextBox textBoxSanBayDen;
        private System.Windows.Forms.Panel panelNgayGio;
        private System.Windows.Forms.TextBox textBoxNgayGio;
        private System.Windows.Forms.Panel panelSanBayDen;
        private System.Windows.Forms.TextBox textBoxSanBayDi;
        private System.Windows.Forms.Panel panelSanBayDi;
        private System.Windows.Forms.TextBox textBoxMaChuyenBay;
        private System.Windows.Forms.Panel panelMaChuyenBay;
        private System.Windows.Forms.Label labelThoiGianBay;
        private System.Windows.Forms.Label labelSanBayDen;
        private System.Windows.Forms.Label labelNgayGio;
        private System.Windows.Forms.Label labelSanBayDi;
        private System.Windows.Forms.Label labelMaChuyenBay;
    }
}