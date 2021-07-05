using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class StoreAllcodesBegin
    {
        public decimal Id { get; set; }
        public decimal? Allcodesid { get; set; }
        public decimal? Period { get; set; }
        public decimal? CashBeginDebit { get; set; }
        public decimal? CashBeginCredit { get; set; }
        public decimal? CheckBeginDebit { get; set; }
        public decimal? CheckBeginCredit { get; set; }
        public decimal? Currencyid { get; set; }
        public decimal? Currrate { get; set; }

        public virtual StoreAllcode Allcodes { get; set; }
        public virtual Currencym Currency { get; set; }
        public virtual Period PeriodNavigation { get; set; }
    }
}
