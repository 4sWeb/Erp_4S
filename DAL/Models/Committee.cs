using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Committee
    {
        public Committee()
        {
            Committeedetails = new HashSet<Committeedetail>();
            EvalPricePromoComms = new HashSet<EvalPricePromoComm>();
            Storetrnsmcommittees = new HashSet<Storetrnsmcommittee>();
        }

        public decimal Id { get; set; }
        public string Name { get; set; }
        public string Namear { get; set; }
        public bool? Promotion { get; set; }

        public virtual ICollection<Committeedetail> Committeedetails { get; set; }
        public virtual ICollection<EvalPricePromoComm> EvalPricePromoComms { get; set; }
        public virtual ICollection<Storetrnsmcommittee> Storetrnsmcommittees { get; set; }
    }
}
