using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Getallpermission
    {
        public decimal? Rowsid { get; set; }
        public decimal PageId { get; set; }
        public decimal PerId { get; set; }
        public decimal? RoleId { get; set; }
        public string PerStatus { get; set; }
        public string PerName { get; set; }
        public string Arabicname { get; set; }
    }
}
