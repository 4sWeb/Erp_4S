using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Storetrnsmextexp
    {
        public decimal Id { get; set; }
        public decimal? Trnsmcode { get; set; }
        public decimal? Trnsscode { get; set; }
        public string Expcode { get; set; }
        public decimal? Expvalue { get; set; }

        public virtual StoreTrnsM TrnsmcodeNavigation { get; set; }
        public virtual StoreTrnsM TrnsscodeNavigation { get; set; }
    }
}
