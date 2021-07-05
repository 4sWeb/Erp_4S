using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class StoreTrnsDep
    {
        public StoreTrnsDep()
        {
            StoreTrnsDepDetails = new HashSet<StoreTrnsDepDetail>();
        }

        public decimal StoreTrnsDepId { get; set; }
        public decimal? Ctrnsrowid { get; set; }
        public decimal? Ptransrowid { get; set; }
        public decimal? Groupid { get; set; }
        public decimal? Depslot { get; set; }
        public decimal? Depdetailsid { get; set; }
        public decimal? Deptrnspayback { get; set; }
        public decimal? Commited { get; set; }

        public virtual StoreTrnsM Ctrnsrow { get; set; }
        public virtual StoreDepSpec Group { get; set; }
        public virtual StoreTrnsM Ptransrow { get; set; }
        public virtual ICollection<StoreTrnsDepDetail> StoreTrnsDepDetails { get; set; }
    }
}
