using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class StoreTrnsOStage
    {
        public decimal Id { get; set; }
        public decimal? StoreTrnsOid { get; set; }
        public decimal? Stageid { get; set; }
        public decimal? Duration { get; set; }
    }
}
