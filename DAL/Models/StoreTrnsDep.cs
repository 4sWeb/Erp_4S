using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPCOREDAL.Models
{
    public partial class StoreTrnsDep
    {
        public StoreTrnsDep()
        {
          //StoreTrnsDepDetails = new HashSet<StoreTrnsDepDetails>();
        }

        [Key]
        public int StoreTrnsDepId { get; set; }
        public int? Ctrnsrowid { get; set; }
        public decimal? Ptransrowid { get; set; }
        public int? Groupid { get; set; }
        public decimal? Depslot { get; set; }
        public decimal? Depdetailsid { get; set; }
        public decimal? Deptrnspayback { get; set; }
        public decimal? Commited { get; set; }

        [ForeignKey("Ctrnsrowid")]
        public virtual StoreTrnsM Ctrnsrow { get; set; }
        [ForeignKey("Groupid")]
        public virtual StoreDepSpecs Group { get; set; }
       //public virtual ICollection<StoreTrnsDepDetails> StoreTrnsDepDetails { get; set; }
    }
}
