using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class LgDescriptionsO
    {
        public decimal Id { get; set; }
        public decimal? LgDescriptionsId { get; set; }
        public decimal? AccountstreeId { get; set; }
        public decimal? FinancespecTrnscode { get; set; }
        public string AmountFrom { get; set; }
        public decimal? AccountnatureId { get; set; }

        public virtual Accountnature Accountnature { get; set; }
        public virtual Accountstree Accountstree { get; set; }
        public virtual Financespec FinancespecTrnscodeNavigation { get; set; }
        public virtual LgDescriptionsM LgDescriptions { get; set; }
    }
}
