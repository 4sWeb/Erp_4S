using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class RepcatRepcolumn
    {
        public string Sname { get; set; }
        public string Oname { get; set; }
        public decimal Type { get; set; }
        public string Cname { get; set; }
        public string Lcname { get; set; }
        public Guid? Toid { get; set; }
        public decimal? Version { get; set; }
        public byte[] Hashcode { get; set; }
        public string CtypeName { get; set; }
        public string CtypeOwner { get; set; }
        public decimal? Id { get; set; }
        public decimal? Pos { get; set; }
        public string Top { get; set; }
        public byte[] Flag { get; set; }
        public decimal? Ctype { get; set; }
        public decimal? Length { get; set; }
        public decimal? Precision { get; set; }
        public decimal? Scale { get; set; }
        public decimal? Null { get; set; }
        public decimal? Charsetid { get; set; }
        public decimal? Charsetform { get; set; }
        public byte[] Property { get; set; }
        public decimal? Clength { get; set; }
    }
}
