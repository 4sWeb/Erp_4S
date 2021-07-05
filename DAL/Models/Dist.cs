using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Dist
    {
        public decimal Id { get; set; }
        public int? DistType { get; set; }
        public int? P1 { get; set; }
        public int? P2 { get; set; }
        public int? P3 { get; set; }
        public int? P4 { get; set; }
        public int? P5 { get; set; }
        public int? P6 { get; set; }
        public int? P7 { get; set; }
        public int? P8 { get; set; }
        public int? P9 { get; set; }
        public int? P10 { get; set; }
        public string Code { get; set; }
        public string FullCode { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public decimal? BeginValue { get; set; }
        public int? DistType2 { get; set; }
        public int? DistType3 { get; set; }
        public string Ohwyam { get; set; }
    }
}
