namespace DuAn1_QLBH_Nhom1.GUI
{
    partial class FormHoaDon
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
            btn_xuatds = new Button();
            groupBox1 = new GroupBox();
            dtg_hoadon = new DataGridView();
            groupBox2 = new GroupBox();
            dtg_hoadonct = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_hoadon).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_hoadonct).BeginInit();
            SuspendLayout();
            // 
            // txt_timkiem
            // 
            txt_timkiem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_timkiem.Location = new Point(162, 12);
            txt_timkiem.Multiline = true;
            txt_timkiem.Name = "txt_timkiem";
            txt_timkiem.PlaceholderText = "Tìm kiếm theo mã hoặc tên";
            txt_timkiem.Size = new Size(722, 37);
            txt_timkiem.TabIndex = 0;
            // 
            // btn_xuatds
            // 
            btn_xuatds.Location = new Point(926, 12);
            btn_xuatds.Name = "btn_xuatds";
            btn_xuatds.Size = new Size(173, 37);
            btn_xuatds.TabIndex = 1;
            btn_xuatds.Text = "Xuất danh sách";
            btn_xuatds.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtg_hoadon);
            groupBox1.Location = new Point(12, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1196, 316);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hoá đơn";
            // 
            // dtg_hoadon
            // 
            dtg_hoadon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_hoadon.Location = new Point(3, 23);
            dtg_hoadon.Name = "dtg_hoadon";
            dtg_hoadon.RowHeadersWidth = 51;
            dtg_hoadon.RowTemplate.Height = 29;
            dtg_hoadon.Size = new Size(1187, 287);
            dtg_hoadon.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtg_hoadonct);
            groupBox2.Location = new Point(12, 401);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1196, 316);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hoá đơn chi tiết";
            // 
            // dtg_hoadonct
            // 
            dtg_hoadonct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_hoadonct.Location = new Point(3, 23);
            dtg_hoadonct.Name = "dtg_hoadonct";
            dtg_hoadonct.RowHeadersWidth = 51;
            dtg_hoadonct.RowTemplate.Height = 29;
            dtg_hoadonct.Size = new Size(1187, 287);
            dtg_hoadonct.TabIndex = 1;
            // 
            // FormHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 730);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btn_xuatds);
            Controls.Add(txt_timkiem);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormHoaDon";
            Text = "FormHoaDon";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_hoadon).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_hoadonct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_timkiem;
        private Button btn_xuatds;
        private GroupBox groupBox1;
        private DataGridView dtg_hoadon;
        private GroupBox groupBox2;
        private DataGridView dtg_hoadonct;
    }
}