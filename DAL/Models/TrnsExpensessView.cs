using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class TrnsExpensessView
    {
        public decimal TrnsCode { get; set; }
        public decimal TrnsNo { get; set; }
        public string Trnsname { get; set; }
        public string Expcode { get; set; }
        public decimal? Expvalue { get; set; }
        public decimal Trnsmid { get; set; }
        public string Expname { get; set; }
        public decimal? Trnsmcode { get; set; }
    }
}
