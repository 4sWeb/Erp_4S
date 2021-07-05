using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Depreciationcalcm
    {
        public Depreciationcalcm()
        {
            Depreciationcalcos = new HashSet<Depreciationcalco>();
        }

        public decimal Id { get; set; }
        public decimal? Code { get; set; }
        public decimal? Fromgroupasset { get; set; }
        public decimal? Togroupasset { get; set; }
        public decimal? Fromasset { get; set; }
        public decimal? Toasset { get; set; }
        public DateTime? Todate { get; set; }
        public string Notes { get; set; }
        public decimal? Periodid { get; set; }

        public virtual Asset FromassetNavigation { get; set; }
        public virtual Assetsgroup FromgroupassetNavigation { get; set; }
        public virtual Period Period { get; set; }
        public virtual Asset ToassetNavigation { get; set; }
        public virtual Assetsgroup TogroupassetNavigation { get; set; }
        public virtual ICollection<Depreciationcalco> Depreciationcalcos { get; set; }
    }
}
