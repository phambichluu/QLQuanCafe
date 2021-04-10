using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QLQuanCafe.Models
{
    [Table("KhachHangs")]
    public class KhachHang
    {
        [Key]
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string MaTT { get; set; }

    }
}