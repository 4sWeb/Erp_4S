using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPCOREDAL.Models
{
    public partial class Productstages
    {
        public Productstages()
        {
            //StoreTrnsM = new HashSet<StoreTrnsM>();
        }

        public int Id { get; set; }
        public int? StoreItemsId { get; set; }
        public int? StageId { get; set; }
        public decimal? Rank { get; set; }
        public decimal? Rate { get; set; }
      
        [ForeignKey("StageId")]
        public virtual Stages Stage { get; set; }
        [ForeignKey("StoreItemsId")]
        public virtual StoreItems StoreItems { get; set; }
        //public virtual ICollection<StoreTrnsM> StoreTrnsM { get; set; }
    }
}
