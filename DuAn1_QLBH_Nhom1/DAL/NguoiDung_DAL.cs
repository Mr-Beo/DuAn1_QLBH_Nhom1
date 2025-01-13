using DuAn1_QLBH_Nhom1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAn1_QLBH_Nhom1.DAL
{
    public class NguoiDung_DAL
    {
        private readonly DBContext_Nhom1 _dbContext;

        public NguoiDung_DAL(DBContext_Nhom1 dbContext)
        {
            _dbContext = dbContext;
        }
        public List<NhanVien> Laydanhsachnguoidung()
        {

            return _dbContext.NhanViens.ToList();

        }
        public NhanVien XacThuc(string tenDangNhap, string matKhau)
        {
            // Trả về thông tin người dùng dựa trên tên đăng nhập và mật khẩu
            return _dbContext.NhanViens.FirstOrDefault(nd => nd.TaiKhoan == tenDangNhap && nd.MatKhau == matKhau);
        }

        public List<NhanVien> LayThongTinNguoiDung(string tenDangNhap)
        {
            // Trả về thông tin người dùng dựa trên tên đăng nhập
            return _dbContext.NhanViens.Where(nd => nd.TaiKhoan == tenDangNhap).ToList();
        }

        public bool CapNhatThongTinNguoiDung(NhanVien nhanVien)
        {
            try
            {
                var nguoiDungCanCapNhat = _dbContext.NhanViens.Find(nhanVien.ID_NhanVien);
                if (nguoiDungCanCapNhat != null)
                {
                    nguoiDungCanCapNhat.TenNhanVien = nhanVien.TenNhanVien;
                    nguoiDungCanCapNhat.NgaySinh = nhanVien.NgaySinh;                   
                    nguoiDungCanCapNhat.DiaChi = nhanVien.DiaChi;
                    nguoiDungCanCapNhat.Email = nhanVien.Email;
                    nguoiDungCanCapNhat.SoDienThoai = nhanVien.SoDienThoai;
                    nguoiDungCanCapNhat.GioiTinh = nhanVien.GioiTinh;
                    nguoiDungCanCapNhat.TaiKhoan = nhanVien.TaiKhoan;
                    _dbContext.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
