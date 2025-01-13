namespace DuAn1_QLBH_Nhom1.GUI
{
    partial class FormSanPham
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
            tc_sanpham = new TabControl();
            tabPage1 = new TabPage();
            txt_loaisp = new TextBox();
            button3 = new Button();
            btn_sua = new Button();
            btn_them = new Button();
            btn_lammoi = new Button();
            cb_ngung = new CheckBox();
            cb_dang = new CheckBox();
            label1 = new Label();
            lb_loaisp = new Label();
            tx_timkiemsp = new TextBox();
            dtg_danhsachsp = new DataGridView();
            tabPage2 = new TabPage();
            txt_size = new TextBox();
            txt_tensp = new TextBox();
            btn_lammoict = new Button();
            btn_xoact = new Button();
            btn_suact = new Button();
            btn_themct = new Button();
            btn_anh = new Button();
            pc_anh = new PictureBox();
            label8 = new Label();
            txt_giaban = new TextBox();
            label7 = new Label();
            txt_mausac = new TextBox();
            label6 = new Label();
            txt_soluong = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txt_chatlieu = new TextBox();
            cb_loaisp = new ComboBox();
            dtg_dsct = new DataGridView();
            txt_timkiemct = new TextBox();
            dataGridView2 = new DataGridView();
            tc_sanpham.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_danhsachsp).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pc_anh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_dsct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // tc_sanpham
            // 
            tc_sanpham.Controls.Add(tabPage1);
            tc_sanpham.Controls.Add(tabPage2);
            tc_sanpham.Location = new Point(0, 0);
            tc_sanpham.Name = "tc_sanpham";
            tc_sanpham.SelectedIndex = 0;
            tc_sanpham.Size = new Size(1231, 654);
            tc_sanpham.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txt_loaisp);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(btn_sua);
            tabPage1.Controls.Add(btn_them);
            tabPage1.Controls.Add(btn_lammoi);
            tabPage1.Controls.Add(cb_ngung);
            tabPage1.Controls.Add(cb_dang);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(lb_loaisp);
            tabPage1.Controls.Add(tx_timkiemsp);
            tabPage1.Controls.Add(dtg_danhsachsp);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1223, 621);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_loaisp
            // 
            txt_loaisp.Location = new Point(869, 91);
            txt_loaisp.Multiline = true;
            txt_loaisp.Name = "txt_loaisp";
            txt_loaisp.Size = new Size(347, 34);
            txt_loaisp.TabIndex = 2;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(1109, 301);
            button3.Name = "button3";
            button3.Size = new Size(107, 40);
            button3.TabIndex = 10;
            button3.Text = "Xoá";
            button3.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            btn_sua.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_sua.Location = new Point(989, 301);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(107, 40);
            btn_sua.TabIndex = 9;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            btn_them.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_them.Location = new Point(869, 301);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(107, 40);
            btn_them.TabIndex = 8;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            // 
            // btn_lammoi
            // 
            btn_lammoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_lammoi.Location = new Point(1068, 247);
            btn_lammoi.Name = "btn_lammoi";
            btn_lammoi.Size = new Size(123, 35);
            btn_lammoi.TabIndex = 7;
            btn_lammoi.Text = "Làm mới";
            btn_lammoi.UseVisualStyleBackColor = true;
            // 
            // cb_ngung
            // 
            cb_ngung.AutoSize = true;
            cb_ngung.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cb_ngung.Location = new Point(1036, 199);
            cb_ngung.Name = "cb_ngung";
            cb_ngung.Size = new Size(184, 29);
            cb_ngung.TabIndex = 6;
            cb_ngung.Text = "Ngừng kinh doanh";
            cb_ngung.UseVisualStyleBackColor = true;
            // 
            // cb_dang
            // 
            cb_dang.AutoSize = true;
            cb_dang.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cb_dang.Location = new Point(869, 201);
            cb_dang.Name = "cb_dang";
            cb_dang.Size = new Size(164, 27);
            cb_dang.TabIndex = 5;
            cb_dang.Text = "Đang kinh doanh";
            cb_dang.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(869, 149);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 4;
            label1.Text = "Tình Trạng:";
            // 
            // lb_loaisp
            // 
            lb_loaisp.AutoSize = true;
            lb_loaisp.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_loaisp.Location = new Point(869, 63);
            lb_loaisp.Name = "lb_loaisp";
            lb_loaisp.Size = new Size(138, 25);
            lb_loaisp.TabIndex = 3;
            lb_loaisp.Text = "Loại Sảm Phẩm:";
            // 
            // tx_timkiemsp
            // 
            tx_timkiemsp.Location = new Point(92, 30);
            tx_timkiemsp.Name = "tx_timkiemsp";
            tx_timkiemsp.PlaceholderText = "Tìm kiếm theo mã hoặc tên";
            tx_timkiemsp.Size = new Size(684, 27);
            tx_timkiemsp.TabIndex = 1;
            // 
            // dtg_danhsachsp
            // 
            dtg_danhsachsp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_danhsachsp.Location = new Point(8, 63);
            dtg_danhsachsp.Name = "dtg_danhsachsp";
            dtg_danhsachsp.RowHeadersWidth = 51;
            dtg_danhsachsp.RowTemplate.Height = 29;
            dtg_danhsachsp.Size = new Size(842, 558);
            dtg_danhsachsp.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txt_size);
            tabPage2.Controls.Add(txt_tensp);
            tabPage2.Controls.Add(btn_lammoict);
            tabPage2.Controls.Add(btn_xoact);
            tabPage2.Controls.Add(btn_suact);
            tabPage2.Controls.Add(btn_themct);
            tabPage2.Controls.Add(btn_anh);
            tabPage2.Controls.Add(pc_anh);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(txt_giaban);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(txt_mausac);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(txt_soluong);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(txt_chatlieu);
            tabPage2.Controls.Add(cb_loaisp);
            tabPage2.Controls.Add(dtg_dsct);
            tabPage2.Controls.Add(txt_timkiemct);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1223, 621);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_size
            // 
            txt_size.Location = new Point(986, 40);
            txt_size.Multiline = true;
            txt_size.Name = "txt_size";
            txt_size.Size = new Size(98, 28);
            txt_size.TabIndex = 24;
            // 
            // txt_tensp
            // 
            txt_tensp.Location = new Point(792, 34);
            txt_tensp.Multiline = true;
            txt_tensp.Name = "txt_tensp";
            txt_tensp.Size = new Size(155, 34);
            txt_tensp.TabIndex = 23;
            // 
            // btn_lammoict
            // 
            btn_lammoict.Location = new Point(1122, 571);
            btn_lammoict.Name = "btn_lammoict";
            btn_lammoict.Size = new Size(94, 29);
            btn_lammoict.TabIndex = 22;
            btn_lammoict.Text = "Làm Mới";
            btn_lammoict.UseVisualStyleBackColor = true;
            // 
            // btn_xoact
            // 
            btn_xoact.Location = new Point(986, 571);
            btn_xoact.Name = "btn_xoact";
            btn_xoact.Size = new Size(94, 29);
            btn_xoact.TabIndex = 21;
            btn_xoact.Text = "Xoá";
            btn_xoact.UseVisualStyleBackColor = true;
            // 
            // btn_suact
            // 
            btn_suact.Location = new Point(1122, 510);
            btn_suact.Name = "btn_suact";
            btn_suact.Size = new Size(94, 29);
            btn_suact.TabIndex = 20;
            btn_suact.Text = "Sửa";
            btn_suact.UseVisualStyleBackColor = true;
            // 
            // btn_themct
            // 
            btn_themct.Location = new Point(986, 510);
            btn_themct.Name = "btn_themct";
            btn_themct.Size = new Size(94, 29);
            btn_themct.TabIndex = 19;
            btn_themct.Text = "Thêm";
            btn_themct.UseVisualStyleBackColor = true;
            // 
            // btn_anh
            // 
            btn_anh.Location = new Point(1051, 454);
            btn_anh.Name = "btn_anh";
            btn_anh.Size = new Size(94, 29);
            btn_anh.TabIndex = 18;
            btn_anh.Text = "Ảnh";
            btn_anh.UseVisualStyleBackColor = true;
            // 
            // pc_anh
            // 
            pc_anh.Location = new Point(1007, 279);
            pc_anh.Name = "pc_anh";
            pc_anh.Size = new Size(178, 160);
            pc_anh.TabIndex = 17;
            pc_anh.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(986, 204);
            label8.Name = "label8";
            label8.Size = new Size(69, 23);
            label8.TabIndex = 16;
            label8.Text = "Giá Bán";
            // 
            // txt_giaban
            // 
            txt_giaban.Location = new Point(986, 230);
            txt_giaban.Multiline = true;
            txt_giaban.Name = "txt_giaban";
            txt_giaban.Size = new Size(215, 28);
            txt_giaban.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(986, 138);
            label7.Name = "label7";
            label7.Size = new Size(75, 23);
            label7.TabIndex = 14;
            label7.Text = "Màu Sắc";
            // 
            // txt_mausac
            // 
            txt_mausac.Location = new Point(986, 164);
            txt_mausac.Multiline = true;
            txt_mausac.Name = "txt_mausac";
            txt_mausac.Size = new Size(215, 28);
            txt_mausac.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(986, 76);
            label6.Name = "label6";
            label6.Size = new Size(82, 23);
            label6.TabIndex = 12;
            label6.Text = "Chất Liệu";
            // 
            // txt_soluong
            // 
            txt_soluong.Location = new Point(1103, 40);
            txt_soluong.Multiline = true;
            txt_soluong.Name = "txt_soluong";
            txt_soluong.Size = new Size(98, 28);
            txt_soluong.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(1103, 12);
            label5.Name = "label5";
            label5.Size = new Size(82, 23);
            label5.TabIndex = 10;
            label5.Text = "Số Lượng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(986, 12);
            label4.Name = "label4";
            label4.Size = new Size(40, 23);
            label4.TabIndex = 9;
            label4.Text = "Size";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(792, 12);
            label3.Name = "label3";
            label3.Size = new Size(118, 23);
            label3.TabIndex = 8;
            label3.Text = "Tên Sản Phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(612, 14);
            label2.Name = "label2";
            label2.Size = new Size(123, 23);
            label2.TabIndex = 7;
            label2.Text = "Loại Sản Phẩm";
            // 
            // txt_chatlieu
            // 
            txt_chatlieu.Location = new Point(986, 102);
            txt_chatlieu.Multiline = true;
            txt_chatlieu.Name = "txt_chatlieu";
            txt_chatlieu.Size = new Size(215, 28);
            txt_chatlieu.TabIndex = 5;
            // 
            // cb_loaisp
            // 
            cb_loaisp.FormattingEnabled = true;
            cb_loaisp.Location = new Point(612, 37);
            cb_loaisp.Name = "cb_loaisp";
            cb_loaisp.Size = new Size(151, 28);
            cb_loaisp.TabIndex = 2;
            // 
            // dtg_dsct
            // 
            dtg_dsct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_dsct.Location = new Point(3, 70);
            dtg_dsct.Name = "dtg_dsct";
            dtg_dsct.RowHeadersWidth = 51;
            dtg_dsct.RowTemplate.Height = 29;
            dtg_dsct.Size = new Size(944, 542);
            dtg_dsct.TabIndex = 1;
            // 
            // txt_timkiemct
            // 
            txt_timkiemct.Location = new Point(60, 38);
            txt_timkiemct.Name = "txt_timkiemct";
            txt_timkiemct.Size = new Size(521, 27);
            txt_timkiemct.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(921, 658);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(8, 8);
            dataGridView2.TabIndex = 1;
            // 
            // FormSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 653);
            Controls.Add(dataGridView2);
            Controls.Add(tc_sanpham);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSanPham";
            Text = "FormSanPham";
            tc_sanpham.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_danhsachsp).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pc_anh).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtg_dsct).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tc_sanpham;
        private TabPage tabPage1;
        private DataGridView dtg_danhsachsp;
        private TabPage tabPage2;
        private DataGridView dataGridView2;
        private Button btn_lammoi;
        private CheckBox cb_ngung;
        private CheckBox cb_dang;
        private Label label1;
        private Label lb_loaisp;
        private TextBox textBox1;
        private TextBox tx_timkiemsp;
        private Button button3;
        private Button btn_sua;
        private Button btn_them;
        private Label label2;
        private TextBox txt_chatlieu;
        private TextBox textBox4;
        private TextBox textBox3;
        private ComboBox cb_loaisp;
        private DataGridView dtg_dsct;
        private TextBox txt_timkiemct;
        private Button btn_lammoict;
        private Button btn_xoact;
        private Button btn_suact;
        private Button btn_themct;
        private Button btn_anh;
        private PictureBox pc_anh;
        private Label label8;
        private TextBox txt_giaban;
        private Label label7;
        private TextBox txt_mausac;
        private Label label6;
        private TextBox txt_soluong;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txt_loaisp;
        private TextBox txt_size;
        private TextBox txt_tensp;
    }
}