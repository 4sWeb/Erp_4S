using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class StoreUnit
    {
        public StoreUnit()
        {
            Productformladetails = new HashSet<Productformladetail>();
            ServicesTypes = new HashSet<ServicesType>();
            StoreInventoryOs = new HashSet<StoreInventoryO>();
            StoreItemUnits = new HashSet<StoreItemUnit>();
            StoreItemformUnits = new HashSet<StoreItemformUnit>();
            StoreItemsBals = new HashSet<StoreItemsBal>();
            StoreTrnsOTemps = new HashSet<StoreTrnsOTemp>();
            StoreTrnsOs = new HashSet<StoreTrnsO>();
            StoreTrnsPrices = new HashSet<StoreTrnsPrice>();
        }

        public decimal Unitid { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public string Saname { get; set; }
        public string Sename { get; set; }

        public virtual ICollection<Productformladetail> Productformladetails { get; set; }
        public virtual ICollection<ServicesType> ServicesTypes { get; set; }
        public virtual ICollection<StoreInventoryO> StoreInventoryOs { get; set; }
        public virtual ICollection<StoreItemUnit> StoreItemUnits { get; set; }
        public virtual ICollection<StoreItemformUnit> StoreItemformUnits { get; set; }
        public virtual ICollection<StoreItemsBal> StoreItemsBals { get; set; }
        public virtual ICollection<StoreTrnsOTemp> StoreTrnsOTemps { get; set; }
        public virtual ICollection<StoreTrnsO> StoreTrnsOs { get; set; }
        public virtual ICollection<StoreTrnsPrice> StoreTrnsPrices { get; set; }
    }
}
