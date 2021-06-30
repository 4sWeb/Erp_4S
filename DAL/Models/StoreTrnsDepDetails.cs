using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERPCOREDAL.Models
{
    public partial class StoreTrnsDepDetails
    {
        [Key]
        public int Depdetailsid { get; set; }
        public int? Ctrnsorowid { get; set; }
        public decimal? Ptrnsorowid { get; set; }
        public decimal? Quantity { get; set; }
        public int? ProwId { get; set; }
        public decimal? Itemid { get; set; }
        public decimal? Unitid { get; set; }
        public decimal? Unitprice { get; set; }
        public decimal? Commited { get; set; }
        public decimal? StoretrnsProformlaId { get; set; }
        public bool? Itemapproved { get; set; }

        [ForeignKey("Ctrnsorowid")]
        public virtual StoreTrnsO Ctrnsorow { get; set; }
        [ForeignKey("ProwId")]
        public virtual StoreTrnsDep Prow { get; set; }
    }
}
