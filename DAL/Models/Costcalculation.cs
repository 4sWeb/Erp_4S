using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Costcalculation
    {
        public decimal Id { get; set; }
        public decimal TrnsCode { get; set; }
        public bool ItemPrice { get; set; }
        public bool ItemPrice2 { get; set; }
        public bool ItemDisc { get; set; }
        public bool ItemDisc2 { get; set; }
        public bool TransportCost { get; set; }
        public bool TrnsDisc { get; set; }
        public bool TrnsTax { get; set; }
        public bool ItemTax { get; set; }
        public bool AddTax { get; set; }
        public bool DiscTax { get; set; }
        public bool AddExp { get; set; }
        public bool DiscExp { get; set; }
        public bool NotaffectExp { get; set; }

        public virtual StoreTrn TrnsCodeNavigation { get; set; }
    }
}
