using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuAn1_QLBH_Nhom1.GUI
{
    public partial class FormMain : Form
    {
        // Tạo các lớp đối tượng //
        FormSanPham sp = new FormSanPham();
        FormBanHang bh = new FormBanHang();
        FormHoaDon hd = new FormHoaDon();
        FormKhuyenMai km = new FormKhuyenMai();
        FormNhanVien nv = new FormNhanVien();
        FormKhachHang kh = new FormKhachHang();

        private bool isAdmin;

        public FormMain(bool isAdmin)
        {
            InitializeComponent();
            // Lữu trữ thông tin về vai trò người dùng
            this.isAdmin = isAdmin;
        }

        private void btn_sanpham_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            sp.TopLevel = false;
            sp.Dock = DockStyle.Fill;
            panel_main.Controls.Add(sp);
            sp.Show();

        }

        private void btn_banhang_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            bh.TopLevel = false;
            bh.Dock = DockStyle.Fill;
            panel_main.Controls.Add(bh);
            bh.Show();
        }

        private void btn_hoadon_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            hd.TopLevel = false;
            hd.Dock = DockStyle.Fill;
            panel_main.Controls.Add(hd);
            hd.Show();
        }

        private void btn_khuyenmai_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            km.TopLevel = false;
            km.Dock = DockStyle.Fill;
            panel_main.Controls.Add(km);
            km.Show();

        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            nv.TopLevel = false;
            nv.Dock = DockStyle.Fill;
            panel_main.Controls.Add(nv);
            nv.Show();

        }

        private void btn_khachhang_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            kh.TopLevel = false;
            kh.Dock = DockStyle.Fill;
            panel_main.Controls.Add(kh);
            kh.Show();

        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {

        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();

                FormLogin formDangNhap = new FormLogin();
                formDangNhap.ShowDialog();
            }
        }
    }
}
