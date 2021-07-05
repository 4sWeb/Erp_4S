using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class EvaluationPricePromation
    {
        public EvaluationPricePromation()
        {
            EvalPricePromoComms = new HashSet<EvalPricePromoComm>();
            EvaluaPricePromationDetails = new HashSet<EvaluaPricePromationDetail>();
        }

        public decimal Id { get; set; }
        public decimal? StoreTrnsMId { get; set; }
        public DateTime? Trnsdate { get; set; }
        public decimal? Currencyid { get; set; }
        public decimal? Committeeid { get; set; }
        public bool? Approved { get; set; }
        public DateTime? Approveddate { get; set; }
        public string Notes { get; set; }

        public virtual Currencym Currency { get; set; }
        public virtual StoreTrnsM StoreTrnsM { get; set; }
        public virtual ICollection<EvalPricePromoComm> EvalPricePromoComms { get; set; }
        public virtual ICollection<EvaluaPricePromationDetail> EvaluaPricePromationDetails { get; set; }
    }
}
