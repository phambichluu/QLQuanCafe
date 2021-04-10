using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QLQuanCafe.Models
{
    [Table("ThanhToanHangNhaps")]
    public class ThanhToanHangNhap
    {
        [Key]
        public string MaTTHangNhap { get; set; }
        public string NgayTT { get; set; }
        public string MaNV { get; set; }
        public string ThanhTien { get; set; }

    }
}