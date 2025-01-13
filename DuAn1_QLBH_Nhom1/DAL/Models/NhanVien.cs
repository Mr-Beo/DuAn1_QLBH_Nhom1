using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAn1_QLBH_Nhom1.DAL.Models
{
    public partial class NhanVien
    {
        public int ID_NhanVien { get; set; }
        
        public string TenNhanVien { get; set; } = null!;
        public DateTime NgaySinh { get; set; }
        public string? DiaChi { get; set; }
        public string? Email { get; set; }
        public string SoDienThoai { get; set; } = null!;
        public string GioiTinh { get; set; } = null!;
        public string TaiKhoan { get; set; } = null!;
        public string MatKhau { get; set; } = null!;
        public int ID_ChucVu { get; set; }

        public virtual ChucVu IDChucVuNavigation { get; set; } = null!;
        
    }
}
