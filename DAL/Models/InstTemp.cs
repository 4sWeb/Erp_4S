using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class InstTemp
    {
        public string Build { get; set; }
        public string Unit { get; set; }
        public decimal? Area { get; set; }
        public decimal? Garden { get; set; }
        public decimal? Roof { get; set; }
        public decimal? Price { get; set; }
        public long? BuidId { get; set; }
        public long? UnitId { get; set; }
    }
}
