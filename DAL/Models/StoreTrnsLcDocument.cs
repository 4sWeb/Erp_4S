using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class StoreTrnsLcDocument
    {
        public decimal Id { get; set; }
        public decimal? Termcode { get; set; }
        public string Briefdesc { get; set; }
        public string Memo { get; set; }
        public decimal? StoreTrnsLcId { get; set; }
        public string Type { get; set; }

        public virtual StoreTrnsLc StoreTrnsLc { get; set; }
    }
}
