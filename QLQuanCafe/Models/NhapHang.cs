using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QLQuanCafe.Models
{
    [Table("NhapHangs")]
    public class NhapHang
    {
        [Key]
        public string MaNhapHang { get; set; }
        public string NgayNhapHang { get; set; }
        public string LoaiHangHoa { get; set; }
        public string DonGia { get; set; }
        public string SoLuong { get; set; }
        public string ThanhTien { get; set; }



    }
}