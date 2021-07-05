using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Committeedetail
    {
        public Committeedetail()
        {
            EvalPricePromoComms = new HashSet<EvalPricePromoComm>();
        }

        public decimal Id { get; set; }
        public decimal? Committeeid { get; set; }
        public string Empname { get; set; }
        public decimal? Empid { get; set; }

        public virtual Committee Committee { get; set; }
        public virtual ICollection<EvalPricePromoComm> EvalPricePromoComms { get; set; }
    }
}
