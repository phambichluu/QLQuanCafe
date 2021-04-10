using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QLQuanCafe.Models
{
    [Table("Ngays")]
    public class Ngay
    {
        [Key]
        public string Ngay { get; set; }
    }
}