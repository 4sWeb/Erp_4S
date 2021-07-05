using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class ItemchangemStoreTrn
    {
        public decimal Id { get; set; }
        public decimal? Itemchangeid { get; set; }
        public decimal? TrnsCode { get; set; }

        public virtual ItemChangePriceM Itemchange { get; set; }
        public virtual StoreTrn TrnsCodeNavigation { get; set; }
    }
}
