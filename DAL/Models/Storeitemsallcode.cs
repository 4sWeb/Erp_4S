using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Storeitemsallcode
    {
        public decimal Id { get; set; }
        public decimal? Storeallcodeid { get; set; }
        public string Itemcode { get; set; }
        public decimal? Itemid { get; set; }
        public bool? Approved { get; set; }

        public virtual StoreItem Item { get; set; }
        public virtual StoreAllcode Storeallcode { get; set; }
    }
}
