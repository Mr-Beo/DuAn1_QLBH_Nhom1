using DuAn1_QLBH_Nhom1.DAL.Models;
using DuAn1_QLBH_Nhom1.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAn1_QLBH_Nhom1.BLL
{
    public class NguoiDung_BLL
    {
        private static NguoiDung_BLL _instance;
        private readonly NguoiDung_DAL _nguoiDungDAL;
        private readonly DBContext_Nhom1 _dbContext;
        private string _tenDangNhapHienTai;

        private NguoiDung_BLL()
        {
            _dbContext = new DBContext_Nhom1();
            _nguoiDungDAL = new NguoiDung_DAL(_dbContext);
        }

        public List<NhanVien> laydanhsachnguoidung()
        {
            return _nguoiDungDAL.Laydanhsachnguoidung();
        }
        public static NguoiDung_BLL Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new NguoiDung_BLL();
                }
                return _instance;
            }
        }

        public void SetTenDangNhapHienTai(string tenDangNhap)
        {
            _tenDangNhapHienTai = tenDangNhap;
        }

        public List<NhanVien> LayThongTinNguoiDung()
        {
            return _dbContext.NhanViens.Where(nd => nd.TaiKhoan == _tenDangNhapHienTai).ToList();
        }

        public NhanVien XacThuc(string tenDangNhap, string matKhau)
        {
            var authenticatedUser = _nguoiDungDAL.XacThuc(tenDangNhap, matKhau);
            if (authenticatedUser != null)
            {
                SetTenDangNhapHienTai(authenticatedUser.TaiKhoan);
            }
            return authenticatedUser;
        }

        public string PhanQuyen(int idKieuTaiKhoan)
        {
            switch (idKieuTaiKhoan)
            {
                case 1:
                    return "Admin đang đăng nhập!";
                case 2:
                    return "Nhân viên đang đăng nhập!";
                default:
                    return "Tài khoản không có quyền truy cập!";
            }
        }

        public bool CapNhatThongTinNguoiDung(NhanVien nguoiDung)
        {
            return _nguoiDungDAL.CapNhatThongTinNguoiDung(nguoiDung);
        }
    }
}
