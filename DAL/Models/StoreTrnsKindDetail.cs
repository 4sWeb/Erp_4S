using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class StoreTrnsKindDetail
    {
        public decimal? StoreTrnsKindSpecId { get; set; }
        public decimal? TrnsId { get; set; }
        public decimal Id { get; set; }

        public virtual StoreTrnsKindSpec StoreTrnsKindSpec { get; set; }
    }
}
