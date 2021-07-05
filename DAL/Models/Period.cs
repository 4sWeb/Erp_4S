using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Period
    {
        public Period()
        {
            Assets = new HashSet<Asset>();
            Assetstranscations = new HashSet<Assetstranscation>();
            Checks = new HashSet<Check>();
            Depreciationcalcms = new HashSet<Depreciationcalcm>();
            Estimatedvals = new HashSet<Estimatedval>();
            Hafzams = new HashSet<Hafzam>();
            Rentforms = new HashSet<Rentform>();
            StoreAllcodesBegins = new HashSet<StoreAllcodesBegin>();
            StoreInventoryMs = new HashSet<StoreInventoryM>();
            StoreItemPrices = new HashSet<StoreItemPrice>();
            Userperiods = new HashSet<Userperiod>();
        }

        public decimal Period1 { get; set; }
        public string Aname { get; set; }
        public string Ename { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string OpenClose { get; set; }

        public virtual ICollection<Asset> Assets { get; set; }
        public virtual ICollection<Assetstranscation> Assetstranscations { get; set; }
        public virtual ICollection<Check> Checks { get; set; }
        public virtual ICollection<Depreciationcalcm> Depreciationcalcms { get; set; }
        public virtual ICollection<Estimatedval> Estimatedvals { get; set; }
        public virtual ICollection<Hafzam> Hafzams { get; set; }
        public virtual ICollection<Rentform> Rentforms { get; set; }
        public virtual ICollection<StoreAllcodesBegin> StoreAllcodesBegins { get; set; }
        public virtual ICollection<StoreInventoryM> StoreInventoryMs { get; set; }
        public virtual ICollection<StoreItemPrice> StoreItemPrices { get; set; }
        public virtual ICollection<Userperiod> Userperiods { get; set; }
    }
}
