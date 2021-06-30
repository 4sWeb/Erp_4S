using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPCOREDAL.Models
{
    public partial class StoreItemUnits
    {
        public int Unitid { get; set; }
        public decimal? UnitRate { get; set; }
        public bool? BasicUnit { get; set; }
        [Key]
        public int StoreItemUnitsId { get; set; }
        public int? StoreItemsId { get; set; }
        public string Barcode { get; set; }

        [ForeignKey("StoreItemsId")]
        public virtual StoreItems StoreItems { get; set; }
        [ForeignKey("Unitid")]
        public virtual StoreUnits Unit { get; set; }
    }
}
