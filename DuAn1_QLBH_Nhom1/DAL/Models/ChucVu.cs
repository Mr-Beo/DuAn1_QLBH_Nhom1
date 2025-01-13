using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAn1_QLBH_Nhom1.DAL.Models
{
    public class ChucVu
    {
        public ChucVu()
        {
            NhanViens = new HashSet<NhanVien>();
        }

        public int ID_ChucVu { get; set; }
        public string TenChucVu { get; set; } = null!;

        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
