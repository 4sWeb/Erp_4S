using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class InstSpecDetailsMod
    {
        public decimal Instalmentid { get; set; }
        public decimal? Saleformid { get; set; }
        public DateTime? Dd { get; set; }
        public string Paytype { get; set; }
        public decimal? Currid { get; set; }
        public decimal? Payed { get; set; }
        public decimal? Penalty { get; set; }
        public decimal? Fixedcostval { get; set; }
        public decimal? PayedCollected { get; set; }
        public decimal? PenaltyCollected { get; set; }
        public decimal? FixedcostvalCollected { get; set; }
        public decimal? AffectSalePrice { get; set; }
        public decimal? Ownercompany { get; set; }
        public decimal? InstValue { get; set; }
        public DateTime? InstIndate { get; set; }
        public string SerialName { get; set; }
        public string InstalmentName { get; set; }
        public string SerialEname { get; set; }
        public string InstalmentEname { get; set; }
    }
}
