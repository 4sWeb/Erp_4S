using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class StoreItemsingred
    {
        public decimal Id { get; set; }
        public decimal? Storeitemid { get; set; }
        public decimal? Storeallsubcodeid { get; set; }
        public string Concentration { get; set; }
        public string Mrl { get; set; }
        public string Processtype { get; set; }

        public virtual StoreAllsubcode Storeallsubcode { get; set; }
        public virtual StoreItem Storeitem { get; set; }
    }
}
