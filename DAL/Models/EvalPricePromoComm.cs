using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class EvalPricePromoComm
    {
        public decimal Id { get; set; }
        public decimal? Evalpromoid { get; set; }
        public decimal? Committeid { get; set; }
        public decimal? Committeedetailid { get; set; }

        public virtual Committee Committe { get; set; }
        public virtual Committeedetail Committeedetail { get; set; }
        public virtual EvaluationPricePromation Evalpromo { get; set; }
    }
}
