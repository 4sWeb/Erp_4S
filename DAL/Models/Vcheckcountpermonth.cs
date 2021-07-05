using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Vcheckcountpermonth
    {
        public decimal? Checkcount { get; set; }
        public decimal? Total { get; set; }
        public string Cmonth { get; set; }
        public string Cyear { get; set; }
        public decimal? Checktype { get; set; }
        public decimal? Fromid { get; set; }
        public decimal? Fromtype { get; set; }
        public string Fromcode { get; set; }
        public decimal? Branch { get; set; }
        public decimal? Currid { get; set; }
    }
}
