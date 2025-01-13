using DuAn1_QLBH_Nhom1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAn1_QLBH_Nhom1.DAL
{
    public class NhanVien_DAL
    {
        private readonly DBContext_Nhom1 db;

        public NhanVien_DAL(DBContext_Nhom1 context)
        {
            db = context;
        }

        public List<NhanVien> LayDanhSachND()
        {
            return db.NhanViens.ToList();
        }

        public void ThemND(NhanVien nhanVien)
        {
            db.NhanViens.Add(nhanVien);
            db.SaveChanges();
        }

        public void SuaND(NhanVien nhanVien)
        {
            db.Entry(nhanVien).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void XoaND(int mand)
        {
            var nguoidung = db.NhanViens.FirstOrDefault(sp => sp.ID_NhanVien == mand);
            if (nguoidung != null)
            {
                db.NhanViens.Remove(nguoidung);
                db.SaveChanges();
            }
        }
    }
}
