using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class StoreItemformUnit
    {
        public decimal? Unitid { get; set; }
        public decimal? UnitRate { get; set; }
        public bool? BasicUnit { get; set; }
        public decimal StoreItemformUnitsId { get; set; }
        public decimal? StoreItemformSpecsId { get; set; }

        public virtual StoreItemformsSpec StoreItemformSpecs { get; set; }
        public virtual StoreUnit Unit { get; set; }
    }
}
