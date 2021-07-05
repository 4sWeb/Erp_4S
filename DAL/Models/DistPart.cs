using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class DistPart
    {
        public decimal Id { get; set; }
        public int? DistType { get; set; }
        public int? TypeP1 { get; set; }
        public int? TypeP2 { get; set; }
        public int? TypeP3 { get; set; }
        public int? TypeP4 { get; set; }
        public int? TypeP5 { get; set; }
        public int? TypeP6 { get; set; }
        public int? TypeP7 { get; set; }
        public int? TypeP8 { get; set; }
        public int? TypeP9 { get; set; }
        public int? TypeP10 { get; set; }
        public byte? NUniquePart { get; set; }
        public byte? NoSegments { get; set; }
        public byte? FormNo { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
    }
}
