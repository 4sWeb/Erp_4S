using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Receiptpapersforinstalmentmod
    {
        public decimal Financemid { get; set; }
        public DateTime? Trnsdate { get; set; }
        public long? Trnsno { get; set; }
        public decimal? Fdistid { get; set; }
        public decimal? Currid { get; set; }
        public decimal? Netval { get; set; }
        public decimal? Grossval { get; set; }
        public decimal Checkid { get; set; }
        public string Checkno { get; set; }
        public decimal? Value { get; set; }
        public DateTime? Duedate { get; set; }
        public string Bankname { get; set; }
        public string Serialname { get; set; }
        public string Serialename { get; set; }
        public decimal? Instalmentid { get; set; }
        public decimal? Fval { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public string Fdistcode { get; set; }
        public string Fdistaname { get; set; }
        public string Fdistename { get; set; }
        public string DocNo { get; set; }
        public string Shortname { get; set; }
    }
}
