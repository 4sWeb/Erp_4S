using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Productstage
    {
        public Productstage()
        {
            StoreTrnsMTemps = new HashSet<StoreTrnsMTemp>();
            StoreTrnsMs = new HashSet<StoreTrnsM>();
            StoreTrnsOTemps = new HashSet<StoreTrnsOTemp>();
            TrnsPrintSpecs = new HashSet<TrnsPrintSpec>();
        }

        public decimal Id { get; set; }
        public decimal? StoreItemsId { get; set; }
        public decimal? StageId { get; set; }
        public decimal? Rank { get; set; }
        public decimal? Rate { get; set; }

        public virtual Stage Stage { get; set; }
        public virtual StoreItem StoreItems { get; set; }
        public virtual ICollection<StoreTrnsMTemp> StoreTrnsMTemps { get; set; }
        public virtual ICollection<StoreTrnsM> StoreTrnsMs { get; set; }
        public virtual ICollection<StoreTrnsOTemp> StoreTrnsOTemps { get; set; }
        public virtual ICollection<TrnsPrintSpec> TrnsPrintSpecs { get; set; }
    }
}
