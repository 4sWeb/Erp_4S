using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Financedisttype
    {
        public string Ft { get; set; }
        public byte? Rank { get; set; }
        public decimal Id { get; set; }
        public decimal? TrnsCode { get; set; }
        public decimal? Disttype { get; set; }

        public virtual Financespec TrnsCodeNavigation { get; set; }
    }
}
