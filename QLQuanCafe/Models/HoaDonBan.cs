using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QLQuanCafe.Models
{
    [Table("HoaDonBans")]
    public class HoaDonBan
    {
        [Key]
        public string MaHDB { get; set; }
        public string MaMon { get; set; }
        public string DonGia { get; set; }
        public string SoLuong { get; set; }
        public string ThanhTien { get; set; }
    }
}