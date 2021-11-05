namespace AppQLTraSua.dataAcessLayer.models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTHD")]
    public partial class CTHD
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaHoaDon { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaMonAn { get; set; }

        [StringLength(50)]
        public string TenMonAn { get; set; }

        public int? Soluong { get; set; }

        public long? DonGia { get; set; }

        public virtual HOADON HOADON { get; set; }

        public virtual MENU MENU { get; set; }
    }
}
