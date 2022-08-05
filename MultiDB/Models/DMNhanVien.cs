namespace MultiDB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DMNhanVien")]
    public partial class DMNhanVien
    {
        public int ID { get; set; }

        [StringLength(250)]
        public string HoTen { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngay_CN { get; set; }
    }
}
