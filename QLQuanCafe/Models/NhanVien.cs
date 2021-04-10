using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QLQuanCafe.Models
{
    [Table("NhanViens")]
    public class NhanVien
    {
        [Key]
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
    }
}