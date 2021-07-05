using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Checksnotconfirmed
    {
        public string Aname { get; set; }
        public DateTime? Duedate { get; set; }
        public decimal? Value { get; set; }
        public decimal? Fval { get; set; }
        public decimal? Cash { get; set; }
        public decimal? CollectedChecks { get; set; }
        public string Code { get; set; }
        public string Ename { get; set; }
        public decimal? Fdistid { get; set; }
        public decimal Checkid { get; set; }
        public string Checkno { get; set; }
        public int? Checkserial { get; set; }
        public decimal? Checktype { get; set; }
        public decimal? Period { get; set; }
        public decimal? Branch { get; set; }
        public decimal Finanacemid { get; set; }
        public decimal? Instalmentid { get; set; }
        public string Serialname { get; set; }
        public string Instalmentname { get; set; }
        public DateTime? Indate { get; set; }
        public decimal? Val { get; set; }
        public decimal? Increaseval { get; set; }
        public string Serialename { get; set; }
        public string Instalmentename { get; set; }
    }
}
