using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class SubDist
    {
        public decimal Id { get; set; }
        public decimal? DistType { get; set; }
        public int? Parent { get; set; }
        public string Code { get; set; }
        public string FullCode { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public string Ttype2 { get; set; }
    }
}
