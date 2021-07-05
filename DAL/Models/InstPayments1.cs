using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class InstPayments1
    {
        public decimal? Instalmentid { get; set; }
        public decimal? Saleformid { get; set; }
        public DateTime Dd { get; set; }
        public string Paytype { get; set; }
        public decimal? Currid { get; set; }
        public decimal? Checkid { get; set; }
        public decimal? Payed { get; set; }
        public decimal? Penalty { get; set; }
        public decimal? Fixedcostval { get; set; }
        public decimal? PayedCollected { get; set; }
        public decimal? PenaltyCollected { get; set; }
        public decimal? FixedcostvalCollected { get; set; }
        public decimal? AffectSalePrice { get; set; }
        public decimal? Ownercompany { get; set; }
    }
}
