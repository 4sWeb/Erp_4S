using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class StoreTrnsDepDetailsTemp
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
        public string Rowstate { get; set; }
        public decimal? StoretrnsProformlaId { get; set; }
        public bool? Itemapproved { get; set; }

        public virtual StoreTrnsOTemp Ctrnsorow { get; set; }
        public virtual StoreTrnsDepTemp Prow { get; set; }
    }
}
