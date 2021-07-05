using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class StoreTrnsDepTemp
    {
        public StoreTrnsDepTemp()
        {
            StoreTrnsDepDetailsTemps = new HashSet<StoreTrnsDepDetailsTemp>();
        }

        public decimal StoreTrnsDepId { get; set; }
        public decimal? Ctrnsrowid { get; set; }
        public decimal? Ptransrowid { get; set; }
        public decimal? Groupid { get; set; }
        public decimal? Depslot { get; set; }
        public decimal? Depdetailsid { get; set; }
        public decimal? Deptrnspayback { get; set; }
        public decimal? Commited { get; set; }
        public string Rowstate { get; set; }

        public virtual StoreTrnsMTemp Ctrnsrow { get; set; }
        public virtual StoreDepSpec Group { get; set; }
        public virtual ICollection<StoreTrnsDepDetailsTemp> StoreTrnsDepDetailsTemps { get; set; }
    }
}
