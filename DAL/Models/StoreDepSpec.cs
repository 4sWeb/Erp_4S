using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class StoreDepSpec
    {
        public StoreDepSpec()
        {
            StoreDepSpecsDetails = new HashSet<StoreDepSpecsDetail>();
            StoreTrnsDepTemps = new HashSet<StoreTrnsDepTemp>();
            StoreTrnsDeps = new HashSet<StoreTrnsDep>();
        }

        public decimal Groupno { get; set; }
        public decimal Trnscode { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public decimal StoreDepSpecsId { get; set; }
        public decimal? DepVal { get; set; }

        public virtual StoreTrn TrnscodeNavigation { get; set; }
        public virtual ICollection<StoreDepSpecsDetail> StoreDepSpecsDetails { get; set; }
        public virtual ICollection<StoreTrnsDepTemp> StoreTrnsDepTemps { get; set; }
        public virtual ICollection<StoreTrnsDep> StoreTrnsDeps { get; set; }
    }
}
