using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QLQuanCafe.Models
{
    [Table("ThanhToans")]
    public class ThanhToan
    {
        [Key]
        public string MaTT { get; set; }
        public string NgayTT { get; set; }
        public string MaNV { get; set; }
        public string MaKH { get; set; }
        public string ThanhTien { get; set; }
    }
}