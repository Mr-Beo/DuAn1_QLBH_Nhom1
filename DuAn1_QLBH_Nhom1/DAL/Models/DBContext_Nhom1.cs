using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuAn1_QLBH_Nhom1.DAL.Models
{
    public partial class DBContext_Nhom1 : DbContext
    {
        public DBContext_Nhom1(DbContextOptions<DBContext_Nhom1> options) : base(options)
        {
        }

        public DBContext_Nhom1()
        {
        }
        public virtual DbSet<ChucVu> ChucVus { get; set; } = null!;
        public virtual DbSet<NhanVien> NhanViens { get; set; } = null!;
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=HOANG\\SQLEXPRESS;Initial Catalog=DuAn1_QLBH_Nhom1;Integrated Security=True;Trust Server Certificate=True");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChucVu>(entity =>
            {
                entity.HasKey(e => e.ID_ChucVu)
                    .HasName("PK__ChucVu__2DF801653D065A2D");

                entity.ToTable("ChucVu");

                entity.Property(e => e.ID_ChucVu).HasColumnName("ID_Chuc_Vu");

                entity.Property(e => e.ID_ChucVu)
                    .HasMaxLength(50)
                    .HasColumnName("Ten_Chuc_Vu");
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.ID_NhanVien)
                    .HasName("PK__NhanVien__8B63E0759801AF63");

                entity.ToTable("NhanVien");

                entity.Property(e => e.ID_NhanVien).HasColumnName("ID_NhanVien");

                entity.Property(e => e.GioiTinh).HasMaxLength(5);

                entity.Property(e => e.TenNhanVien).HasMaxLength(50);

                entity.Property(e => e.ID_ChucVu).HasColumnName("ID_ChucVu");

                entity.Property(e => e.MatKhau).HasMaxLength(50);

                entity.Property(e => e.SoDienThoai)
                    .HasMaxLength(50)
                    .HasColumnName("SoDienThoai");

                entity.Property(e => e.TaiKhoan).HasMaxLength(50);


                entity.HasOne(d => d.IDChucVuNavigation)
                    .WithMany(p => p.NhanViens)
                    .HasForeignKey(d => d.ID_ChucVu)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__NhanVien__ID_ChucVu__412EB0B6");
            });
        }

        
    }
}

