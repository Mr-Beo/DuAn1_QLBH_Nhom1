namespace DuAn1_QLBH_Nhom1.GUI
{
    partial class FormLogin
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
            label1 = new Label();
            label2 = new Label();
            txt_taikhoan = new TextBox();
            cb_showpass = new CheckBox();
            txt_matkhau = new TextBox();
            btn_dangnhap = new Button();
            btn_thoat = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(37, 120);
            label1.Name = "label1";
            label1.Size = new Size(96, 28);
            label1.TabIndex = 0;
            label1.Text = "Tài Khoản";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(37, 230);
            label2.Name = "label2";
            label2.Size = new Size(96, 28);
            label2.TabIndex = 1;
            label2.Text = "Mật Khẩu";
            // 
            // txt_taikhoan
            // 
            txt_taikhoan.Location = new Point(37, 162);
            txt_taikhoan.Multiline = true;
            txt_taikhoan.Name = "txt_taikhoan";
            txt_taikhoan.Size = new Size(309, 41);
            txt_taikhoan.TabIndex = 2;
            txt_taikhoan.KeyPress += txt_taikhoan_KeyPress;
            // 
            // cb_showpass
            // 
            cb_showpass.AutoSize = true;
            cb_showpass.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cb_showpass.Location = new Point(39, 327);
            cb_showpass.Name = "cb_showpass";
            cb_showpass.Size = new Size(98, 29);
            cb_showpass.TabIndex = 4;
            cb_showpass.Text = "Hiển Thị";
            cb_showpass.UseVisualStyleBackColor = true;
            cb_showpass.CheckedChanged += cb_showpass_CheckedChanged;
            // 
            // txt_matkhau
            // 
            txt_matkhau.Location = new Point(37, 261);
            txt_matkhau.Multiline = true;
            txt_matkhau.Name = "txt_matkhau";
            txt_matkhau.PasswordChar = '*';
            txt_matkhau.Size = new Size(309, 41);
            txt_matkhau.TabIndex = 5;
            txt_matkhau.KeyPress += txt_matkhau_KeyPress;
            // 
            // btn_dangnhap
            // 
            btn_dangnhap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_dangnhap.Location = new Point(37, 362);
            btn_dangnhap.Name = "btn_dangnhap";
            btn_dangnhap.Size = new Size(128, 43);
            btn_dangnhap.TabIndex = 6;
            btn_dangnhap.Text = "Đăng Nhập";
            btn_dangnhap.UseVisualStyleBackColor = true;
            btn_dangnhap.Click += btn_dangnhap_Click;
            // 
            // btn_thoat
            // 
            btn_thoat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_thoat.Location = new Point(218, 362);
            btn_thoat.Name = "btn_thoat";
            btn_thoat.Size = new Size(128, 43);
            btn_thoat.TabIndex = 7;
            btn_thoat.Text = "Thoát";
            btn_thoat.UseVisualStyleBackColor = true;
            btn_thoat.Click += btn_thoat_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txt_taikhoan);
            panel1.Controls.Add(txt_matkhau);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btn_thoat);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_dangnhap);
            panel1.Controls.Add(cb_showpass);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(365, 448);
            panel1.TabIndex = 8;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FormLogin";
            Text = "FormLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_taikhoan;
        private CheckBox cb_showpass;
        private TextBox txt_matkhau;
        private Button btn_dangnhap;
        private Button btn_thoat;
        private Panel panel1;
    }
}