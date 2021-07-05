using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class StoreTrnsAccept
    {
        public StoreTrnsAccept()
        {
            AcceptInTrns = new HashSet<AcceptInTrn>();
            AcceptInTrnsTemps = new HashSet<AcceptInTrnsTemp>();
            TrnsUserAccepts = new HashSet<TrnsUserAccept>();
        }

        public decimal AcceptId { get; set; }
        public decimal AcceptSerial { get; set; }
        public string AcceptName { get; set; }
        public decimal TrnsCode { get; set; }

        public virtual StoreTrn TrnsCodeNavigation { get; set; }
        public virtual ICollection<AcceptInTrn> AcceptInTrns { get; set; }
        public virtual ICollection<AcceptInTrnsTemp> AcceptInTrnsTemps { get; set; }
        public virtual ICollection<TrnsUserAccept> TrnsUserAccepts { get; set; }
    }
}
