namespace DuAn1_QLBH_Nhom1.GUI
{
    partial class FormKhachHang
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
            txt_timkiem = new TextBox();
            btn_timkiem = new Button();
            groupBox1 = new GroupBox();
            dtg_dskh = new DataGridView();
            groupBox2 = new GroupBox();
            btn_lammoi = new Button();
            btn_xoa = new Button();
            btn_sua = new Button();
            btn_them = new Button();
            txt_diachi = new TextBox();
            label4 = new Label();
            txt_sodienthoai = new TextBox();
            label3 = new Label();
            txt_ngaysinh = new TextBox();
            label2 = new Label();
            txt_hoten = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_dskh).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txt_timkiem
            // 
            txt_timkiem.Location = new Point(141, 12);
            txt_timkiem.Name = "txt_timkiem";
            txt_timkiem.PlaceholderText = "Tìm kiếm theo tên và mã";
            txt_timkiem.Size = new Size(469, 27);
            txt_timkiem.TabIndex = 0;
            // 
            // btn_timkiem
            // 
            btn_timkiem.Location = new Point(638, 12);
            btn_timkiem.Name = "btn_timkiem";
            btn_timkiem.Size = new Size(94, 29);
            btn_timkiem.TabIndex = 1;
            btn_timkiem.Text = "Tìm kiếm";
            btn_timkiem.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtg_dskh);
            groupBox1.Location = new Point(1, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(837, 658);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách khách hàng";
            // 
            // dtg_dskh
            // 
            dtg_dskh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_dskh.Location = new Point(3, 23);
            dtg_dskh.Name = "dtg_dskh";
            dtg_dskh.RowHeadersWidth = 51;
            dtg_dskh.RowTemplate.Height = 29;
            dtg_dskh.Size = new Size(828, 629);
            dtg_dskh.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_lammoi);
            groupBox2.Controls.Add(btn_xoa);
            groupBox2.Controls.Add(btn_sua);
            groupBox2.Controls.Add(btn_them);
            groupBox2.Controls.Add(txt_diachi);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txt_sodienthoai);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txt_ngaysinh);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txt_hoten);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(844, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(376, 691);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin";
            // 
            // btn_lammoi
            // 
            btn_lammoi.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_lammoi.Location = new Point(247, 623);
            btn_lammoi.Name = "btn_lammoi";
            btn_lammoi.Size = new Size(123, 45);
            btn_lammoi.TabIndex = 11;
            btn_lammoi.Text = "Làm Mới";
            btn_lammoi.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            btn_xoa.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_xoa.Location = new Point(6, 623);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(123, 45);
            btn_xoa.TabIndex = 10;
            btn_xoa.Text = "Xoá";
            btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            btn_sua.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_sua.Location = new Point(247, 531);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(123, 45);
            btn_sua.TabIndex = 9;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            btn_them.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_them.Location = new Point(6, 531);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(123, 45);
            btn_them.TabIndex = 8;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            // 
            // txt_diachi
            // 
            txt_diachi.Location = new Point(6, 307);
            txt_diachi.Multiline = true;
            txt_diachi.Name = "txt_diachi";
            txt_diachi.Size = new Size(364, 36);
            txt_diachi.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 281);
            label4.Name = "label4";
            label4.Size = new Size(65, 23);
            label4.TabIndex = 6;
            label4.Text = "Địa Chỉ";
            // 
            // txt_sodienthoai
            // 
            txt_sodienthoai.Location = new Point(6, 221);
            txt_sodienthoai.Multiline = true;
            txt_sodienthoai.Name = "txt_sodienthoai";
            txt_sodienthoai.Size = new Size(364, 36);
            txt_sodienthoai.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 195);
            label3.Name = "label3";
            label3.Size = new Size(116, 23);
            label3.TabIndex = 4;
            label3.Text = "Số Điện Thoại";
            // 
            // txt_ngaysinh
            // 
            txt_ngaysinh.Location = new Point(6, 133);
            txt_ngaysinh.Multiline = true;
            txt_ngaysinh.Name = "txt_ngaysinh";
            txt_ngaysinh.Size = new Size(364, 36);
            txt_ngaysinh.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 107);
            label2.Name = "label2";
            label2.Size = new Size(88, 23);
            label2.TabIndex = 2;
            label2.Text = "Ngày Sinh";
            // 
            // txt_hoten
            // 
            txt_hoten.Location = new Point(6, 59);
            txt_hoten.Multiline = true;
            txt_hoten.Name = "txt_hoten";
            txt_hoten.Size = new Size(364, 36);
            txt_hoten.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 33);
            label1.Name = "label1";
            label1.Size = new Size(84, 23);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên";
            // 
            // FormKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 703);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btn_timkiem);
            Controls.Add(txt_timkiem);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormKhachHang";
            Text = "FormKhachHang";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_dskh).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_timkiem;
        private Button btn_timkiem;
        private GroupBox groupBox1;
        private DataGridView dtg_dskh;
        private GroupBox groupBox2;
        private TextBox txt_diachi;
        private Label label4;
        private TextBox txt_sodienthoai;
        private Label label3;
        private TextBox txt_ngaysinh;
        private Label label2;
        private TextBox txt_hoten;
        private Label label1;
        private Button btn_lammoi;
        private Button btn_xoa;
        private Button btn_sua;
        private Button btn_them;
    }
}