using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class LgDescriptionsM
    {
        public LgDescriptionsM()
        {
            LgDescriptionsOs = new HashSet<LgDescriptionsO>();
        }

        public decimal Id { get; set; }
        public decimal? LgTypesId { get; set; }
        public decimal? LgOpenCasesId { get; set; }
        public decimal? FinancespecTrnscode { get; set; }
        public string FromDest { get; set; }
        public string ToDest { get; set; }
        public string AmountFrom { get; set; }
        public decimal? LgStatusId { get; set; }
        public decimal? LgCategoryId { get; set; }

        public virtual Financespec FinancespecTrnscodeNavigation { get; set; }
        public virtual LgCategory LgCategory { get; set; }
        public virtual LgOpenCase LgOpenCases { get; set; }
        public virtual LgStatus LgStatus { get; set; }
        public virtual LgType LgTypes { get; set; }
        public virtual ICollection<LgDescriptionsO> LgDescriptionsOs { get; set; }
    }
}
