using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class FinanceTrnsAccept
    {
        public FinanceTrnsAccept()
        {
            AcceptInFinancetrns = new HashSet<AcceptInFinancetrn>();
            FinancetrnsUserAccepts = new HashSet<FinancetrnsUserAccept>();
        }

        public decimal AcceptId { get; set; }
        public decimal AcceptSerial { get; set; }
        public string AcceptName { get; set; }
        public decimal TrnsCode { get; set; }

        public virtual Financespec TrnsCodeNavigation { get; set; }
        public virtual ICollection<AcceptInFinancetrn> AcceptInFinancetrns { get; set; }
        public virtual ICollection<FinancetrnsUserAccept> FinancetrnsUserAccepts { get; set; }
    }
}
