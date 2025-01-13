using DuAn1_QLBH_Nhom1.DAL;
using DuAn1_QLBH_Nhom1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAn1_QLBH_Nhom1.BLL
{
    public class ChucVu_BLL
    {
        private DBContext_Nhom1 _dbContext;
        private readonly ChucVu_DAL chucVu_DAL;
        public ChucVu_BLL()
        {
            _dbContext = new DBContext_Nhom1();
            chucVu_DAL = new ChucVu_DAL(new DBContext_Nhom1());
        }

        public List<ChucVu> laydanhsachktk()
        {
            return _dbContext.ChucVus.ToList();
        }
    }
}
