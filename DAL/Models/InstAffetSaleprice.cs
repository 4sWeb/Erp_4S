using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class InstAffetSaleprice
    {
        public decimal Id { get; set; }
        public decimal? Saleformid { get; set; }
        public string Tableflag { get; set; }
        public decimal? Tableid { get; set; }
        public decimal? Val { get; set; }
        public decimal? Payedval { get; set; }
        public DateTime? Trnsdate { get; set; }
        public decimal? AffectSalePrice { get; set; }
    }
}
