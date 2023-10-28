namespace QLBANHANG.Model1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_NhanVien()
        {
            tb_HoaDon = new HashSet<tb_HoaDon>();
        }

        [Key]
        [StringLength(10)]
        public string MaNV { get; set; }

        [StringLength(30)]
        public string TenNV { get; set; }

        [StringLength(5)]
        public string GioiTinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NamSinh { get; set; }

        [StringLength(50)]
        public string DiaChi { get; set; }

        [StringLength(11)]
        public string SDT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_HoaDon> tb_HoaDon { get; set; }
    }
}
