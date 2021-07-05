using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Storetrnsextexp
    {
        public decimal Id { get; set; }
        public decimal? Trnsmcode { get; set; }
        public decimal? Trnsscode { get; set; }

        public virtual StoreTrn TrnsmcodeNavigation { get; set; }
        public virtual StoreTrn TrnsscodeNavigation { get; set; }
    }
}
