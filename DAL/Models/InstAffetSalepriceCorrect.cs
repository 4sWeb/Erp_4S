using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class InstAffetSalepriceCorrect
    {
        public decimal Id { get; set; }
        public decimal? Saleformid { get; set; }
        public string Tableflag { get; set; }
        public decimal? Tableid { get; set; }
        public decimal? Val { get; set; }
        public decimal? AffectSalePrice { get; set; }
    }
}
