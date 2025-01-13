namespace DuAn1_QLBH_Nhom1.GUI
{
    partial class FormMain
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
            btn_sanpham = new Button();
            panel1 = new Panel();
            btn_dangxuat = new Button();
            panel2 = new Panel();
            btn_thongke = new Button();
            btn_khachhang = new Button();
            btn_nhanvien = new Button();
            btn_khuyenmai = new Button();
            btn_hoadon = new Button();
            btn_banhang = new Button();
            panel_main = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_sanpham
            // 
            btn_sanpham.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_sanpham.Location = new Point(34, 138);
            btn_sanpham.Name = "btn_sanpham";
            btn_sanpham.Size = new Size(196, 62);
            btn_sanpham.TabIndex = 0;
            btn_sanpham.Text = "Sản Phẩm";
            btn_sanpham.UseVisualStyleBackColor = true;
            btn_sanpham.Click += btn_sanpham_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_dangxuat);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btn_thongke);
            panel1.Controls.Add(btn_khachhang);
            panel1.Controls.Add(btn_nhanvien);
            panel1.Controls.Add(btn_khuyenmai);
            panel1.Controls.Add(btn_hoadon);
            panel1.Controls.Add(btn_banhang);
            panel1.Controls.Add(btn_sanpham);
            panel1.Location = new Point(1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(239, 856);
            panel1.TabIndex = 1;
            // 
            // btn_dangxuat
            // 
            btn_dangxuat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_dangxuat.Location = new Point(34, 781);
            btn_dangxuat.Name = "btn_dangxuat";
            btn_dangxuat.Size = new Size(196, 62);
            btn_dangxuat.TabIndex = 8;
            btn_dangxuat.Text = "Đăng Xuất";
            btn_dangxuat.UseVisualStyleBackColor = true;
            btn_dangxuat.Click += btn_dangxuat_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(271, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(959, 653);
            panel2.TabIndex = 7;
            // 
            // btn_thongke
            // 
            btn_thongke.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_thongke.Location = new Point(34, 628);
            btn_thongke.Name = "btn_thongke";
            btn_thongke.Size = new Size(196, 62);
            btn_thongke.TabIndex = 6;
            btn_thongke.Text = "Thống Kê";
            btn_thongke.UseVisualStyleBackColor = true;
            btn_thongke.Click += btn_thongke_Click;
            // 
            // btn_khachhang
            // 
            btn_khachhang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_khachhang.Location = new Point(34, 545);
            btn_khachhang.Name = "btn_khachhang";
            btn_khachhang.Size = new Size(196, 62);
            btn_khachhang.TabIndex = 5;
            btn_khachhang.Text = "Khách Hàng";
            btn_khachhang.UseVisualStyleBackColor = true;
            btn_khachhang.Click += btn_khachhang_Click;
            // 
            // btn_nhanvien
            // 
            btn_nhanvien.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_nhanvien.Location = new Point(34, 463);
            btn_nhanvien.Name = "btn_nhanvien";
            btn_nhanvien.Size = new Size(196, 62);
            btn_nhanvien.TabIndex = 4;
            btn_nhanvien.Text = "Nhân Viên";
            btn_nhanvien.UseVisualStyleBackColor = true;
            btn_nhanvien.Click += btn_nhanvien_Click;
            // 
            // btn_khuyenmai
            // 
            btn_khuyenmai.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_khuyenmai.Location = new Point(34, 381);
            btn_khuyenmai.Name = "btn_khuyenmai";
            btn_khuyenmai.Size = new Size(196, 62);
            btn_khuyenmai.TabIndex = 3;
            btn_khuyenmai.Text = "Khuyến Mãi";
            btn_khuyenmai.UseVisualStyleBackColor = true;
            btn_khuyenmai.Click += btn_khuyenmai_Click;
            // 
            // btn_hoadon
            // 
            btn_hoadon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_hoadon.Location = new Point(34, 300);
            btn_hoadon.Name = "btn_hoadon";
            btn_hoadon.Size = new Size(196, 62);
            btn_hoadon.TabIndex = 2;
            btn_hoadon.Text = "Hoá Đơn";
            btn_hoadon.UseVisualStyleBackColor = true;
            btn_hoadon.Click += btn_hoadon_Click;
            // 
            // btn_banhang
            // 
            btn_banhang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_banhang.Location = new Point(34, 217);
            btn_banhang.Name = "btn_banhang";
            btn_banhang.Size = new Size(196, 62);
            btn_banhang.TabIndex = 1;
            btn_banhang.Text = "Bán Hàng";
            btn_banhang.UseVisualStyleBackColor = true;
            btn_banhang.Click += btn_banhang_Click;
            // 
            // panel_main
            // 
            panel_main.Location = new Point(246, 1);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(1224, 853);
            panel_main.TabIndex = 2;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 853);
            Controls.Add(panel_main);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMain";
            Text = "FormMain";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_sanpham;
        private Panel panel1;
        private Button btn_thongke;
        private Button btn_khachhang;
        private Button btn_nhanvien;
        private Button btn_khuyenmai;
        private Button btn_hoadon;
        private Button btn_banhang;
        private Panel panel2;
        private Panel panel_main;
        private Button btn_dangxuat;
    }
}