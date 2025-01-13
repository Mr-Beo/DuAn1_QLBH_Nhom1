namespace DuAn1_QLBH_Nhom1.GUI
{
    partial class FormKhuyenMai
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
            groupBox1 = new GroupBox();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txt_soluong = new TextBox();
            label4 = new Label();
            txt_phantram = new TextBox();
            label3 = new Label();
            txt_ngaybatdau = new TextBox();
            label2 = new Label();
            txt_makm = new TextBox();
            label1 = new Label();
            grb_ds = new GroupBox();
            dtg_dskm = new DataGridView();
            btn_them = new Button();
            btn_sua = new Button();
            btn_xoa = new Button();
            btn_lammoi = new Button();
            groupBox1.SuspendLayout();
            grb_ds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_dskm).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(txt_soluong);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_phantram);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_ngaybatdau);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_makm);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(33, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(402, 525);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 215);
            label5.Name = "label5";
            label5.Size = new Size(126, 25);
            label5.TabIndex = 9;
            label5.Text = "Ngày Kết Thúc";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(6, 253);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(367, 31);
            dateTimePicker1.TabIndex = 8;
            // 
            // txt_soluong
            // 
            txt_soluong.Location = new Point(6, 432);
            txt_soluong.Multiline = true;
            txt_soluong.Name = "txt_soluong";
            txt_soluong.Size = new Size(367, 39);
            txt_soluong.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 404);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 6;
            label4.Text = "Số Lượng";
            // 
            // txt_phantram
            // 
            txt_phantram.Location = new Point(6, 330);
            txt_phantram.Multiline = true;
            txt_phantram.Name = "txt_phantram";
            txt_phantram.Size = new Size(367, 39);
            txt_phantram.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 302);
            label3.Name = "label3";
            label3.Size = new Size(170, 25);
            label3.TabIndex = 4;
            label3.Text = "Phần Trăm Giảm Giá";
            // 
            // txt_ngaybatdau
            // 
            txt_ngaybatdau.Location = new Point(6, 154);
            txt_ngaybatdau.Multiline = true;
            txt_ngaybatdau.Name = "txt_ngaybatdau";
            txt_ngaybatdau.Size = new Size(367, 39);
            txt_ngaybatdau.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 126);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 2;
            label2.Text = "Ngày Bắt Đầu";
            // 
            // txt_makm
            // 
            txt_makm.Location = new Point(6, 63);
            txt_makm.Multiline = true;
            txt_makm.Name = "txt_makm";
            txt_makm.Size = new Size(367, 39);
            txt_makm.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 35);
            label1.Name = "label1";
            label1.Size = new Size(134, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã Khuyến Mãi";
            // 
            // grb_ds
            // 
            grb_ds.Controls.Add(dtg_dskm);
            grb_ds.Location = new Point(589, 75);
            grb_ds.Name = "grb_ds";
            grb_ds.Size = new Size(643, 525);
            grb_ds.TabIndex = 1;
            grb_ds.TabStop = false;
            grb_ds.Text = "Danh sách khuyến mãi";
            // 
            // dtg_dskm
            // 
            dtg_dskm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_dskm.Location = new Point(6, 26);
            dtg_dskm.Name = "dtg_dskm";
            dtg_dskm.RowHeadersWidth = 51;
            dtg_dskm.RowTemplate.Height = 29;
            dtg_dskm.Size = new Size(625, 493);
            dtg_dskm.TabIndex = 0;
            // 
            // btn_them
            // 
            btn_them.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_them.Location = new Point(455, 75);
            btn_them.Name = "btn_them";
            btn_them.Size = new Size(116, 47);
            btn_them.TabIndex = 0;
            btn_them.Text = "Thêm";
            btn_them.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            btn_sua.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_sua.Location = new Point(455, 223);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(116, 47);
            btn_sua.TabIndex = 2;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            btn_xoa.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_xoa.Location = new Point(455, 397);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(116, 47);
            btn_xoa.TabIndex = 3;
            btn_xoa.Text = "Xoá";
            btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_lammoi
            // 
            btn_lammoi.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_lammoi.Location = new Point(455, 553);
            btn_lammoi.Name = "btn_lammoi";
            btn_lammoi.Size = new Size(116, 47);
            btn_lammoi.TabIndex = 4;
            btn_lammoi.Text = "Làm Mới";
            btn_lammoi.UseVisualStyleBackColor = true;
            // 
            // FormKhuyenMai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 653);
            Controls.Add(btn_lammoi);
            Controls.Add(btn_xoa);
            Controls.Add(btn_sua);
            Controls.Add(btn_them);
            Controls.Add(grb_ds);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormKhuyenMai";
            Text = "FormKhuyenMai";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grb_ds.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_dskm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox grb_ds;
        private Button btn_them;
        private Button btn_sua;
        private Button btn_xoa;
        private Button btn_lammoi;
        private DataGridView dtg_dskm;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private TextBox txt_soluong;
        private Label label4;
        private TextBox txt_phantram;
        private Label label3;
        private TextBox txt_ngaybatdau;
        private Label label2;
        private TextBox txt_makm;
        private Label label1;
    }
}