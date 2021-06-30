using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPCOREDAL.Models
{
    public partial class Productformladetails
    {
        public int Id { get; set; }
        public int? Producatformlaid { get; set; }
        public int? StoreItemsId { get; set; }
        public decimal? Qty { get; set; }
        public int? Unitid { get; set; }
        public decimal? Factor { get; set; }

        [ForeignKey("Producatformlaid")]
        public virtual Producationformla Producatformla { get; set; }
        [ForeignKey("StoreItemsId")]
        public virtual StoreItems StoreItems { get; set; }
        [ForeignKey("Unitid")]
        public virtual StoreUnits Unit { get; set; }
    }
}
