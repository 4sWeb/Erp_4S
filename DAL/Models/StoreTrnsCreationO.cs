using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class StoreTrnsCreationO
    {
        public decimal Id { get; set; }
        public decimal? NewTrnsId { get; set; }
        public decimal? OriginalTrnsId { get; set; }
        public decimal? NewOId { get; set; }
        public decimal? NewResId { get; set; }
    }
}
