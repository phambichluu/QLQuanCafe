using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QLQuanCafe.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        public string MaMon { get; set; }
        public string TenMon { get; set; }
        public string DonGia { get; set; }
    }
}