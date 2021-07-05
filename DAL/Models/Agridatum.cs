using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Agridatum
    {
        public Agridatum()
        {
            StoreTrnsMs = new HashSet<StoreTrnsM>();
        }

        public decimal Id { get; set; }
        public string Code { get; set; }
        public decimal? Typeid { get; set; }
        public decimal? Itemid { get; set; }
        public decimal? Previousitemid { get; set; }
        public string Name { get; set; }
        public string Namear { get; set; }
        public DateTime? Agridate { get; set; }
        public DateTime? Harvestdate { get; set; }
        public DateTime? Irritationdate { get; set; }
        public string Actualspace { get; set; }
        public string Agrispace { get; set; }
        public decimal? Dimensionid { get; set; }
        public decimal? Raiseid { get; set; }
        public decimal? Agriwayid { get; set; }
        public string Expectedqty { get; set; }
        public decimal? Agriorigin { get; set; }

        public virtual StoreAllsubcode AgrioriginNavigation { get; set; }
        public virtual StoreAllsubcode Agriway { get; set; }
        public virtual Dimensionsdetail Dimension { get; set; }
        public virtual StoreItem Item { get; set; }
        public virtual StoreItem Previousitem { get; set; }
        public virtual StoreAllsubcode Raise { get; set; }
        public virtual StoreAllcode Type { get; set; }
        public virtual ICollection<StoreTrnsM> StoreTrnsMs { get; set; }
    }
}
