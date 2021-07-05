using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Vcheckspermonthall
    {
        public decimal? Fromid { get; set; }
        public decimal? Fromtype { get; set; }
        public string Fromcode { get; set; }
        public string Cmonth { get; set; }
        public string Cyear { get; set; }
        public decimal? Branch { get; set; }
        public decimal? Currid { get; set; }
        public decimal? Count1 { get; set; }
        public decimal? Total1 { get; set; }
        public decimal? Count2 { get; set; }
        public decimal? Total2 { get; set; }
        public decimal? Count3 { get; set; }
        public decimal? Total3 { get; set; }
        public decimal? Count4 { get; set; }
        public decimal? Total4 { get; set; }
        public decimal? Allcount { get; set; }
        public decimal? Alltotal { get; set; }
    }
}
