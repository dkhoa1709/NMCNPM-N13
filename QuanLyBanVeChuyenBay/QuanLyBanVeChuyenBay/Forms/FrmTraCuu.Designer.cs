
namespace QuanLyBanVeChuyenBay.Forms
{
    partial class FrmTraCuu
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
            this.buttonDanhSach = new System.Windows.Forms.Button();
            this.buttonTimKiem = new System.Windows.Forms.Button();
            this.panelFill = new System.Windows.Forms.Panel();
            this.dateTimePickerNgayDatVe = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSanBayDen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSanBayDi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelView = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDanhSach
            // 
            this.buttonDanhSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDanhSach.Location = new System.Drawing.Point(413, 260);
            this.buttonDanhSach.Name = "buttonDanhSach";
            this.buttonDanhSach.Size = new System.Drawing.Size(150, 40);
            this.buttonDanhSach.TabIndex = 1;
            this.buttonDanhSach.Text = "Danh sách";
            this.buttonDanhSach.UseVisualStyleBackColor = true;
            // 
            // buttonTimKiem
            // 
            this.buttonTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimKiem.Location = new System.Drawing.Point(198, 260);
            this.buttonTimKiem.Name = "buttonTimKiem";
            this.buttonTimKiem.Size = new System.Drawing.Size(150, 40);
            this.buttonTimKiem.TabIndex = 5;
            this.buttonTimKiem.Text = "Tìm kiếm";
            this.buttonTimKiem.UseVisualStyleBackColor = true;
            // 
            // panelFill
            // 
            this.panelFill.BackColor = System.Drawing.Color.White;
            this.panelFill.Controls.Add(this.dateTimePickerNgayDatVe);
            this.panelFill.Controls.Add(this.buttonTimKiem);
            this.panelFill.Controls.Add(this.pictureBox1);
            this.panelFill.Controls.Add(this.label3);
            this.panelFill.Controls.Add(this.textBoxSanBayDen);
            this.panelFill.Controls.Add(this.label2);
            this.panelFill.Controls.Add(this.buttonDanhSach);
            this.panelFill.Controls.Add(this.textBoxSanBayDi);
            this.panelFill.Controls.Add(this.label1);
            this.panelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill.ForeColor = System.Drawing.Color.Black;
            this.panelFill.Location = new System.Drawing.Point(0, 0);
            this.panelFill.Name = "panelFill";
            this.panelFill.Size = new System.Drawing.Size(1182, 653);
            this.panelFill.TabIndex = 8;
            // 
            // dateTimePickerNgayDatVe
            // 
            this.dateTimePickerNgayDatVe.Location = new System.Drawing.Point(303, 180);
            this.dateTimePickerNgayDatVe.Name = "dateTimePickerNgayDatVe";
            this.dateTimePickerNgayDatVe.Size = new System.Drawing.Size(260, 22);
            this.dateTimePickerNgayDatVe.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyBanVeChuyenBay.Properties.Resources.rose;
            this.pictureBox1.Location = new System.Drawing.Point(689, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(388, 295);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(140, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày - Giờ:";
            // 
            // textBoxSanBayDen
            // 
            this.textBoxSanBayDen.Location = new System.Drawing.Point(303, 120);
            this.textBoxSanBayDen.Name = "textBoxSanBayDen";
            this.textBoxSanBayDen.Size = new System.Drawing.Size(260, 22);
            this.textBoxSanBayDen.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sân bay đến:";
            // 
            // textBoxSanBayDi
            // 
            this.textBoxSanBayDi.Location = new System.Drawing.Point(303, 60);
            this.textBoxSanBayDi.Name = "textBoxSanBayDi";
            this.textBoxSanBayDi.Size = new System.Drawing.Size(260, 22);
            this.textBoxSanBayDi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sân bay đi:";
            // 
            // panelView
            // 
            this.panelView.Controls.Add(this.dataGridView1);
            this.panelView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelView.Location = new System.Drawing.Point(0, 385);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(1182, 268);
            this.panelView.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1182, 268);
            this.dataGridView1.TabIndex = 0;
            // 
            // FrmTraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.panelFill);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmTraCuu";
            this.Text = "TRA CỨU CHUYẾN BAY";
            this.Load += new System.EventHandler(this.Formtab4_Load);
            this.panelFill.ResumeLayout(false);
            this.panelFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDanhSach;
        private System.Windows.Forms.Button buttonTimKiem;
        private System.Windows.Forms.Panel panelFill;
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSanBayDen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSanBayDi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayDatVe;
    }
}