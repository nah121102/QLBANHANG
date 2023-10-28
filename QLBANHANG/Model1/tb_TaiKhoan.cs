namespace QLBANHANG.Model1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_TaiKhoan
    {
        [Required]
        [StringLength(30)]
        public string TenTaiKhoan { get; set; }

        [Key]
        [StringLength(30)]
        public string Matkhau { get; set; }
    }
}
