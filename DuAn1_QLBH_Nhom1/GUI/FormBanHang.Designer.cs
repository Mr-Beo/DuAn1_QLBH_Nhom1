namespace DuAn1_QLBH_Nhom1.GUI
{
    partial class FormBanHang
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
            txt_timkiemdssp = new TextBox();
            dtg_dssp = new DataGridView();
            grb_dssp = new GroupBox();
            textBox1 = new TextBox();
            btn_luutam = new Button();
            btn_suasl = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            grb_thongtin = new GroupBox();
            btn_lammoi = new Button();
            btn_thanhtoan = new Button();
            txt_tientralai = new TextBox();
            label6 = new Label();
            txt_tienkhach = new TextBox();
            label5 = new Label();
            txt_tongtien = new TextBox();
            label4 = new Label();
            cb_nguoidung = new ComboBox();
            label3 = new Label();
            cbb_apdung = new ComboBox();
            cb_apdung = new CheckBox();
            cbb_khachhang = new ComboBox();
            label2 = new Label();
            txt_mahd = new TextBox();
            label1 = new Label();
            grb_spmua = new GroupBox();
            dtg_spmua = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtg_dssp).BeginInit();
            grb_dssp.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            grb_thongtin.SuspendLayout();
            grb_spmua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_spmua).BeginInit();
            SuspendLayout();
            // 
            // txt_timkiemdssp
            // 
            txt_timkiemdssp.Location = new Point(183, 16);
            txt_timkiemdssp.Name = "txt_timkiemdssp";
            txt_timkiemdssp.PlaceholderText = "Tìm kiếm theo tên hoặc mã";
            txt_timkiemdssp.Size = new Size(500, 27);
            txt_timkiemdssp.TabIndex = 0;
            // 
            // dtg_dssp
            // 
            dtg_dssp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_dssp.Location = new Point(11, 26);
            dtg_dssp.Name = "dtg_dssp";
            dtg_dssp.RowHeadersWidth = 51;
            dtg_dssp.RowTemplate.Height = 29;
            dtg_dssp.Size = new Size(1197, 192);
            dtg_dssp.TabIndex = 1;
            // 
            // grb_dssp
            // 
            grb_dssp.Controls.Add(dtg_dssp);
            grb_dssp.Location = new Point(7, 40);
            grb_dssp.Name = "grb_dssp";
            grb_dssp.Size = new Size(1219, 225);
            grb_dssp.TabIndex = 2;
            grb_dssp.TabStop = false;
            grb_dssp.Text = "Danh Sách Sản Phẩm";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(166, 327);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Tìm kiếm theo tên hoặc mã";
            textBox1.Size = new Size(517, 27);
            textBox1.TabIndex = 3;
            // 
            // btn_luutam
            // 
            btn_luutam.Location = new Point(134, 271);
            btn_luutam.Name = "btn_luutam";
            btn_luutam.Size = new Size(100, 38);
            btn_luutam.TabIndex = 4;
            btn_luutam.Text = "Lưu Tạm";
            btn_luutam.UseVisualStyleBackColor = true;
            // 
            // btn_suasl
            // 
            btn_suasl.Location = new Point(250, 271);
            btn_suasl.Name = "btn_suasl";
            btn_suasl.Size = new Size(100, 38);
            btn_suasl.TabIndex = 5;
            btn_suasl.Text = "Sửa ";
            btn_suasl.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(368, 271);
            button3.Name = "button3";
            button3.Size = new Size(100, 38);
            button3.TabIndex = 6;
            button3.Text = "Xoá";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(474, 271);
            button4.Name = "button4";
            button4.Size = new Size(168, 38);
            button4.TabIndex = 7;
            button4.Text = "Tạo hoá đơn chờ";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(648, 271);
            button5.Name = "button5";
            button5.Size = new Size(100, 38);
            button5.TabIndex = 8;
            button5.Text = "Huỷ";
            button5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(7, 360);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(811, 194);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh Sách Sản Phẩm";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(794, 159);
            dataGridView1.TabIndex = 1;
            // 
            // grb_thongtin
            // 
            grb_thongtin.Controls.Add(btn_lammoi);
            grb_thongtin.Controls.Add(btn_thanhtoan);
            grb_thongtin.Controls.Add(txt_tientralai);
            grb_thongtin.Controls.Add(label6);
            grb_thongtin.Controls.Add(txt_tienkhach);
            grb_thongtin.Controls.Add(label5);
            grb_thongtin.Controls.Add(txt_tongtien);
            grb_thongtin.Controls.Add(label4);
            grb_thongtin.Controls.Add(cb_nguoidung);
            grb_thongtin.Controls.Add(label3);
            grb_thongtin.Controls.Add(cbb_apdung);
            grb_thongtin.Controls.Add(cb_apdung);
            grb_thongtin.Controls.Add(cbb_khachhang);
            grb_thongtin.Controls.Add(label2);
            grb_thongtin.Controls.Add(txt_mahd);
            grb_thongtin.Controls.Add(label1);
            grb_thongtin.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            grb_thongtin.Location = new Point(824, 271);
            grb_thongtin.Name = "grb_thongtin";
            grb_thongtin.Size = new Size(402, 474);
            grb_thongtin.TabIndex = 9;
            grb_thongtin.TabStop = false;
            grb_thongtin.Text = "Thông tin";
            // 
            // btn_lammoi
            // 
            btn_lammoi.Location = new Point(18, 424);
            btn_lammoi.Name = "btn_lammoi";
            btn_lammoi.Size = new Size(149, 45);
            btn_lammoi.TabIndex = 24;
            btn_lammoi.Text = "Làm Mới";
            btn_lammoi.UseVisualStyleBackColor = true;
            // 
            // btn_thanhtoan
            // 
            btn_thanhtoan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_thanhtoan.Location = new Point(221, 423);
            btn_thanhtoan.Name = "btn_thanhtoan";
            btn_thanhtoan.Size = new Size(164, 45);
            btn_thanhtoan.TabIndex = 25;
            btn_thanhtoan.Text = "Thanh Toán";
            btn_thanhtoan.UseVisualStyleBackColor = true;
            // 
            // txt_tientralai
            // 
            txt_tientralai.Location = new Point(194, 356);
            txt_tientralai.Multiline = true;
            txt_tientralai.Name = "txt_tientralai";
            txt_tientralai.Size = new Size(197, 35);
            txt_tientralai.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(6, 366);
            label6.Name = "label6";
            label6.Size = new Size(97, 25);
            label6.TabIndex = 22;
            label6.Text = "Tiền Trả Lại";
            // 
            // txt_tienkhach
            // 
            txt_tienkhach.Location = new Point(194, 295);
            txt_tienkhach.Multiline = true;
            txt_tienkhach.Name = "txt_tienkhach";
            txt_tienkhach.Size = new Size(197, 35);
            txt_tienkhach.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 305);
            label5.Name = "label5";
            label5.Size = new Size(134, 25);
            label5.TabIndex = 20;
            label5.Text = "Tiền Khách Đưa";
            // 
            // txt_tongtien
            // 
            txt_tongtien.Location = new Point(194, 239);
            txt_tongtien.Multiline = true;
            txt_tongtien.Name = "txt_tongtien";
            txt_tongtien.Size = new Size(197, 35);
            txt_tongtien.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 249);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 18;
            label4.Text = "Tổng Tiền";
            // 
            // cb_nguoidung
            // 
            cb_nguoidung.FormattingEnabled = true;
            cb_nguoidung.Location = new Point(194, 190);
            cb_nguoidung.Name = "cb_nguoidung";
            cb_nguoidung.Size = new Size(197, 33);
            cb_nguoidung.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 198);
            label3.Name = "label3";
            label3.Size = new Size(127, 25);
            label3.TabIndex = 16;
            label3.Text = "Nhân Viên Bán";
            // 
            // cbb_apdung
            // 
            cbb_apdung.FormattingEnabled = true;
            cbb_apdung.Location = new Point(194, 140);
            cbb_apdung.Name = "cbb_apdung";
            cbb_apdung.Size = new Size(191, 33);
            cbb_apdung.TabIndex = 15;
            // 
            // cb_apdung
            // 
            cb_apdung.AutoSize = true;
            cb_apdung.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cb_apdung.Location = new Point(6, 149);
            cb_apdung.Name = "cb_apdung";
            cb_apdung.Size = new Size(192, 24);
            cb_apdung.TabIndex = 14;
            cb_apdung.Text = "Áp dụng mã khuyến mãi";
            cb_apdung.UseVisualStyleBackColor = true;
            // 
            // cbb_khachhang
            // 
            cbb_khachhang.FormattingEnabled = true;
            cbb_khachhang.Location = new Point(194, 89);
            cbb_khachhang.Name = "cbb_khachhang";
            cbb_khachhang.Size = new Size(197, 33);
            cbb_khachhang.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 97);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 12;
            label2.Text = "Khách Hàng";
            // 
            // txt_mahd
            // 
            txt_mahd.Location = new Point(194, 36);
            txt_mahd.Multiline = true;
            txt_mahd.Name = "txt_mahd";
            txt_mahd.Size = new Size(164, 35);
            txt_mahd.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 46);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 10;
            label1.Text = "Mã Hoá Đơn";
            // 
            // grb_spmua
            // 
            grb_spmua.Controls.Add(dtg_spmua);
            grb_spmua.Location = new Point(7, 569);
            grb_spmua.Name = "grb_spmua";
            grb_spmua.Size = new Size(806, 176);
            grb_spmua.TabIndex = 4;
            grb_spmua.TabStop = false;
            grb_spmua.Text = "Sản Phẩm Mua";
            // 
            // dtg_spmua
            // 
            dtg_spmua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_spmua.Location = new Point(6, 26);
            dtg_spmua.Name = "dtg_spmua";
            dtg_spmua.RowHeadersWidth = 51;
            dtg_spmua.RowTemplate.Height = 29;
            dtg_spmua.Size = new Size(794, 140);
            dtg_spmua.TabIndex = 1;
            // 
            // FormBanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 753);
            Controls.Add(grb_spmua);
            Controls.Add(textBox1);
            Controls.Add(grb_thongtin);
            Controls.Add(btn_suasl);
            Controls.Add(groupBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btn_luutam);
            Controls.Add(txt_timkiemdssp);
            Controls.Add(grb_dssp);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormBanHang";
            Text = "FormBanHang";
            ((System.ComponentModel.ISupportInitialize)dtg_dssp).EndInit();
            grb_dssp.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            grb_thongtin.ResumeLayout(false);
            grb_thongtin.PerformLayout();
            grb_spmua.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_spmua).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_timkiemdssp;
        private DataGridView dtg_dssp;
        private GroupBox grb_dssp;
        private TextBox textBox1;
        private Button btn_luutam;
        private Button btn_suasl;
        private Button button3;
        private Button button4;
        private Button button5;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private GroupBox grb_thongtin;
        private ComboBox cbb_khachhang;
        private Label label2;
        private TextBox txt_mahd;
        private Label label1;
        private ComboBox cb_nguoidung;
        private Label label3;
        private ComboBox cbb_apdung;
        private CheckBox cb_apdung;
        private Button btn_lammoi;
        private TextBox txt_tientralai;
        private Label label6;
        private TextBox txt_tienkhach;
        private Label label5;
        private TextBox txt_tongtien;
        private Label label4;
        private Button btn_thanhtoan;
        private GroupBox grb_spmua;
        private DataGridView dtg_spmua;
    }
}