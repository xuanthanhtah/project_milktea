using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyTiemTraSuaUWU.DataE
{
    public partial class QuanTraSuaUwu : DbContext
    {
        public QuanTraSuaUwu()
            : base("name=QuanTraSuaUwu")
        {
        }

        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MaChucVu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MatKhau)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
