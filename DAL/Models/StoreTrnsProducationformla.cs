using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPCOREDAL.Models
{
    public partial class StoreTrnsProducationformla
    {
        public int Id { get; set; }
        public int? StoreTrnsoId { get; set; }
        public int? StoreItemsId { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Unitid { get; set; }

        [ForeignKey("StoreItemsId")]
        public virtual StoreItems StoreItems { get; set; }
        [ForeignKey("StoreTrnsoId")]
        public virtual StoreTrnsO StoreTrnso { get; set; }
    }
}
