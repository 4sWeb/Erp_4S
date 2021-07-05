using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Vdependencytotal
    {
        public decimal? Itemid { get; set; }
        public decimal? Ctrnsid { get; set; }
        public DateTime? Ctrnsdate { get; set; }
        public decimal Crowid { get; set; }
        public decimal? Cqty { get; set; }
        public decimal? Cunitid { get; set; }
        public decimal? Cqtybasic { get; set; }
        public decimal? Remaining { get; set; }
        public decimal? Ptrnsid { get; set; }
        public DateTime? Ptrnsdate { get; set; }
        public decimal Prowid { get; set; }
        public decimal? Pqty { get; set; }
        public decimal? Punitid { get; set; }
        public decimal? Pqtybasic { get; set; }
        public decimal? Basicunitid { get; set; }
    }
}
