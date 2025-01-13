using DuAn1_QLBH_Nhom1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAn1_QLBH_Nhom1.DAL
{
    public class ChucVu_DAL
    {
        private readonly DBContext_Nhom1 db;

        public ChucVu_DAL(DBContext_Nhom1 context)
        {
            db = context;
        }

        public List<ChucVu> LayDanhSachktk()
        {
            return db.ChucVus.ToList();
        }
    }
}
