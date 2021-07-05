using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Storerectrnsdepdettemp
    {
        public decimal Id { get; set; }
        public decimal? Ctrnsorowid { get; set; }
        public decimal? Ptrnsorowid { get; set; }
        public decimal? TotalQty { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Remain { get; set; }
        public decimal? ProwId { get; set; }
        public decimal? Itemid { get; set; }
        public decimal? Unitid { get; set; }
        public decimal? Unitprice { get; set; }
        public decimal? Commited { get; set; }
        public decimal? StoretrnsProformlaId { get; set; }
        public bool? Itemapproved { get; set; }
    }
}
