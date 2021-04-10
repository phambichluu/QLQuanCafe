using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLQuanCafe.Models
{
    public partial class QLDbContext : DbContext
    {
        public QLDbContext()
            : base("name=QLDbContext")
        {
        }

        public  virtual DbSet<NhanVien> NhanViens { get; set; }
        public  virtual DbSet<Menu> Menus { get; set; }
        public  virtual DbSet<KhachHang> KhachHangs { get; set; }
        public  virtual DbSet<HoaDonBan> HoaDonBans { get; set; }
        public  virtual DbSet<ThanhToan> ThanhToans { get; set; }
        public  virtual DbSet<NhapHang> NhapHangs { get; set; }
        public  virtual DbSet<ThanhToanHangNhap> ThanhToanHangNhaps { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
