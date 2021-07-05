using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class EvaluaPricePromationDetail
    {
        public decimal Id { get; set; }
        public decimal? EvaluationPricePromationId { get; set; }
        public decimal? Itemid { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Price { get; set; }
        public decimal? Currencyid { get; set; }
        public string Note { get; set; }
        public decimal? StoreTrnsOId { get; set; }
        public decimal? Isselected { get; set; }
        public decimal? StoreTrnsMId { get; set; }

        public virtual Currencym Currency { get; set; }
        public virtual EvaluationPricePromation EvaluationPricePromation { get; set; }
        public virtual StoreItem Item { get; set; }
        public virtual StoreTrnsM StoreTrnsM { get; set; }
        public virtual StoreTrnsO StoreTrnsO { get; set; }
    }
}
