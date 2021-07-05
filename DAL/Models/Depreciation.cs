using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Depreciation
    {
        public Depreciation()
        {
            Assets = new HashSet<Asset>();
            Assetsgroups = new HashSet<Assetsgroup>();
        }

        public decimal Id { get; set; }
        public string Depreciationaname { get; set; }
        public string Depreciationename { get; set; }
        public decimal? Depreciationcode { get; set; }
        public decimal? Value { get; set; }
        public bool? Depreciationtype { get; set; }

        public virtual ICollection<Asset> Assets { get; set; }
        public virtual ICollection<Assetsgroup> Assetsgroups { get; set; }
    }
}
