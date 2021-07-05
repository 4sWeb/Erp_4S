using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class StoreTrnsMStage
    {
        public decimal Id { get; set; }
        public decimal? StoreTrnsmid { get; set; }
        public decimal? Satgeid { get; set; }
        public decimal? Duration { get; set; }
    }
}
