using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPCOREDAL.Models
{
    public partial class StoreAllcodesBegin
    {
        public int Id { get; set; }
        public int? Allcodesid { get; set; }
        public int? Period { get; set; }
        public decimal? CashBeginDebit { get; set; }
        public decimal? CashBeginCredit { get; set; }
        public decimal? CheckBeginDebit { get; set; }
        public decimal? CheckBeginCredit { get; set; }
        public int? Currencyid { get; set; }
        public decimal? Currrate { get; set; }

        [ForeignKey("Allcodesid")]
        public virtual StoreAllcodes Allcodes { get; set; }
        [ForeignKey("Currencyid")]
        public virtual Currencym Currency { get; set; }
        [ForeignKey("Period")]
        public virtual Period PeriodNavigation { get; set; }
    }
}
