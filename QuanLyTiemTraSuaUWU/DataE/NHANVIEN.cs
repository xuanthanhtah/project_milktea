namespace QuanLyTiemTraSuaUWU.DataE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [Key]
        public int MANV { get; set; }

        [StringLength(50)]
        public string HoTen { get; set; }

        [StringLength(15)]
        public string SDT { get; set; }

        [StringLength(50)]
        public string DiaCHi { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NamSinh { get; set; }

        [StringLength(5)]
        public string GioiTinh { get; set; }

        [StringLength(10)]
        public string MaChucVu { get; set; }

        [Required]
        [StringLength(50)]
        public string TaiKhoan { get; set; }

        [Required]
        [StringLength(50)]
        public string MatKhau { get; set; }
    }
}
