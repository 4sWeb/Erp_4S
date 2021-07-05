using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Storedsttype
    {
        public decimal? Trnscode { get; set; }
        public string Ft { get; set; }
        public decimal? Dsttype { get; set; }
        public decimal? Rank { get; set; }
        public decimal Dstid { get; set; }

        public virtual StoreTrn TrnscodeNavigation { get; set; }
    }
}
