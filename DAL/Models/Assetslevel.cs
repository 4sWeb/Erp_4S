using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Assetslevel
    {
        public Assetslevel()
        {
            Assetsgroups = new HashSet<Assetsgroup>();
        }

        public decimal Id { get; set; }
        public decimal? Length { get; set; }
        public decimal? Levelno { get; set; }

        public virtual ICollection<Assetsgroup> Assetsgroups { get; set; }
    }
}
