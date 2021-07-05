using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class InstPayments1OneRow
    {
        public DateTime? Dd { get; set; }
        public decimal? Instalmentid { get; set; }
        public decimal? Saleformid { get; set; }
        public decimal? Currid { get; set; }
        public decimal? AffectSalePrice { get; set; }
        public decimal? CashPayed { get; set; }
        public decimal? CashPenalty { get; set; }
        public decimal? CashFixedcostval { get; set; }
        public decimal? TransferPayed { get; set; }
        public decimal? TransferPenalty { get; set; }
        public decimal? TransferFixedcostval { get; set; }
        public decimal? CheckPayedCollected { get; set; }
        public decimal? CheckPenaltyCollected { get; set; }
        public decimal? CheckFixedcostvalCollected { get; set; }
        public decimal? CheckPayedTotal { get; set; }
        public decimal? CheckPenaltyTotal { get; set; }
        public decimal? CheckFixedcostvalTotal { get; set; }
        public decimal? Ownercompany { get; set; }
        public decimal? InstValue { get; set; }
        public DateTime? InstIndate { get; set; }
    }
}
