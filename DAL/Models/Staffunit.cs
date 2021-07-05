using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Staffunit
    {
        public decimal? Flag { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public string Code { get; set; }
        public decimal? Instid { get; set; }
        public DateTime? Indate { get; set; }
        public string Rcustomeraname { get; set; }
        public string Rcustomerename { get; set; }
    }
}
