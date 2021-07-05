using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class StoreTrnsDepDetail
    {
        public decimal Depdetailsid { get; set; }
        public decimal? Ctrnsorowid { get; set; }
        public decimal? Ptrnsorowid { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? ProwId { get; set; }
        public decimal? Itemid { get; set; }
        public decimal? Unitid { get; set; }
        public decimal? Unitprice { get; set; }
        public decimal? Commited { get; set; }
        public decimal? StoretrnsProformlaId { get; set; }
        public bool? Itemapproved { get; set; }

        public virtual StoreTrnsO Ctrnsorow { get; set; }
        public virtual StoreTrnsDep Prow { get; set; }
    }
}
