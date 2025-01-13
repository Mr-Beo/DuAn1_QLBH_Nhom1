namespace DuAn1_QLBH_Nhom1.GUI
{
    partial class FormNhanVien
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
            label1 = new Label();
            groupBox2 = new GroupBox();
            cbb_chucvu = new ComboBox();
            label8 = new Label();
            textBox2 = new TextBox();
            txt_mk = new Label();
            txt_tdn = new TextBox();
            label7 = new Label();
            rd_nu = new RadioButton();
            rd_nam = new RadioButton();
            label6 = new Label();
            txt_email = new TextBox();
            label5 = new Label();
            txt_hoten = new TextBox();
            dtg_dsnv = new DataGridView();
            groupBox1 = new GroupBox();
            btn_timkiem = new Button();
            txt_timkiem = new TextBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_dsnv).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_lammoi
            // 
            btn_lammoi.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_lammoi.Location = new Point(247, 665);
            btn_lammoi.Name = "btn_lammoi";
            btn_lammoi.Size = new Size(123, 45);
            btn_lammoi.TabIndex = 11;
            btn_lammoi.Text = "Làm Mới";
            btn_lammoi.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            btn_xoa.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_xoa.Location = new Point(6, 665);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(123, 45);
            btn_xoa.TabIndex = 10;
            btn_xoa.Text = "Xoá";
            btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            btn_sua.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_sua.Location = new Point(247, 602);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(123, 45);
            btn_sua.TabIndex = 9;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            btn_them.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_them.Location = new Point(6, 602);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(123, 45);
            btn_them.TabIndex = 8;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            // 
            // txt_diachi
            // 
            txt_diachi.Location = new Point(6, 182);
            txt_diachi.Multiline = true;
            txt_diachi.Name = "txt_diachi";
            txt_diachi.Size = new Size(349, 36);
            txt_diachi.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 156);
            label4.Name = "label4";
            label4.Size = new Size(65, 23);
            label4.TabIndex = 6;
            label4.Text = "Địa Chỉ";
            // 
            // txt_sodienthoai
            // 
            txt_sodienthoai.Location = new Point(6, 310);
            txt_sodienthoai.Multiline = true;
            txt_sodienthoai.Name = "txt_sodienthoai";
            txt_sodienthoai.Size = new Size(349, 36);
            txt_sodienthoai.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 284);
            label3.Name = "label3";
            label3.Size = new Size(116, 23);
            label3.TabIndex = 4;
            label3.Text = "Số Điện Thoại";
            // 
            // txt_ngaysinh
            // 
            txt_ngaysinh.Location = new Point(6, 115);
            txt_ngaysinh.Multiline = true;
            txt_ngaysinh.Name = "txt_ngaysinh";
            txt_ngaysinh.Size = new Size(349, 36);
            txt_ngaysinh.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 89);
            label2.Name = "label2";
            label2.Size = new Size(88, 23);
            label2.TabIndex = 2;
            label2.Text = "Ngày Sinh";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 22);
            label1.Name = "label1";
            label1.Size = new Size(84, 23);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbb_chucvu);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(txt_mk);
            groupBox2.Controls.Add(txt_tdn);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(rd_nu);
            groupBox2.Controls.Add(rd_nam);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txt_email);
            groupBox2.Controls.Add(label5);
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
            groupBox2.Location = new Point(850, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(376, 744);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin";
            // 
            // cbb_chucvu
            // 
            cbb_chucvu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbb_chucvu.FormattingEnabled = true;
            cbb_chucvu.Location = new Point(108, 534);
            cbb_chucvu.Name = "cbb_chucvu";
            cbb_chucvu.Size = new Size(247, 36);
            cbb_chucvu.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(6, 542);
            label8.Name = "label8";
            label8.Size = new Size(75, 23);
            label8.TabIndex = 21;
            label8.Text = "Chức Vụ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 482);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(349, 36);
            textBox2.TabIndex = 20;
            // 
            // txt_mk
            // 
            txt_mk.AutoSize = true;
            txt_mk.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_mk.Location = new Point(6, 456);
            txt_mk.Name = "txt_mk";
            txt_mk.Size = new Size(84, 23);
            txt_mk.TabIndex = 19;
            txt_mk.Text = "Mật Khẩu";
            // 
            // txt_tdn
            // 
            txt_tdn.Location = new Point(6, 417);
            txt_tdn.Multiline = true;
            txt_tdn.Name = "txt_tdn";
            txt_tdn.Size = new Size(349, 36);
            txt_tdn.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(6, 384);
            label7.Name = "label7";
            label7.Size = new Size(129, 23);
            label7.TabIndex = 17;
            label7.Text = "Tên Đăng Nhập";
            // 
            // rd_nu
            // 
            rd_nu.AutoSize = true;
            rd_nu.Location = new Point(289, 349);
            rd_nu.Name = "rd_nu";
            rd_nu.Size = new Size(50, 24);
            rd_nu.TabIndex = 16;
            rd_nu.TabStop = true;
            rd_nu.Text = "Nữ";
            rd_nu.UseVisualStyleBackColor = true;
            // 
            // rd_nam
            // 
            rd_nam.AutoSize = true;
            rd_nam.Location = new Point(169, 349);
            rd_nam.Name = "rd_nam";
            rd_nam.Size = new Size(62, 24);
            rd_nam.TabIndex = 15;
            rd_nam.TabStop = true;
            rd_nam.Text = "Nam";
            rd_nam.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(6, 349);
            label6.Name = "label6";
            label6.Size = new Size(78, 23);
            label6.TabIndex = 14;
            label6.Text = "Giới Tính";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(6, 246);
            txt_email.Multiline = true;
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(349, 36);
            txt_email.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 220);
            label5.Name = "label5";
            label5.Size = new Size(51, 23);
            label5.TabIndex = 12;
            label5.Text = "Email";
            // 
            // txt_hoten
            // 
            txt_hoten.Location = new Point(6, 48);
            txt_hoten.Multiline = true;
            txt_hoten.Name = "txt_hoten";
            txt_hoten.Size = new Size(349, 36);
            txt_hoten.TabIndex = 1;
            // 
            // dtg_dsnv
            // 
            dtg_dsnv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_dsnv.Location = new Point(3, 23);
            dtg_dsnv.Name = "dtg_dsnv";
            dtg_dsnv.RowHeadersWidth = 51;
            dtg_dsnv.RowTemplate.Height = 29;
            dtg_dsnv.Size = new Size(828, 629);
            dtg_dsnv.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtg_dsnv);
            groupBox1.Location = new Point(7, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(837, 692);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách nhân viên";
            // 
            // btn_timkiem
            // 
            btn_timkiem.Location = new Point(644, 31);
            btn_timkiem.Name = "btn_timkiem";
            btn_timkiem.Size = new Size(94, 29);
            btn_timkiem.TabIndex = 5;
            btn_timkiem.Text = "Tìm kiếm";
            btn_timkiem.UseVisualStyleBackColor = true;
            // 
            // txt_timkiem
            // 
            txt_timkiem.Location = new Point(147, 31);
            txt_timkiem.Name = "txt_timkiem";
            txt_timkiem.PlaceholderText = "Tìm kiếm theo tên và mã";
            txt_timkiem.Size = new Size(469, 27);
            txt_timkiem.TabIndex = 3;
            // 
            // FormNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 753);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btn_timkiem);
            Controls.Add(txt_timkiem);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormNhanVien";
            Text = "FormNhanVien";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_dsnv).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_lammoi;
        private Button btn_xoa;
        private Button btn_sua;
        private Button btn_them;
        private TextBox txt_diachi;
        private Label label4;
        private TextBox txt_sodienthoai;
        private Label label3;
        private TextBox txt_ngaysinh;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private RadioButton rd_nu;
        private RadioButton rd_nam;
        private Label label6;
        private TextBox txt_email;
        private Label label5;
        private TextBox txt_hoten;
        private DataGridView dtg_dsnv;
        private GroupBox groupBox1;
        private Button btn_timkiem;
        private TextBox txt_timkiem;
        private ComboBox cbb_chucvu;
        private Label label8;
        private TextBox textBox2;
        private Label txt_mk;
        private TextBox txt_tdn;
        private Label label7;
    }
}