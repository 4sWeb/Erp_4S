using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPCOREDAL.Models
{
    public partial class StoreTrnsoDimensionsdetails
    {
        public int Id { get; set; }
        public int? DimensionsdetailsId { get; set; }
        public int? StoreTrnsOId { get; set; }

        [ForeignKey("DimensionsdetailsId")]
        public virtual Dimensionsdetails Dimensionsdetails { get; set; }
        [ForeignKey("StoreTrnsOId")]
        public virtual StoreTrnsO StoreTrnsO { get; set; }
    }
}
